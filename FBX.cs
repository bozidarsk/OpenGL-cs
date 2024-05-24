using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.IO;

namespace OpenGL;

#pragma warning disable CS9084 // Struct member returns 'this' or other instance members by reference

[StructLayout(LayoutKind.Sequential)]
public unsafe ref struct FBX 
{
	public uint Version { get; }

	private ref NodeRecord root;

	private static readonly byte[] MAGIC = { 0x4b, 0x61, 0x79, 0x64, 0x61, 0x72, 0x61, 0x20, 0x46, 0x42, 0x58, 0x20, 0x42, 0x69, 0x6e, 0x61, 0x72, 0x79, 0x20, 0x20, 0x00 };

	public FBX(string file) : this((nint)Unsafe.AsPointer<byte>(ref new Span<byte>(File.ReadAllBytes(file)).GetPinnableReference())) {}
	public FBX(nint data) 
	{
		for (int i = 0; i < MAGIC.Length; i++)
			if (MAGIC[i] != ((byte*)data)[i])
				throw new FileFormatException("Invalid magic.");

		this.Version = *((uint*)(data + 23));
		this.root = ref Unsafe.AsRef<NodeRecord>((void*)(data + 27));

		for (ref NodeRecord record = ref root; record.HasNestedRecord; record = ref record.NestedRecord) 
		{
			Console.WriteLine($"-{record.Name}");

			if (record.Properties != null)
				foreach (object obj in record.Properties)
					Console.WriteLine(obj);
		}
	}

	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	private struct NodeRecord 
	{
		private uint size;
		private uint propertyCount;
		private uint propertyListLength;
		private byte nameLength;
		private byte data;

		public string Name => new string((sbyte*)Unsafe.AsPointer<byte>(ref data), 0, (int)nameLength);
		public bool HasNestedRecord => size > Marshal.OffsetOf<NodeRecord>("data") + nameLength + propertyListLength;
		public object[]? Properties 
		{
			get 
			{
				if (propertyCount < 0)
					return null;

				object[] array = new object[propertyCount];
				nuint offset = nameLength;

				for (int i = 0; i < propertyCount; i++) 
				{
					ref PropertyRecord property = ref Unsafe.As<byte, PropertyRecord>(ref Unsafe.Add<byte>(ref data, offset));
					array[i] = property.Data;
					offset += (nuint)property.Size;
				}

				return array;
			}
		}

		public ref NodeRecord NestedRecord 
		{
			get 
			{
				if (!HasNestedRecord)
					throw new NullReferenceException($"Node record '{Name}' does not hava a nested record.");

				return ref Unsafe.As<byte, NodeRecord>(ref Unsafe.Add<byte>(ref data, nameLength + propertyListLength));
			}
		}
	}

	[StructLayout(LayoutKind.Sequential)]
	private struct PropertyRecord 
	{
		private byte type;
		private byte data;

		public long Size => type switch 
		{
			(byte)'Y' => (sizeof(PropertyRecord) - 1) + sizeof(short),
			(byte)'C' => (sizeof(PropertyRecord) - 1) + sizeof(bool),
			(byte)'I' => (sizeof(PropertyRecord) - 1) + sizeof(int),
			(byte)'F' => (sizeof(PropertyRecord) - 1) + sizeof(float),
			(byte)'D' => (sizeof(PropertyRecord) - 1) + sizeof(double),
			(byte)'L' => (sizeof(PropertyRecord) - 1) + sizeof(long),

			(byte)'f' => (sizeof(PropertyRecord) - 1) + (sizeof(ArrayData) - 1) + (Unsafe.As<byte, ArrayData>(ref data).Length * sizeof(float)),
			(byte)'d' => (sizeof(PropertyRecord) - 1) + (sizeof(ArrayData) - 1) + (Unsafe.As<byte, ArrayData>(ref data).Length * sizeof(double)),
			(byte)'l' => (sizeof(PropertyRecord) - 1) + (sizeof(ArrayData) - 1) + (Unsafe.As<byte, ArrayData>(ref data).Length * sizeof(long)),
			(byte)'i' => (sizeof(PropertyRecord) - 1) + (sizeof(ArrayData) - 1) + (Unsafe.As<byte, ArrayData>(ref data).Length * sizeof(int)),
			(byte)'b' => (sizeof(PropertyRecord) - 1) + (sizeof(ArrayData) - 1) + (Unsafe.As<byte, ArrayData>(ref data).Length * sizeof(bool)),

			(byte)'S' => (sizeof(PropertyRecord) - 1) + (sizeof(RawData) - 1) + Unsafe.As<byte, RawData>(ref data).Length,
			(byte)'R' => (sizeof(PropertyRecord) - 1) + (sizeof(RawData) - 1) + Unsafe.As<byte, RawData>(ref data).Length,

			_ => throw new FormatException($"Invalid property type 0x{type:x2}" + (!char.IsControl((char)type) ? $" ('{(char)type}')." : ".")),
		};

		public object Data => type switch 
		{
			(byte)'Y' => Unsafe.As<byte, short>(ref data),
			(byte)'C' => Unsafe.As<byte, bool>(ref data),
			(byte)'I' => Unsafe.As<byte, int>(ref data),
			(byte)'F' => Unsafe.As<byte, float>(ref data),
			(byte)'D' => Unsafe.As<byte, double>(ref data),
			(byte)'L' => Unsafe.As<byte, long>(ref data),

			(byte)'f' => AsTypeArray<float>(),
			(byte)'d' => AsTypeArray<double>(),
			(byte)'l' => AsTypeArray<long>(),
			(byte)'i' => AsTypeArray<int>(),
			(byte)'b' => AsTypeArray<bool>(),

			(byte)'S' => AsString(),
			(byte)'R' => AsBytes(),

			_ => throw new FormatException($"Invalid property type 0x{type:x2}" + (!char.IsControl((char)type) ? $"('{(char)type}')." : ".")),
		};

		private T[] AsTypeArray<T>() where T : unmanaged
		{
			ArrayData arrayData = Unsafe.As<byte, ArrayData>(ref data);

			T[] array = new T[arrayData.Length];
			ref T pointer = ref arrayData.As<T>();

			for (int i = 0; i < array.Length; i++)
				array[i] = Unsafe.Add<T>(ref pointer, i);

			return array;
		}

		private string AsString() 
		{
			RawData rawData = Unsafe.As<byte, RawData>(ref data);
			return new string((sbyte*)Unsafe.AsPointer<sbyte>(ref rawData.As<sbyte>()), 0, rawData.Length);
		}

		private byte[] AsBytes() 
		{
			RawData rawData = Unsafe.As<byte, RawData>(ref data);

			byte[] array = new byte[rawData.Length];
			ref byte pointer = ref rawData.As<byte>();

			for (int i = 0; i < array.Length; i++)
				array[i] = Unsafe.Add<byte>(ref pointer, i);

			return array;
		}

		[StructLayout(LayoutKind.Sequential, Pack = 1)]
		private struct ArrayData 
		{
			private uint arrayLength;
			private uint encoding;
			private uint compressedLength;
			private byte data;

			public int Length => (int)arrayLength; // TODO: check encoding and compressedLength

			public ref T As<T>() where T : unmanaged => ref Unsafe.As<byte, T>(ref data);
		}

		[StructLayout(LayoutKind.Sequential, Pack = 1)]
		private struct RawData 
		{
			private uint length;
			private byte data;

			public int Length => (int)length;

			public ref T As<T>() where T : unmanaged => ref Unsafe.As<byte, T>(ref data);
		}
	}
}
