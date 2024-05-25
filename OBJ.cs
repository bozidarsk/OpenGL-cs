using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;

namespace OpenGL;

public sealed class OBJ 
{
	public List<Vertex> Vertices = new();
	public List<uint> Indices = new();

	public Mesh Mesh => new Mesh(Vertices.ToArray(), Indices.ToArray());

	public void Save(string file) 
	{
		if (Indices.Count % 3 != 0)
			throw new InvalidOperationException("Mesh is not triangulated.");

		IEnumerable<string> getLines() 
		{
			foreach (IEnumerable<string> line in Vertices
				.Select(x => {
					static IEnumerable<string> formatVertex(Vertex vertex) 
					{
						yield return $"v {vertex.Position.x:f6} {vertex.Position.y:f6} {vertex.Position.z:f6}";
						yield return $"vn {vertex.Normal.x:f4} {vertex.Normal.y:f4} {vertex.Normal.z:f4}";
						yield return $"vt {vertex.UV.x:f6} {vertex.UV.y:f6}";
					}

					return formatVertex(x);
				})
			) foreach (string subline in line) yield return subline;

			foreach (string[] triangle in Indices
				.Select(x => (x + 1).ToString())
				.Chunk(3)
			) yield return $"f {triangle[0]}/{triangle[0]}/{triangle[0]} {triangle[1]}/{triangle[1]}/{triangle[1]} {triangle[2]}/{triangle[2]}/{triangle[2]}";
		}

		File.WriteAllLines(file, getLines());
	}

	public static OBJ FromFile(string file) => new OBJ(File.ReadAllLines(file));

	public OBJ(List<Vertex> vertices, List<uint> indices) => (this.Vertices, this.Indices) = (vertices, indices);
	public OBJ(string obj) : this(obj.Split('\n', '\r')) {}
	public OBJ(IEnumerable<string> obj) 
	{
		List<Vector3> v = new() { Vector3.Zero };
		List<Vector3> vn = new() { Vector3.Zero };
		List<Vector2> vt = new() { Vector2.Zero };
		List<string> f = new();

		foreach (string line in obj
			.Select(x => x.TrimStart())
			.Where(x => !string.IsNullOrWhiteSpace(x) && x[0] != '#')
		) 
		{
			IEnumerable<string> tokens = line.Split(' ').Where(x => !string.IsNullOrWhiteSpace(x));
			switch (tokens.First()) 
			{
				case "v":
					v.Add(new Vector3(
						float.Parse(tokens.ElementAt(1)),
						float.Parse(tokens.ElementAt(2)),
						float.Parse(tokens.ElementAt(3))
					));
					break;
				case "vn":
					vn.Add(new Vector3(
						float.Parse(tokens.ElementAt(1)),
						float.Parse(tokens.ElementAt(2)),
						float.Parse(tokens.ElementAt(3))
					));
					break;
				case "vt":
					vt.Add(new Vector2(
						float.Parse(tokens.ElementAt(1)),
						float.Parse(tokens.ElementAt(2))
					));
					break;
				case "f":
					f.Add(tokens.ElementAt(1));
					f.Add(tokens.ElementAt(2));
					f.Add(tokens.ElementAt(3));
					break;
			}
		}

		if (f.Count % 3 != 0)
			throw new InvalidOperationException("Mesh is not triangulated.");

		Dictionary<string, uint> map = new();

		foreach (string index in f) 
		{
			int vi, vti, vni;

			void parse(string x) 
			{
				string[] i = x.Split('/');
				(vi, vti, vni) = (0, 0, 0);

				switch (i.Length) 
				{
					case 1:
						vi = int.Parse(i[0]);
						break;
					case 2:
						vi = int.Parse(i[0]);
						vti = int.Parse(i[1]);
						break;
					case 3:
						vi = int.Parse(i[0]);
						vti = !string.IsNullOrWhiteSpace(i[1]) ? int.Parse(i[1]) : 0;
						vni = int.Parse(i[2]);
						break;
					default:
						throw new InvalidOperationException();
				}

				if (vi < 0) vi = v.Count + vi;
				if (vti < 0) vti = vt.Count + vti;
				if (vni < 0) vni = vn.Count + vni;
			}

			parse(index);

			if (map.TryGetValue(index, out uint value)) 
			{
				this.Indices.Add(value);
				continue;
			}

			this.Indices.Add((uint)this.Vertices.Count);
			this.Vertices.Add(new Vertex(v[vi], vn[vni], vt[vti]));

			map.Add(index, this.Indices.Last());
		}
	}
}
