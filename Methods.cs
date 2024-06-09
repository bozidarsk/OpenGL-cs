using System;
using System.Reflection;
using System.Runtime.InteropServices;

using static OpenGL.Constants;

using  GLboolean = bool;
using  GLbyte = sbyte;
using  GLubyte = bool;
using  GLshort = short;
using  GLushort = ushort;
using  GLint = int;
using  GLuint = uint;
// using  GLfixed = uint;
using  GLint64 = long;
using  GLuint64 = ulong;
using  GLsizei = int;
using  GLenum = uint;
using  GLintptr = nint;
using  GLuintptr = nuint;
using  GLsizeiptr = nuint;
using  GLsync = nuint;
using  GLbitfield = uint;
// using  GLhalf = ushort;
using  GLfloat = float;
using  GLclampf = float;
using  GLdouble = double;
using  GLclampd = double;
using  GLchar = byte;

namespace OpenGL;

public static unsafe class Methods 
{
	public static nint GetMethodAddress(string name) 
	{
		if (name == null)
			throw new ArgumentNullException();

		[DllImport(GL_LIB, CharSet = CharSet.Ansi)]
		static extern nint wglGetProcAddress(string name);

		nint pointer = wglGetProcAddress(name);
		return (pointer != nint.Zero) ? pointer : throw new MethodAccessException($"Method '{name}' was not found.");
	}

	/*
	// TEMPLATE
	public static readonly AAAAADelegate AAAAA = Marshal.GetDelegateForFunctionPointer<AAAAADelegate>(GetMethodAddress("AAAAA"));
	public delegate CC AAAAADelegate(Aa aa, Bb bb);
	*/
















































	public static readonly glActiveShaderProgramDelegate glActiveShaderProgram = Marshal.GetDelegateForFunctionPointer<glActiveShaderProgramDelegate>(GetMethodAddress("glActiveShaderProgram"));
	public delegate void glActiveShaderProgramDelegate(GLuint pipeline, GLuint program);

	public static readonly glActiveTextureDelegate glActiveTexture = Marshal.GetDelegateForFunctionPointer<glActiveTextureDelegate>(GetMethodAddress("glActiveTexture"));
	public delegate void glActiveTextureDelegate(GLenum texture);

	public static readonly glAttachShaderDelegate glAttachShader = Marshal.GetDelegateForFunctionPointer<glAttachShaderDelegate>(GetMethodAddress("glAttachShader"));
	public delegate void glAttachShaderDelegate(GLuint program, GLuint shader);

	public static readonly glBeginConditionalRenderDelegate glBeginConditionalRender = Marshal.GetDelegateForFunctionPointer<glBeginConditionalRenderDelegate>(GetMethodAddress("glBeginConditionalRender"));
	public delegate void glBeginConditionalRenderDelegate(GLuint id, GLenum mode);

	public static readonly glEndConditionalRenderDelegate glEndConditionalRender = Marshal.GetDelegateForFunctionPointer<glEndConditionalRenderDelegate>(GetMethodAddress("glEndConditionalRender"));
	public delegate void glEndConditionalRenderDelegate();

	public static readonly glBeginQueryDelegate glBeginQuery = Marshal.GetDelegateForFunctionPointer<glBeginQueryDelegate>(GetMethodAddress("glBeginQuery"));
	public delegate void glBeginQueryDelegate(GLenum target, GLuint id);

	public static readonly glEndQueryDelegate glEndQuery = Marshal.GetDelegateForFunctionPointer<glEndQueryDelegate>(GetMethodAddress("glEndQuery"));
	public delegate void glEndQueryDelegate(GLenum target);

	public static readonly glBeginQueryIndexedDelegate glBeginQueryIndexed = Marshal.GetDelegateForFunctionPointer<glBeginQueryIndexedDelegate>(GetMethodAddress("glBeginQueryIndexed"));
	public delegate void glBeginQueryIndexedDelegate(GLenum target, GLuint index, GLuint id);

	public static readonly glEndQueryIndexedDelegate glEndQueryIndexed = Marshal.GetDelegateForFunctionPointer<glEndQueryIndexedDelegate>(GetMethodAddress("glEndQueryIndexed"));
	public delegate void glEndQueryIndexedDelegate(GLenum target, GLuint index);

	public static readonly glBeginTransformFeedbackDelegate glBeginTransformFeedback = Marshal.GetDelegateForFunctionPointer<glBeginTransformFeedbackDelegate>(GetMethodAddress("glBeginTransformFeedback"));
	public delegate void glBeginTransformFeedbackDelegate(GLenum primitiveMode);

	public static readonly glEndTransformFeedbackDelegate glEndTransformFeedback = Marshal.GetDelegateForFunctionPointer<glEndTransformFeedbackDelegate>(GetMethodAddress("glEndTransformFeedback"));
	public delegate void glEndTransformFeedbackDelegate();

	public static readonly glBindAttribLocationDelegate glBindAttribLocation = Marshal.GetDelegateForFunctionPointer<glBindAttribLocationDelegate>(GetMethodAddress("glBindAttribLocation"));
	public delegate void glBindAttribLocationDelegate(GLuint program, GLuint index, sbyte* name);

	public static readonly glBindBufferDelegate glBindBuffer = Marshal.GetDelegateForFunctionPointer<glBindBufferDelegate>(GetMethodAddress("glBindBuffer"));
	public delegate void glBindBufferDelegate(GLenum target, GLuint buffer);

	public static readonly glBindBufferBaseDelegate glBindBufferBase = Marshal.GetDelegateForFunctionPointer<glBindBufferBaseDelegate>(GetMethodAddress("glBindBufferBase"));
	public delegate void glBindBufferBaseDelegate(GLenum target, GLuint index, GLuint buffer);

	public static readonly glBindBufferRangeDelegate glBindBufferRange = Marshal.GetDelegateForFunctionPointer<glBindBufferRangeDelegate>(GetMethodAddress("glBindBufferRange"));
	public delegate void glBindBufferRangeDelegate(GLenum target, GLuint index, GLuint buffer, GLintptr offset, GLsizeiptr size);

	public static readonly glBindBuffersBaseDelegate glBindBuffersBase = Marshal.GetDelegateForFunctionPointer<glBindBuffersBaseDelegate>(GetMethodAddress("glBindBuffersBase"));
	public delegate void glBindBuffersBaseDelegate(GLenum target, GLuint first, GLsizei count, GLuint* buffers);

	public static readonly glBindBuffersRangeDelegate glBindBuffersRange = Marshal.GetDelegateForFunctionPointer<glBindBuffersRangeDelegate>(GetMethodAddress("glBindBuffersRange"));
	public delegate void glBindBuffersRangeDelegate(GLenum target, GLuint first, GLsizei count, GLuint* buffers, GLintptr* offsets, GLintptr* sizes);

	public static readonly glBindFragDataLocationDelegate glBindFragDataLocation = Marshal.GetDelegateForFunctionPointer<glBindFragDataLocationDelegate>(GetMethodAddress("glBindFragDataLocation"));
	public delegate void glBindFragDataLocationDelegate(GLuint program, GLuint colorNumber, sbyte* name);

	public static readonly glBindFragDataLocationIndexedDelegate glBindFragDataLocationIndexed = Marshal.GetDelegateForFunctionPointer<glBindFragDataLocationIndexedDelegate>(GetMethodAddress("glBindFragDataLocationIndexed"));
	public delegate void glBindFragDataLocationIndexedDelegate(GLuint program, GLuint colorNumber, GLuint index, sbyte* name);

	public static readonly glBindFramebufferDelegate glBindFramebuffer = Marshal.GetDelegateForFunctionPointer<glBindFramebufferDelegate>(GetMethodAddress("glBindFramebuffer"));
	public delegate void glBindFramebufferDelegate(GLenum target, GLuint framebuffer);

	public static readonly glBindImageTextureDelegate glBindImageTexture = Marshal.GetDelegateForFunctionPointer<glBindImageTextureDelegate>(GetMethodAddress("glBindImageTexture"));
	public delegate void glBindImageTextureDelegate(GLuint unit, GLuint texture, GLint level, GLboolean layered, GLint layer, GLenum access, GLenum format);

	public static readonly glBindImageTexturesDelegate glBindImageTextures = Marshal.GetDelegateForFunctionPointer<glBindImageTexturesDelegate>(GetMethodAddress("glBindImageTextures"));
	public delegate void glBindImageTexturesDelegate(GLuint first, GLsizei count, GLuint* textures);

	public static readonly glBindProgramPipelineDelegate glBindProgramPipeline = Marshal.GetDelegateForFunctionPointer<glBindProgramPipelineDelegate>(GetMethodAddress("glBindProgramPipeline"));
	public delegate void glBindProgramPipelineDelegate(GLuint pipeline);

	public static readonly glBindRenderbufferDelegate glBindRenderbuffer = Marshal.GetDelegateForFunctionPointer<glBindRenderbufferDelegate>(GetMethodAddress("glBindRenderbuffer"));
	public delegate void glBindRenderbufferDelegate(GLenum target, GLuint renderbuffer);

	public static readonly glBindSamplerDelegate glBindSampler = Marshal.GetDelegateForFunctionPointer<glBindSamplerDelegate>(GetMethodAddress("glBindSampler"));
	public delegate void glBindSamplerDelegate(GLuint unit, GLuint sampler);

	public static readonly glBindSamplersDelegate glBindSamplers = Marshal.GetDelegateForFunctionPointer<glBindSamplersDelegate>(GetMethodAddress("glBindSamplers"));
	public delegate void glBindSamplersDelegate(GLuint first, GLsizei count, GLuint* samplers);

	public static readonly glBindTextureDelegate glBindTexture = Marshal.GetDelegateForFunctionPointer<glBindTextureDelegate>(GetMethodAddress("glBindTexture"));
	public delegate void glBindTextureDelegate(GLenum target, GLuint texture);

	public static readonly glBindTexturesDelegate glBindTextures = Marshal.GetDelegateForFunctionPointer<glBindTexturesDelegate>(GetMethodAddress("glBindTextures"));
	public delegate void glBindTexturesDelegate(GLuint first, GLsizei count, GLuint* textures);

	public static readonly glBindTextureUnitDelegate glBindTextureUnit = Marshal.GetDelegateForFunctionPointer<glBindTextureUnitDelegate>(GetMethodAddress("glBindTextureUnit"));
	public delegate void glBindTextureUnitDelegate(GLuint unit, GLuint texture);

	public static readonly glBindTransformFeedbackDelegate glBindTransformFeedback = Marshal.GetDelegateForFunctionPointer<glBindTransformFeedbackDelegate>(GetMethodAddress("glBindTransformFeedback"));
	public delegate void glBindTransformFeedbackDelegate(GLenum target, GLuint id);

	public static readonly glBindVertexArrayDelegate glBindVertexArray = Marshal.GetDelegateForFunctionPointer<glBindVertexArrayDelegate>(GetMethodAddress("glBindVertexArray"));
	public delegate void glBindVertexArrayDelegate(GLuint array);

	public static readonly glBindVertexBufferDelegate glBindVertexBuffer = Marshal.GetDelegateForFunctionPointer<glBindVertexBufferDelegate>(GetMethodAddress("glBindVertexBuffer"));
	public delegate void glBindVertexBufferDelegate(GLuint bindingindex, GLuint buffer, GLintptr offset, GLintptr stride);

	public static readonly glVertexArrayVertexBufferDelegate glVertexArrayVertexBuffer = Marshal.GetDelegateForFunctionPointer<glVertexArrayVertexBufferDelegate>(GetMethodAddress("glVertexArrayVertexBuffer"));
	public delegate void glVertexArrayVertexBufferDelegate(GLuint vaobj, GLuint bindingindex, GLuint buffer, GLintptr offset, GLsizei stride);

	public static readonly glBindVertexBuffersDelegate glBindVertexBuffers = Marshal.GetDelegateForFunctionPointer<glBindVertexBuffersDelegate>(GetMethodAddress("glBindVertexBuffers"));
	public delegate void glBindVertexBuffersDelegate(GLuint first, GLsizei count, GLuint* buffers, GLuintptr* offsets, GLsizei* strides);

	public static readonly glVertexArrayVertexBuffersDelegate glVertexArrayVertexBuffers = Marshal.GetDelegateForFunctionPointer<glVertexArrayVertexBuffersDelegate>(GetMethodAddress("glVertexArrayVertexBuffers"));
	public delegate void glVertexArrayVertexBuffersDelegate(GLuint vaobj, GLuint first, GLsizei count, GLuint* buffers, GLintptr* offsets, GLsizei* strides);

	public static readonly glBlendColorDelegate glBlendColor = Marshal.GetDelegateForFunctionPointer<glBlendColorDelegate>(GetMethodAddress("glBlendColor"));
	public delegate void glBlendColorDelegate(GLfloat red, GLfloat green, GLfloat blue, GLfloat alpha);

	public static readonly glBlendEquationDelegate glBlendEquation = Marshal.GetDelegateForFunctionPointer<glBlendEquationDelegate>(GetMethodAddress("glBlendEquation"));
	public delegate void glBlendEquationDelegate(GLenum mode);

	public static readonly glBlendEquationiDelegate glBlendEquationi = Marshal.GetDelegateForFunctionPointer<glBlendEquationiDelegate>(GetMethodAddress("glBlendEquationi"));
	public delegate void glBlendEquationiDelegate(GLuint buf, GLenum mode);

	public static readonly glBlendEquationSeparateDelegate glBlendEquationSeparate = Marshal.GetDelegateForFunctionPointer<glBlendEquationSeparateDelegate>(GetMethodAddress("glBlendEquationSeparate"));
	public delegate void glBlendEquationSeparateDelegate(GLenum modeRGB, GLenum modeAlpha);

	public static readonly glBlendEquationSeparateiDelegate glBlendEquationSeparatei = Marshal.GetDelegateForFunctionPointer<glBlendEquationSeparateiDelegate>(GetMethodAddress("glBlendEquationSeparatei"));
	public delegate void glBlendEquationSeparateiDelegate(GLuint buf, GLenum modeRGB, GLenum modeAlpha);

	[DllImport(GL_LIB)] public static extern void glBlendFunc(GLenum sfactor, GLenum dfactor);
	// public static readonly glBlendFuncDelegate glBlendFunc = Marshal.GetDelegateForFunctionPointer<glBlendFuncDelegate>(GetMethodAddress("glBlendFunc"));
	// public delegate void glBlendFuncDelegate(GLenum sfactor, GLenum dfactor);

	// public static readonly glBlendFunciDelegate glBlendFunci = Marshal.GetDelegateForFunctionPointer<glBlendFunciDelegate>(GetMethodAddress("glBlendFunci"));
	// public delegate void glBlendFunciDelegate(GLuint buf, GLenum sfactor, GLenum dfactor);

	// public static readonly glBlendFuncSeparateDelegate glBlendFuncSeparate = Marshal.GetDelegateForFunctionPointer<glBlendFuncSeparateDelegate>(GetMethodAddress("glBlendFuncSeparate"));
	// public delegate void glBlendFuncSeparateDelegate(GLenum srcRGB, GLenum dstRGB, GLenum srcAlpha, GLenum dstAlpha);

	// public static readonly glBlendFuncSeparateiDelegate glBlendFuncSeparatei = Marshal.GetDelegateForFunctionPointer<glBlendFuncSeparateiDelegate>(GetMethodAddress("glBlendFuncSeparatei"));
	// public delegate void glBlendFuncSeparateiDelegate(GLuint buf, GLenum srcRGB, GLenum dstRGB, GLenum srcAlpha, GLenum dstAlpha);

	public static readonly glBlitFramebufferDelegate glBlitFramebuffer = Marshal.GetDelegateForFunctionPointer<glBlitFramebufferDelegate>(GetMethodAddress("glBlitFramebuffer"));
	public delegate void glBlitFramebufferDelegate(GLint srcX0, GLint srcY0, GLint srcX1, GLint srcY1, GLint dstX0, GLint dstY0, GLint dstX1, GLint dstY1, GLbitfield mask, GLenum filter);

	public static readonly glBlitNamedFramebufferDelegate glBlitNamedFramebuffer = Marshal.GetDelegateForFunctionPointer<glBlitNamedFramebufferDelegate>(GetMethodAddress("glBlitNamedFramebuffer"));
	public delegate void glBlitNamedFramebufferDelegate(GLuint readFramebuffer, GLuint drawFramebuffer, GLint srcX0, GLint srcY0, GLint srcX1, GLint srcY1, GLint dstX0, GLint dstY0, GLint dstX1, GLint dstY1, GLbitfield mask, GLenum filter);

	public static readonly glBufferDataDelegate glBufferData = Marshal.GetDelegateForFunctionPointer<glBufferDataDelegate>(GetMethodAddress("glBufferData"));
	public delegate void glBufferDataDelegate(GLenum target, GLsizeiptr size, nint data, GLenum usage);

	public static readonly glNamedBufferDataDelegate glNamedBufferData = Marshal.GetDelegateForFunctionPointer<glNamedBufferDataDelegate>(GetMethodAddress("glNamedBufferData"));
	public delegate void glNamedBufferDataDelegate(GLuint buffer, GLsizeiptr size, nint data, GLenum usage);

	public static readonly glBufferStorageDelegate glBufferStorage = Marshal.GetDelegateForFunctionPointer<glBufferStorageDelegate>(GetMethodAddress("glBufferStorage"));
	public delegate void glBufferStorageDelegate(GLenum target, GLsizeiptr size, nint data, GLbitfield flags);

	public static readonly glNamedBufferStorageDelegate glNamedBufferStorage = Marshal.GetDelegateForFunctionPointer<glNamedBufferStorageDelegate>(GetMethodAddress("glNamedBufferStorage"));
	public delegate void glNamedBufferStorageDelegate(GLuint buffer, GLsizeiptr size, nint data, GLbitfield flags);

	public static readonly glBufferSubDataDelegate glBufferSubData = Marshal.GetDelegateForFunctionPointer<glBufferSubDataDelegate>(GetMethodAddress("glBufferSubData"));
	public delegate void glBufferSubDataDelegate(GLenum target, GLintptr offset, GLsizeiptr size, nint data);

	public static readonly glNamedBufferSubDataDelegate glNamedBufferSubData = Marshal.GetDelegateForFunctionPointer<glNamedBufferSubDataDelegate>(GetMethodAddress("glNamedBufferSubData"));
	public delegate void glNamedBufferSubDataDelegate(GLuint buffer, GLintptr offset, GLsizei size, nint data);

	public static readonly glCheckFramebufferStatusDelegate glCheckFramebufferStatus = Marshal.GetDelegateForFunctionPointer<glCheckFramebufferStatusDelegate>(GetMethodAddress("glCheckFramebufferStatus"));
	public delegate GLenum glCheckFramebufferStatusDelegate(GLenum target);

	public static readonly glCheckNamedFramebufferStatusDelegate glCheckNamedFramebufferStatus = Marshal.GetDelegateForFunctionPointer<glCheckNamedFramebufferStatusDelegate>(GetMethodAddress("glCheckNamedFramebufferStatus"));
	public delegate GLenum glCheckNamedFramebufferStatusDelegate(GLuint framebuffer, GLenum target);

	public static readonly glClampColorDelegate glClampColor = Marshal.GetDelegateForFunctionPointer<glClampColorDelegate>(GetMethodAddress("glClampColor"));
	public delegate void glClampColorDelegate(GLenum target, GLenum clamp);

	[DllImport(GL_LIB)] public static extern void glClear(GLbitfield mask);
	// public static readonly glClearDelegate glClear = Marshal.GetDelegateForFunctionPointer<glClearDelegate>(GetMethodAddress("glClear"));
	// public delegate void glClearDelegate(GLbitfield mask);

	public static readonly glClearBufferivDelegate glClearBufferiv = Marshal.GetDelegateForFunctionPointer<glClearBufferivDelegate>(GetMethodAddress("glClearBufferiv"));
	public delegate void glClearBufferivDelegate(GLenum buffer, GLint drawbuffer, GLint* value);

	public static readonly glClearBufferuivDelegate glClearBufferuiv = Marshal.GetDelegateForFunctionPointer<glClearBufferuivDelegate>(GetMethodAddress("glClearBufferuiv"));
	public delegate void glClearBufferuivDelegate(GLenum buffer, GLint drawbuffer, GLuint* value);

	public static readonly glClearBufferfvDelegate glClearBufferfv = Marshal.GetDelegateForFunctionPointer<glClearBufferfvDelegate>(GetMethodAddress("glClearBufferfv"));
	public delegate void glClearBufferfvDelegate(GLenum buffer, GLint drawbuffer, GLfloat* value);

	public static readonly glClearBufferfiDelegate glClearBufferfi = Marshal.GetDelegateForFunctionPointer<glClearBufferfiDelegate>(GetMethodAddress("glClearBufferfi"));
	public delegate void glClearBufferfiDelegate(GLenum buffer, GLint drawbuffer, GLfloat depth, GLint stencil);

	public static readonly glClearNamedFramebufferivDelegate glClearNamedFramebufferiv = Marshal.GetDelegateForFunctionPointer<glClearNamedFramebufferivDelegate>(GetMethodAddress("glClearNamedFramebufferiv"));
	public delegate void glClearNamedFramebufferivDelegate(GLuint framebuffer, GLenum buffer, GLint drawbuffer, GLint* value);

	public static readonly glClearNamedFramebufferuivDelegate glClearNamedFramebufferuiv = Marshal.GetDelegateForFunctionPointer<glClearNamedFramebufferuivDelegate>(GetMethodAddress("glClearNamedFramebufferuiv"));
	public delegate void glClearNamedFramebufferuivDelegate(GLuint framebuffer, GLenum buffer, GLint drawbuffer, GLuint* value);

	public static readonly glClearNamedFramebufferfvDelegate glClearNamedFramebufferfv = Marshal.GetDelegateForFunctionPointer<glClearNamedFramebufferfvDelegate>(GetMethodAddress("glClearNamedFramebufferfv"));
	public delegate void glClearNamedFramebufferfvDelegate(GLuint framebuffer, GLenum buffer, GLint drawbuffer, GLfloat* value);

	public static readonly glClearNamedFramebufferfiDelegate glClearNamedFramebufferfi = Marshal.GetDelegateForFunctionPointer<glClearNamedFramebufferfiDelegate>(GetMethodAddress("glClearNamedFramebufferfi"));
	public delegate void glClearNamedFramebufferfiDelegate(GLuint framebuffer, GLenum buffer, GLint drawbuffer, GLfloat depth, GLint stencil);

	public static readonly glClearBufferDataDelegate glClearBufferData = Marshal.GetDelegateForFunctionPointer<glClearBufferDataDelegate>(GetMethodAddress("glClearBufferData"));
	public delegate void glClearBufferDataDelegate(GLenum target, GLenum internalformat, GLenum format, GLenum type, nint data);

	public static readonly glClearNamedBufferDataDelegate glClearNamedBufferData = Marshal.GetDelegateForFunctionPointer<glClearNamedBufferDataDelegate>(GetMethodAddress("glClearNamedBufferData"));
	public delegate void glClearNamedBufferDataDelegate(GLuint buffer, GLenum internalformat, GLenum format, GLenum type, nint data);

	public static readonly glClearBufferSubDataDelegate glClearBufferSubData = Marshal.GetDelegateForFunctionPointer<glClearBufferSubDataDelegate>(GetMethodAddress("glClearBufferSubData"));
	public delegate void glClearBufferSubDataDelegate(GLenum target, GLenum internalformat, GLintptr offset, GLsizeiptr size, GLenum format, GLenum type, nint data);

	public static readonly glClearNamedBufferSubDataDelegate glClearNamedBufferSubData = Marshal.GetDelegateForFunctionPointer<glClearNamedBufferSubDataDelegate>(GetMethodAddress("glClearNamedBufferSubData"));
	public delegate void glClearNamedBufferSubDataDelegate(GLuint buffer, GLenum internalformat, GLintptr offset, GLsizei size, GLenum format, GLenum type, nint data);

	// public static readonly glClearColorDelegate glClearColor = Marshal.GetDelegateForFunctionPointer<glClearColorDelegate>(GetMethodAddress("glClearColor"));
	// public delegate void glClearColorDelegate(GLfloat red, GLfloat green, GLfloat blue, GLfloat alpha);

	// public static readonly glClearDepthDelegate glClearDepth = Marshal.GetDelegateForFunctionPointer<glClearDepthDelegate>(GetMethodAddress("glClearDepth"));
	// public delegate void glClearDepthDelegate(GLdouble depth);

	// public static readonly glClearDepthfDelegate glClearDepthf = Marshal.GetDelegateForFunctionPointer<glClearDepthfDelegate>(GetMethodAddress("glClearDepthf"));
	// public delegate void glClearDepthfDelegate(GLfloat depth);

	// public static readonly glClearStencilDelegate glClearStencil = Marshal.GetDelegateForFunctionPointer<glClearStencilDelegate>(GetMethodAddress("glClearStencil"));
	// public delegate void glClearStencilDelegate(GLint s);

	// public static readonly glClearTexImageDelegate glClearTexImage = Marshal.GetDelegateForFunctionPointer<glClearTexImageDelegate>(GetMethodAddress("glClearTexImage"));
	// public delegate void glClearTexImageDelegate(GLuint texture, GLint level, GLenum format, GLenum type, nint data);

	// public static readonly glClearTexSubImageDelegate glClearTexSubImage = Marshal.GetDelegateForFunctionPointer<glClearTexSubImageDelegate>(GetMethodAddress("glClearTexSubImage"));
	// public delegate void glClearTexSubImageDelegate(GLuint texture, GLint level, GLint xoffset, GLint yoffset, GLint zoffset, GLsizei width, GLsizei height, GLsizei depth, GLenum format, GLenum type, nint data);

	public static readonly glClientWaitSyncDelegate glClientWaitSync = Marshal.GetDelegateForFunctionPointer<glClientWaitSyncDelegate>(GetMethodAddress("glClientWaitSync"));
	public delegate GLenum glClientWaitSyncDelegate(GLsync sync, GLbitfield flags, GLuint64 timeout);

	public static readonly glClipControlDelegate glClipControl = Marshal.GetDelegateForFunctionPointer<glClipControlDelegate>(GetMethodAddress("glClipControl"));
	public delegate void glClipControlDelegate(GLenum origin, GLenum depth);

	// public static readonly glColorMaskDelegate glColorMask = Marshal.GetDelegateForFunctionPointer<glColorMaskDelegate>(GetMethodAddress("glColorMask"));
	// public delegate void glColorMaskDelegate(GLboolean red, GLboolean green, GLboolean blue, GLboolean alpha);

	public static readonly glColorMaskiDelegate glColorMaski = Marshal.GetDelegateForFunctionPointer<glColorMaskiDelegate>(GetMethodAddress("glColorMaski"));
	public delegate void glColorMaskiDelegate(GLuint buf, GLboolean red, GLboolean green, GLboolean blue, GLboolean alpha);

	public static readonly glCompileShaderDelegate glCompileShader = Marshal.GetDelegateForFunctionPointer<glCompileShaderDelegate>(GetMethodAddress("glCompileShader"));
	public delegate void glCompileShaderDelegate(GLuint shader);

	public static readonly glCompressedTexImage1DDelegate glCompressedTexImage1D = Marshal.GetDelegateForFunctionPointer<glCompressedTexImage1DDelegate>(GetMethodAddress("glCompressedTexImage1D"));
	public delegate void glCompressedTexImage1DDelegate(GLenum target, GLint level, GLenum internalformat, GLsizei width, GLint border, GLsizei imageSize, nint data);

	public static readonly glCompressedTexImage2DDelegate glCompressedTexImage2D = Marshal.GetDelegateForFunctionPointer<glCompressedTexImage2DDelegate>(GetMethodAddress("glCompressedTexImage2D"));
	public delegate void glCompressedTexImage2DDelegate(GLenum target, GLint level, GLenum internalformat, GLsizei width, GLsizei height, GLint border, GLsizei imageSize, nint data);

	public static readonly glCompressedTexImage3DDelegate glCompressedTexImage3D = Marshal.GetDelegateForFunctionPointer<glCompressedTexImage3DDelegate>(GetMethodAddress("glCompressedTexImage3D"));
	public delegate void glCompressedTexImage3DDelegate(GLenum target, GLint level, GLenum internalformat, GLsizei width, GLsizei height, GLsizei depth, GLint border, GLsizei imageSize, nint data);

	public static readonly glCompressedTexSubImage1DDelegate glCompressedTexSubImage1D = Marshal.GetDelegateForFunctionPointer<glCompressedTexSubImage1DDelegate>(GetMethodAddress("glCompressedTexSubImage1D"));
	public delegate void glCompressedTexSubImage1DDelegate(GLenum target, GLint level, GLint xoffset, GLsizei width, GLenum format, GLsizei imageSize, nint data);

	public static readonly glCompressedTextureSubImage1DDelegate glCompressedTextureSubImage1D = Marshal.GetDelegateForFunctionPointer<glCompressedTextureSubImage1DDelegate>(GetMethodAddress("glCompressedTextureSubImage1D"));
	public delegate void glCompressedTextureSubImage1DDelegate(GLuint texture, GLint level, GLint xoffset, GLsizei width, GLenum format, GLsizei imageSize, nint data);

	public static readonly glCompressedTexSubImage2DDelegate glCompressedTexSubImage2D = Marshal.GetDelegateForFunctionPointer<glCompressedTexSubImage2DDelegate>(GetMethodAddress("glCompressedTexSubImage2D"));
	public delegate void glCompressedTexSubImage2DDelegate(GLenum target, GLint level, GLint xoffset, GLint yoffset, GLsizei width, GLsizei height, GLenum format, GLsizei imageSize, nint data);

	public static readonly glCompressedTextureSubImage2DDelegate glCompressedTextureSubImage2D = Marshal.GetDelegateForFunctionPointer<glCompressedTextureSubImage2DDelegate>(GetMethodAddress("glCompressedTextureSubImage2D"));
	public delegate void glCompressedTextureSubImage2DDelegate(GLuint texture, GLint level, GLint xoffset, GLint yoffset, GLsizei width, GLsizei height, GLenum format, GLsizei imageSize, nint data);

	public static readonly glCompressedTexSubImage3DDelegate glCompressedTexSubImage3D = Marshal.GetDelegateForFunctionPointer<glCompressedTexSubImage3DDelegate>(GetMethodAddress("glCompressedTexSubImage3D"));
	public delegate void glCompressedTexSubImage3DDelegate(GLenum target, GLint level, GLint xoffset, GLint yoffset, GLint zoffset, GLsizei width, GLsizei height, GLsizei depth, GLenum format, GLsizei imageSize, nint data);

	public static readonly glCompressedTextureSubImage3DDelegate glCompressedTextureSubImage3D = Marshal.GetDelegateForFunctionPointer<glCompressedTextureSubImage3DDelegate>(GetMethodAddress("glCompressedTextureSubImage3D"));
	public delegate void glCompressedTextureSubImage3DDelegate(GLuint texture, GLint level, GLint xoffset, GLint yoffset, GLint zoffset, GLsizei width, GLsizei height, GLsizei depth, GLenum format, GLsizei imageSize, nint data);

	public static readonly glCopyBufferSubDataDelegate glCopyBufferSubData = Marshal.GetDelegateForFunctionPointer<glCopyBufferSubDataDelegate>(GetMethodAddress("glCopyBufferSubData"));
	public delegate void glCopyBufferSubDataDelegate(GLenum readTarget, GLenum writeTarget, GLintptr readOffset, GLintptr writeOffset, GLsizeiptr size);

	public static readonly glCopyNamedBufferSubDataDelegate glCopyNamedBufferSubData = Marshal.GetDelegateForFunctionPointer<glCopyNamedBufferSubDataDelegate>(GetMethodAddress("glCopyNamedBufferSubData"));
	public delegate void glCopyNamedBufferSubDataDelegate(GLuint readBuffer, GLuint writeBuffer, GLintptr readOffset, GLintptr writeOffset, GLsizei size);

	public static readonly glCopyImageSubDataDelegate glCopyImageSubData = Marshal.GetDelegateForFunctionPointer<glCopyImageSubDataDelegate>(GetMethodAddress("glCopyImageSubData"));
	public delegate void glCopyImageSubDataDelegate(GLuint srcName, GLenum srcTarget, GLint srcLevel, GLint srcX, GLint srcY, GLint srcZ, GLuint dstName, GLenum dstTarget, GLint dstLevel, GLint dstX, GLint dstY, GLint dstZ, GLsizei srcWidth, GLsizei srcHeight, GLsizei srcDepth);

	public static readonly glCopyTexImage1DDelegate glCopyTexImage1D = Marshal.GetDelegateForFunctionPointer<glCopyTexImage1DDelegate>(GetMethodAddress("glCopyTexImage1D"));
	public delegate void glCopyTexImage1DDelegate(GLenum target, GLint level, GLenum internalformat, GLint x, GLint y, GLsizei width, GLint border);

	public static readonly glCopyTexImage2DDelegate glCopyTexImage2D = Marshal.GetDelegateForFunctionPointer<glCopyTexImage2DDelegate>(GetMethodAddress("glCopyTexImage2D"));
	public delegate void glCopyTexImage2DDelegate(GLenum target, GLint level, GLenum internalformat, GLint x, GLint y, GLsizei width, GLsizei height, GLint border);

	public static readonly glCopyTexSubImage1DDelegate glCopyTexSubImage1D = Marshal.GetDelegateForFunctionPointer<glCopyTexSubImage1DDelegate>(GetMethodAddress("glCopyTexSubImage1D"));
	public delegate void glCopyTexSubImage1DDelegate(GLenum target, GLint level, GLint xoffset, GLint x, GLint y, GLsizei width);

	public static readonly glCopyTextureSubImage1DDelegate glCopyTextureSubImage1D = Marshal.GetDelegateForFunctionPointer<glCopyTextureSubImage1DDelegate>(GetMethodAddress("glCopyTextureSubImage1D"));
	public delegate void glCopyTextureSubImage1DDelegate(GLuint texture, GLint level, GLint xoffset, GLint x, GLint y, GLsizei width);

	public static readonly glCopyTexSubImage2DDelegate glCopyTexSubImage2D = Marshal.GetDelegateForFunctionPointer<glCopyTexSubImage2DDelegate>(GetMethodAddress("glCopyTexSubImage2D"));
	public delegate void glCopyTexSubImage2DDelegate(GLenum target, GLint level, GLint xoffset, GLint yoffset, GLint x, GLint y, GLsizei width, GLsizei height);

	public static readonly glCopyTextureSubImage2DDelegate glCopyTextureSubImage2D = Marshal.GetDelegateForFunctionPointer<glCopyTextureSubImage2DDelegate>(GetMethodAddress("glCopyTextureSubImage2D"));
	public delegate void glCopyTextureSubImage2DDelegate(GLuint texture, GLint level, GLint xoffset, GLint yoffset, GLint x, GLint y, GLsizei width, GLsizei height);

	public static readonly glCopyTexSubImage3DDelegate glCopyTexSubImage3D = Marshal.GetDelegateForFunctionPointer<glCopyTexSubImage3DDelegate>(GetMethodAddress("glCopyTexSubImage3D"));
	public delegate void glCopyTexSubImage3DDelegate(GLenum target, GLint level, GLint xoffset, GLint yoffset, GLint zoffset, GLint x, GLint y, GLsizei width, GLsizei height);

	public static readonly glCopyTextureSubImage3DDelegate glCopyTextureSubImage3D = Marshal.GetDelegateForFunctionPointer<glCopyTextureSubImage3DDelegate>(GetMethodAddress("glCopyTextureSubImage3D"));
	public delegate void glCopyTextureSubImage3DDelegate(GLuint texture, GLint level, GLint xoffset, GLint yoffset, GLint zoffset, GLint x, GLint y, GLsizei width, GLsizei height);

	public static readonly glCreateBuffersDelegate glCreateBuffers = Marshal.GetDelegateForFunctionPointer<glCreateBuffersDelegate>(GetMethodAddress("glCreateBuffers"));
	public delegate void glCreateBuffersDelegate(GLsizei n, GLuint* buffers);

	public static readonly glCreateFramebuffersDelegate glCreateFramebuffers = Marshal.GetDelegateForFunctionPointer<glCreateFramebuffersDelegate>(GetMethodAddress("glCreateFramebuffers"));
	public delegate void glCreateFramebuffersDelegate(GLsizei n, GLuint* ids);

	public static readonly glCreateProgramDelegate glCreateProgram = Marshal.GetDelegateForFunctionPointer<glCreateProgramDelegate>(GetMethodAddress("glCreateProgram"));
	public delegate GLuint glCreateProgramDelegate();

	public static readonly glCreateProgramPipelinesDelegate glCreateProgramPipelines = Marshal.GetDelegateForFunctionPointer<glCreateProgramPipelinesDelegate>(GetMethodAddress("glCreateProgramPipelines"));
	public delegate void glCreateProgramPipelinesDelegate(GLsizei n, GLuint* pipelines);

	public static readonly glCreateQueriesDelegate glCreateQueries = Marshal.GetDelegateForFunctionPointer<glCreateQueriesDelegate>(GetMethodAddress("glCreateQueries"));
	public delegate void glCreateQueriesDelegate(GLenum target, GLsizei n, GLuint* ids);

	public static readonly glCreateRenderbuffersDelegate glCreateRenderbuffers = Marshal.GetDelegateForFunctionPointer<glCreateRenderbuffersDelegate>(GetMethodAddress("glCreateRenderbuffers"));
	public delegate void glCreateRenderbuffersDelegate(GLsizei n, GLuint* renderbuffers);

	public static readonly glCreateSamplersDelegate glCreateSamplers = Marshal.GetDelegateForFunctionPointer<glCreateSamplersDelegate>(GetMethodAddress("glCreateSamplers"));
	public delegate void glCreateSamplersDelegate(GLsizei n, GLuint* samplers);

	public static readonly glCreateShaderDelegate glCreateShader = Marshal.GetDelegateForFunctionPointer<glCreateShaderDelegate>(GetMethodAddress("glCreateShader"));
	public delegate GLuint glCreateShaderDelegate(GLenum shaderType);

	public static readonly glCreateShaderProgramvDelegate glCreateShaderProgramv = Marshal.GetDelegateForFunctionPointer<glCreateShaderProgramvDelegate>(GetMethodAddress("glCreateShaderProgramv"));
	public delegate GLuint glCreateShaderProgramvDelegate(GLenum type, GLsizei count, sbyte** strings);

	public static readonly glCreateTexturesDelegate glCreateTextures = Marshal.GetDelegateForFunctionPointer<glCreateTexturesDelegate>(GetMethodAddress("glCreateTextures"));
	public delegate void glCreateTexturesDelegate(GLenum target, GLsizei n, GLuint* textures);

	public static readonly glCreateTransformFeedbacksDelegate glCreateTransformFeedbacks = Marshal.GetDelegateForFunctionPointer<glCreateTransformFeedbacksDelegate>(GetMethodAddress("glCreateTransformFeedbacks"));
	public delegate void glCreateTransformFeedbacksDelegate(GLsizei n, GLuint* ids);

	public static readonly glCreateVertexArraysDelegate glCreateVertexArrays = Marshal.GetDelegateForFunctionPointer<glCreateVertexArraysDelegate>(GetMethodAddress("glCreateVertexArrays"));
	public delegate void glCreateVertexArraysDelegate(GLsizei n, GLuint* arrays);

	// public static readonly glCullFaceDelegate glCullFace = Marshal.GetDelegateForFunctionPointer<glCullFaceDelegate>(GetMethodAddress("glCullFace"));
	// public delegate void glCullFaceDelegate(GLenum mode);

	public static readonly glDebugMessageCallbackDelegate glDebugMessageCallback = Marshal.GetDelegateForFunctionPointer<glDebugMessageCallbackDelegate>(GetMethodAddress("glDebugMessageCallback"));
	public delegate void glDebugMessageCallbackDelegate(ErrorCallback callback, nint userParam);

	public static readonly glDebugMessageControlDelegate glDebugMessageControl = Marshal.GetDelegateForFunctionPointer<glDebugMessageControlDelegate>(GetMethodAddress("glDebugMessageControl"));
	public delegate void glDebugMessageControlDelegate(GLenum source, GLenum type, GLenum severity, GLsizei count, GLuint* ids, GLboolean enabled);

	public static readonly glDebugMessageInsertDelegate glDebugMessageInsert = Marshal.GetDelegateForFunctionPointer<glDebugMessageInsertDelegate>(GetMethodAddress("glDebugMessageInsert"));
	public delegate void glDebugMessageInsertDelegate(GLenum source, GLenum type, GLuint id, GLenum severity, GLsizei length, sbyte* message);

	public static readonly glDeleteBuffersDelegate glDeleteBuffers = Marshal.GetDelegateForFunctionPointer<glDeleteBuffersDelegate>(GetMethodAddress("glDeleteBuffers"));
	public delegate void glDeleteBuffersDelegate(GLsizei n, ref GLuint buffers);

	public static readonly glDeleteFramebuffersDelegate glDeleteFramebuffers = Marshal.GetDelegateForFunctionPointer<glDeleteFramebuffersDelegate>(GetMethodAddress("glDeleteFramebuffers"));
	public delegate void glDeleteFramebuffersDelegate(GLsizei n, ref GLuint framebuffers);

	public static readonly glDeleteProgramDelegate glDeleteProgram = Marshal.GetDelegateForFunctionPointer<glDeleteProgramDelegate>(GetMethodAddress("glDeleteProgram"));
	public delegate void glDeleteProgramDelegate(GLuint program);

	public static readonly glDeleteProgramPipelinesDelegate glDeleteProgramPipelines = Marshal.GetDelegateForFunctionPointer<glDeleteProgramPipelinesDelegate>(GetMethodAddress("glDeleteProgramPipelines"));
	public delegate void glDeleteProgramPipelinesDelegate(GLsizei n, GLuint* pipelines);

	public static readonly glDeleteQueriesDelegate glDeleteQueries = Marshal.GetDelegateForFunctionPointer<glDeleteQueriesDelegate>(GetMethodAddress("glDeleteQueries"));
	public delegate void glDeleteQueriesDelegate(GLsizei n, GLuint* ids);

	public static readonly glDeleteRenderbuffersDelegate glDeleteRenderbuffers = Marshal.GetDelegateForFunctionPointer<glDeleteRenderbuffersDelegate>(GetMethodAddress("glDeleteRenderbuffers"));
	public delegate void glDeleteRenderbuffersDelegate(GLsizei n, GLuint* renderbuffers);

	public static readonly glDeleteSamplersDelegate glDeleteSamplers = Marshal.GetDelegateForFunctionPointer<glDeleteSamplersDelegate>(GetMethodAddress("glDeleteSamplers"));
	public delegate void glDeleteSamplersDelegate(GLsizei n, GLuint* samplers);

	public static readonly glDeleteShaderDelegate glDeleteShader = Marshal.GetDelegateForFunctionPointer<glDeleteShaderDelegate>(GetMethodAddress("glDeleteShader"));
	public delegate void glDeleteShaderDelegate(GLuint shader);

	public static readonly glDeleteSyncDelegate glDeleteSync = Marshal.GetDelegateForFunctionPointer<glDeleteSyncDelegate>(GetMethodAddress("glDeleteSync"));
	public delegate void glDeleteSyncDelegate(GLsync sync);

	public static readonly glDeleteTexturesDelegate glDeleteTextures = Marshal.GetDelegateForFunctionPointer<glDeleteTexturesDelegate>(GetMethodAddress("glDeleteTextures"));
	public delegate void glDeleteTexturesDelegate(GLsizei n, ref GLuint textures);

	public static readonly glDeleteTransformFeedbacksDelegate glDeleteTransformFeedbacks = Marshal.GetDelegateForFunctionPointer<glDeleteTransformFeedbacksDelegate>(GetMethodAddress("glDeleteTransformFeedbacks"));
	public delegate void glDeleteTransformFeedbacksDelegate(GLsizei n, GLuint* ids);

	public static readonly glDeleteVertexArraysDelegate glDeleteVertexArrays = Marshal.GetDelegateForFunctionPointer<glDeleteVertexArraysDelegate>(GetMethodAddress("glDeleteVertexArrays"));
	public delegate void glDeleteVertexArraysDelegate(GLsizei n, GLuint* arrays);

	// public static readonly glDepthFuncDelegate glDepthFunc = Marshal.GetDelegateForFunctionPointer<glDepthFuncDelegate>(GetMethodAddress("glDepthFunc"));
	// public delegate void glDepthFuncDelegate(GLenum func);

	// public static readonly glDepthMaskDelegate glDepthMask = Marshal.GetDelegateForFunctionPointer<glDepthMaskDelegate>(GetMethodAddress("glDepthMask"));
	// public delegate void glDepthMaskDelegate(GLboolean flag);

	// public static readonly glDepthRangeDelegate glDepthRange = Marshal.GetDelegateForFunctionPointer<glDepthRangeDelegate>(GetMethodAddress("glDepthRange"));
	// public delegate void glDepthRangeDelegate(GLdouble nearVal, GLdouble farVal);

	// public static readonly glDepthRangefDelegate glDepthRangef = Marshal.GetDelegateForFunctionPointer<glDepthRangefDelegate>(GetMethodAddress("glDepthRangef"));
	// public delegate void glDepthRangefDelegate(GLfloat nearVal, GLfloat farVal);

	// public static readonly glDepthRangeArrayvDelegate glDepthRangeArrayv = Marshal.GetDelegateForFunctionPointer<glDepthRangeArrayvDelegate>(GetMethodAddress("glDepthRangeArrayv"));
	// public delegate void glDepthRangeArrayvDelegate(GLuint first, GLsizei count, GLdouble* v);

	// public static readonly glDepthRangeIndexedDelegate glDepthRangeIndexed = Marshal.GetDelegateForFunctionPointer<glDepthRangeIndexedDelegate>(GetMethodAddress("glDepthRangeIndexed"));
	// public delegate void glDepthRangeIndexedDelegate(GLuint index, GLdouble nearVal, GLdouble farVal);

	public static readonly glDetachShaderDelegate glDetachShader = Marshal.GetDelegateForFunctionPointer<glDetachShaderDelegate>(GetMethodAddress("glDetachShader"));
	public delegate void glDetachShaderDelegate(GLuint program, GLuint shader);

	public static readonly glDispatchComputeDelegate glDispatchCompute = Marshal.GetDelegateForFunctionPointer<glDispatchComputeDelegate>(GetMethodAddress("glDispatchCompute"));
	public delegate void glDispatchComputeDelegate(GLuint num_groups_x, GLuint num_groups_y, GLuint num_groups_z);

	public static readonly glDispatchComputeIndirectDelegate glDispatchComputeIndirect = Marshal.GetDelegateForFunctionPointer<glDispatchComputeIndirectDelegate>(GetMethodAddress("glDispatchComputeIndirect"));
	public delegate void glDispatchComputeIndirectDelegate(GLintptr indirect);

	public static readonly glDrawArraysDelegate glDrawArrays = Marshal.GetDelegateForFunctionPointer<glDrawArraysDelegate>(GetMethodAddress("glDrawArrays"));
	public delegate void glDrawArraysDelegate(GLenum mode, GLint first, GLsizei count);

	public static readonly glDrawArraysIndirectDelegate glDrawArraysIndirect = Marshal.GetDelegateForFunctionPointer<glDrawArraysIndirectDelegate>(GetMethodAddress("glDrawArraysIndirect"));
	public delegate void glDrawArraysIndirectDelegate(GLenum mode, nint indirect);

	public static readonly glDrawArraysInstancedDelegate glDrawArraysInstanced = Marshal.GetDelegateForFunctionPointer<glDrawArraysInstancedDelegate>(GetMethodAddress("glDrawArraysInstanced"));
	public delegate void glDrawArraysInstancedDelegate(GLenum mode, GLint first, GLsizei count, GLsizei primcount);

	public static readonly glDrawArraysInstancedBaseInstanceDelegate glDrawArraysInstancedBaseInstance = Marshal.GetDelegateForFunctionPointer<glDrawArraysInstancedBaseInstanceDelegate>(GetMethodAddress("glDrawArraysInstancedBaseInstance"));
	public delegate void glDrawArraysInstancedBaseInstanceDelegate(GLenum mode, GLint first, GLsizei count, GLsizei primcount, GLuint baseinstance);

	[DllImport(GL_LIB)] public static extern void glDrawBuffer(GLenum buf);
	// public static readonly glDrawBufferDelegate glDrawBuffer = Marshal.GetDelegateForFunctionPointer<glDrawBufferDelegate>(GetMethodAddress("glDrawBuffer"));
	// public delegate void glDrawBufferDelegate(GLenum buf);

	public static readonly glNamedFramebufferDrawBufferDelegate glNamedFramebufferDrawBuffer = Marshal.GetDelegateForFunctionPointer<glNamedFramebufferDrawBufferDelegate>(GetMethodAddress("glNamedFramebufferDrawBuffer"));
	public delegate void glNamedFramebufferDrawBufferDelegate(GLuint framebuffer, GLenum buf);

	public static readonly glDrawBuffersDelegate glDrawBuffers = Marshal.GetDelegateForFunctionPointer<glDrawBuffersDelegate>(GetMethodAddress("glDrawBuffers"));
	public delegate void glDrawBuffersDelegate(GLsizei n, ref GLenum bufs);

	public static readonly glNamedFramebufferDrawBuffersDelegate glNamedFramebufferDrawBuffers = Marshal.GetDelegateForFunctionPointer<glNamedFramebufferDrawBuffersDelegate>(GetMethodAddress("glNamedFramebufferDrawBuffers"));
	public delegate void glNamedFramebufferDrawBuffersDelegate(GLuint framebuffer, GLsizei n, GLenum* bufs);

	public static readonly glDrawElementsDelegate glDrawElements = Marshal.GetDelegateForFunctionPointer<glDrawElementsDelegate>(GetMethodAddress("glDrawElements"));
	public delegate void glDrawElementsDelegate(GLenum mode, GLsizei count, GLenum type, nint indices);

	public static readonly glDrawElementsBaseVertexDelegate glDrawElementsBaseVertex = Marshal.GetDelegateForFunctionPointer<glDrawElementsBaseVertexDelegate>(GetMethodAddress("glDrawElementsBaseVertex"));
	public delegate void glDrawElementsBaseVertexDelegate(GLenum mode, GLsizei count, GLenum type, nint indices, GLint basevertex);

	public static readonly glDrawElementsIndirectDelegate glDrawElementsIndirect = Marshal.GetDelegateForFunctionPointer<glDrawElementsIndirectDelegate>(GetMethodAddress("glDrawElementsIndirect"));
	public delegate void glDrawElementsIndirectDelegate(GLenum mode, GLenum type, nint indirect);

	public static readonly glDrawElementsInstancedDelegate glDrawElementsInstanced = Marshal.GetDelegateForFunctionPointer<glDrawElementsInstancedDelegate>(GetMethodAddress("glDrawElementsInstanced"));
	public delegate void glDrawElementsInstancedDelegate(GLenum mode, GLsizei count, GLenum type, nint indices, GLsizei primcount);

	public static readonly glDrawElementsInstancedBaseInstanceDelegate glDrawElementsInstancedBaseInstance = Marshal.GetDelegateForFunctionPointer<glDrawElementsInstancedBaseInstanceDelegate>(GetMethodAddress("glDrawElementsInstancedBaseInstance"));
	public delegate void glDrawElementsInstancedBaseInstanceDelegate(GLenum mode, GLsizei count, GLenum type, nint indices, GLsizei primcount, GLuint baseinstance);

	public static readonly glDrawElementsInstancedBaseVertexDelegate glDrawElementsInstancedBaseVertex = Marshal.GetDelegateForFunctionPointer<glDrawElementsInstancedBaseVertexDelegate>(GetMethodAddress("glDrawElementsInstancedBaseVertex"));
	public delegate void glDrawElementsInstancedBaseVertexDelegate(GLenum mode, GLsizei count, GLenum type, nint indices, GLsizei primcount, GLint basevertex);

	public static readonly glDrawElementsInstancedBaseVertexBaseInstanceDelegate glDrawElementsInstancedBaseVertexBaseInstance = Marshal.GetDelegateForFunctionPointer<glDrawElementsInstancedBaseVertexBaseInstanceDelegate>(GetMethodAddress("glDrawElementsInstancedBaseVertexBaseInstance"));
	public delegate void glDrawElementsInstancedBaseVertexBaseInstanceDelegate(GLenum mode, GLsizei count, GLenum type, nint indices, GLsizei primcount, GLint basevertex, GLuint baseinstance);

	public static readonly glDrawRangeElementsDelegate glDrawRangeElements = Marshal.GetDelegateForFunctionPointer<glDrawRangeElementsDelegate>(GetMethodAddress("glDrawRangeElements"));
	public delegate void glDrawRangeElementsDelegate(GLenum mode, GLuint start, GLuint end, GLsizei count, GLenum type, nint indices);

	public static readonly glDrawRangeElementsBaseVertexDelegate glDrawRangeElementsBaseVertex = Marshal.GetDelegateForFunctionPointer<glDrawRangeElementsBaseVertexDelegate>(GetMethodAddress("glDrawRangeElementsBaseVertex"));
	public delegate void glDrawRangeElementsBaseVertexDelegate(GLenum mode, GLuint start, GLuint end, GLsizei count, GLenum type, nint indices, GLint basevertex);

	public static readonly glDrawTransformFeedbackDelegate glDrawTransformFeedback = Marshal.GetDelegateForFunctionPointer<glDrawTransformFeedbackDelegate>(GetMethodAddress("glDrawTransformFeedback"));
	public delegate void glDrawTransformFeedbackDelegate(GLenum mode, GLuint id);

	public static readonly glDrawTransformFeedbackInstancedDelegate glDrawTransformFeedbackInstanced = Marshal.GetDelegateForFunctionPointer<glDrawTransformFeedbackInstancedDelegate>(GetMethodAddress("glDrawTransformFeedbackInstanced"));
	public delegate void glDrawTransformFeedbackInstancedDelegate(GLenum mode, GLuint id, GLsizei primcount);

	public static readonly glDrawTransformFeedbackStreamDelegate glDrawTransformFeedbackStream = Marshal.GetDelegateForFunctionPointer<glDrawTransformFeedbackStreamDelegate>(GetMethodAddress("glDrawTransformFeedbackStream"));
	public delegate void glDrawTransformFeedbackStreamDelegate(GLenum mode, GLuint id, GLuint stream);

	public static readonly glDrawTransformFeedbackStreamInstancedDelegate glDrawTransformFeedbackStreamInstanced = Marshal.GetDelegateForFunctionPointer<glDrawTransformFeedbackStreamInstancedDelegate>(GetMethodAddress("glDrawTransformFeedbackStreamInstanced"));
	public delegate void glDrawTransformFeedbackStreamInstancedDelegate(GLenum mode, GLuint id, GLuint stream, GLsizei primcount);

	[DllImport(GL_LIB)] public static extern void glEnable(GLenum cap);
	// public static readonly glEnableDelegate glEnable = Marshal.GetDelegateForFunctionPointer<glEnableDelegate>(GetMethodAddress("glEnable"));
	// public delegate void glEnableDelegate(GLenum cap);

	[DllImport(GL_LIB)] public static extern void glDisable(GLenum cap);
	// public static readonly glDisableDelegate glDisable = Marshal.GetDelegateForFunctionPointer<glDisableDelegate>(GetMethodAddress("glDisable"));
	// public delegate void glDisableDelegate(GLenum cap);

	// public static readonly glEnableiDelegate glEnablei = Marshal.GetDelegateForFunctionPointer<glEnableiDelegate>(GetMethodAddress("glEnablei"));
	// public delegate void glEnableiDelegate(GLenum cap, GLuint index);

	// public static readonly glDisableiDelegate glDisablei = Marshal.GetDelegateForFunctionPointer<glDisableiDelegate>(GetMethodAddress("glDisablei"));
	// public delegate void glDisableiDelegate(GLenum cap, GLuint index);

	public static readonly glEnableVertexAttribArrayDelegate glEnableVertexAttribArray = Marshal.GetDelegateForFunctionPointer<glEnableVertexAttribArrayDelegate>(GetMethodAddress("glEnableVertexAttribArray"));
	public delegate void glEnableVertexAttribArrayDelegate(GLuint index);

	public static readonly glDisableVertexAttribArrayDelegate glDisableVertexAttribArray = Marshal.GetDelegateForFunctionPointer<glDisableVertexAttribArrayDelegate>(GetMethodAddress("glDisableVertexAttribArray"));
	public delegate void glDisableVertexAttribArrayDelegate(GLuint index);

	public static readonly glEnableVertexArrayAttribDelegate glEnableVertexArrayAttrib = Marshal.GetDelegateForFunctionPointer<glEnableVertexArrayAttribDelegate>(GetMethodAddress("glEnableVertexArrayAttrib"));
	public delegate void glEnableVertexArrayAttribDelegate(GLuint vaobj, GLuint index);

	public static readonly glDisableVertexArrayAttribDelegate glDisableVertexArrayAttrib = Marshal.GetDelegateForFunctionPointer<glDisableVertexArrayAttribDelegate>(GetMethodAddress("glDisableVertexArrayAttrib"));
	public delegate void glDisableVertexArrayAttribDelegate(GLuint vaobj, GLuint index);

	public static readonly glFenceSyncDelegate glFenceSync = Marshal.GetDelegateForFunctionPointer<glFenceSyncDelegate>(GetMethodAddress("glFenceSync"));
	public delegate GLsync glFenceSyncDelegate(GLenum condition, GLbitfield flags);

	// public static readonly glFinishDelegate glFinish = Marshal.GetDelegateForFunctionPointer<glFinishDelegate>(GetMethodAddress("glFinish"));
	// public delegate void glFinishDelegate();

	// public static readonly glFlushDelegate glFlush = Marshal.GetDelegateForFunctionPointer<glFlushDelegate>(GetMethodAddress("glFlush"));
	// public delegate void glFlushDelegate();

	// public static readonly glFlushMappedBufferRangeDelegate glFlushMappedBufferRange = Marshal.GetDelegateForFunctionPointer<glFlushMappedBufferRangeDelegate>(GetMethodAddress("glFlushMappedBufferRange"));
	// public delegate void glFlushMappedBufferRangeDelegate(GLenum target, GLintptr offset, GLsizeiptr length);

	// public static readonly glFlushMappedNamedBufferRangeDelegate glFlushMappedNamedBufferRange = Marshal.GetDelegateForFunctionPointer<glFlushMappedNamedBufferRangeDelegate>(GetMethodAddress("glFlushMappedNamedBufferRange"));
	// public delegate void glFlushMappedNamedBufferRangeDelegate(GLuint buffer, GLintptr offset, GLsizei length);

	public static readonly glFramebufferParameteriDelegate glFramebufferParameteri = Marshal.GetDelegateForFunctionPointer<glFramebufferParameteriDelegate>(GetMethodAddress("glFramebufferParameteri"));
	public delegate void glFramebufferParameteriDelegate(GLenum target, GLenum pname, GLint parameter);

	public static readonly glNamedFramebufferParameteriDelegate glNamedFramebufferParameteri = Marshal.GetDelegateForFunctionPointer<glNamedFramebufferParameteriDelegate>(GetMethodAddress("glNamedFramebufferParameteri"));
	public delegate void glNamedFramebufferParameteriDelegate(GLuint framebuffer, GLenum pname, GLint parameter);

	public static readonly glFramebufferRenderbufferDelegate glFramebufferRenderbuffer = Marshal.GetDelegateForFunctionPointer<glFramebufferRenderbufferDelegate>(GetMethodAddress("glFramebufferRenderbuffer"));
	public delegate void glFramebufferRenderbufferDelegate(GLenum target, GLenum attachment, GLenum renderbuffertarget, GLuint renderbuffer);

	public static readonly glNamedFramebufferRenderbufferDelegate glNamedFramebufferRenderbuffer = Marshal.GetDelegateForFunctionPointer<glNamedFramebufferRenderbufferDelegate>(GetMethodAddress("glNamedFramebufferRenderbuffer"));
	public delegate void glNamedFramebufferRenderbufferDelegate(GLuint framebuffer, GLenum attachment, GLenum renderbuffertarget, GLuint renderbuffer);

	public static readonly glFramebufferTextureDelegate glFramebufferTexture = Marshal.GetDelegateForFunctionPointer<glFramebufferTextureDelegate>(GetMethodAddress("glFramebufferTexture"));
	public delegate void glFramebufferTextureDelegate(GLenum target, GLenum attachment, GLuint texture, GLint level);

	public static readonly glFramebufferTexture1DDelegate glFramebufferTexture1D = Marshal.GetDelegateForFunctionPointer<glFramebufferTexture1DDelegate>(GetMethodAddress("glFramebufferTexture1D"));
	public delegate void glFramebufferTexture1DDelegate(GLenum target, GLenum attachment, GLenum textarget, GLuint texture, GLint level);

	public static readonly glFramebufferTexture2DDelegate glFramebufferTexture2D = Marshal.GetDelegateForFunctionPointer<glFramebufferTexture2DDelegate>(GetMethodAddress("glFramebufferTexture2D"));
	public delegate void glFramebufferTexture2DDelegate(GLenum target, GLenum attachment, GLenum textarget, GLuint texture, GLint level);

	public static readonly glFramebufferTexture3DDelegate glFramebufferTexture3D = Marshal.GetDelegateForFunctionPointer<glFramebufferTexture3DDelegate>(GetMethodAddress("glFramebufferTexture3D"));
	public delegate void glFramebufferTexture3DDelegate(GLenum target, GLenum attachment, GLenum textarget, GLuint texture, GLint level, GLint layer);

	public static readonly glNamedFramebufferTextureDelegate glNamedFramebufferTexture = Marshal.GetDelegateForFunctionPointer<glNamedFramebufferTextureDelegate>(GetMethodAddress("glNamedFramebufferTexture"));
	public delegate void glNamedFramebufferTextureDelegate(GLuint framebuffer, GLenum attachment, GLuint texture, GLint level);

	public static readonly glFramebufferTextureLayerDelegate glFramebufferTextureLayer = Marshal.GetDelegateForFunctionPointer<glFramebufferTextureLayerDelegate>(GetMethodAddress("glFramebufferTextureLayer"));
	public delegate void glFramebufferTextureLayerDelegate(GLenum target, GLenum attachment, GLuint texture, GLint level, GLint layer);

	public static readonly glNamedFramebufferTextureLayerDelegate glNamedFramebufferTextureLayer = Marshal.GetDelegateForFunctionPointer<glNamedFramebufferTextureLayerDelegate>(GetMethodAddress("glNamedFramebufferTextureLayer"));
	public delegate void glNamedFramebufferTextureLayerDelegate(GLuint framebuffer, GLenum attachment, GLuint texture, GLint level, GLint layer);

	[DllImport(GL_LIB)] public static extern void glFrontFace(GLenum mode);
	// public static readonly glFrontFaceDelegate glFrontFace = Marshal.GetDelegateForFunctionPointer<glFrontFaceDelegate>(GetMethodAddress("glFrontFace"));
	// public delegate void glFrontFaceDelegate(GLenum mode);

	public static readonly glGenBuffersDelegate glGenBuffers = Marshal.GetDelegateForFunctionPointer<glGenBuffersDelegate>(GetMethodAddress("glGenBuffers"));
	public delegate void glGenBuffersDelegate(GLsizei n, ref GLuint buffers);

	public static readonly glGenerateMipmapDelegate glGenerateMipmap = Marshal.GetDelegateForFunctionPointer<glGenerateMipmapDelegate>(GetMethodAddress("glGenerateMipmap"));
	public delegate void glGenerateMipmapDelegate(GLenum target);

	public static readonly glGenerateTextureMipmapDelegate glGenerateTextureMipmap = Marshal.GetDelegateForFunctionPointer<glGenerateTextureMipmapDelegate>(GetMethodAddress("glGenerateTextureMipmap"));
	public delegate void glGenerateTextureMipmapDelegate(GLuint texture);

	public static readonly glGenFramebuffersDelegate glGenFramebuffers = Marshal.GetDelegateForFunctionPointer<glGenFramebuffersDelegate>(GetMethodAddress("glGenFramebuffers"));
	public delegate void glGenFramebuffersDelegate(GLsizei n, ref GLuint ids);

	public static readonly glGenProgramPipelinesDelegate glGenProgramPipelines = Marshal.GetDelegateForFunctionPointer<glGenProgramPipelinesDelegate>(GetMethodAddress("glGenProgramPipelines"));
	public delegate void glGenProgramPipelinesDelegate(GLsizei n, GLuint* pipelines);

	public static readonly glGenQueriesDelegate glGenQueries = Marshal.GetDelegateForFunctionPointer<glGenQueriesDelegate>(GetMethodAddress("glGenQueries"));
	public delegate void glGenQueriesDelegate(GLsizei n, GLuint* ids);

	public static readonly glGenRenderbuffersDelegate glGenRenderbuffers = Marshal.GetDelegateForFunctionPointer<glGenRenderbuffersDelegate>(GetMethodAddress("glGenRenderbuffers"));
	public delegate void glGenRenderbuffersDelegate(GLsizei n, ref GLuint renderbuffers);

	public static readonly glGenSamplersDelegate glGenSamplers = Marshal.GetDelegateForFunctionPointer<glGenSamplersDelegate>(GetMethodAddress("glGenSamplers"));
	public delegate void glGenSamplersDelegate(GLsizei n, GLuint* samplers);

	public static readonly glGenTexturesDelegate glGenTextures = Marshal.GetDelegateForFunctionPointer<glGenTexturesDelegate>(GetMethodAddress("glGenTextures"));
	public delegate void glGenTexturesDelegate(GLsizei n, ref GLuint textures);

	public static readonly glGenTransformFeedbacksDelegate glGenTransformFeedbacks = Marshal.GetDelegateForFunctionPointer<glGenTransformFeedbacksDelegate>(GetMethodAddress("glGenTransformFeedbacks"));
	public delegate void glGenTransformFeedbacksDelegate(GLsizei n, GLuint* ids);

	public static readonly glGenVertexArraysDelegate glGenVertexArrays = Marshal.GetDelegateForFunctionPointer<glGenVertexArraysDelegate>(GetMethodAddress("glGenVertexArrays"));
	public delegate void glGenVertexArraysDelegate(GLsizei n, GLuint* arrays);

	// public static readonly glGetBooleanvDelegate glGetBooleanv = Marshal.GetDelegateForFunctionPointer<glGetBooleanvDelegate>(GetMethodAddress("glGetBooleanv"));
	// public delegate void glGetBooleanvDelegate(GLenum pname, GLboolean* data);

	// public static readonly glGetDoublevDelegate glGetDoublev = Marshal.GetDelegateForFunctionPointer<glGetDoublevDelegate>(GetMethodAddress("glGetDoublev"));
	// public delegate void glGetDoublevDelegate(GLenum pname, GLdouble* data);

	// public static readonly glGetFloatvDelegate glGetFloatv = Marshal.GetDelegateForFunctionPointer<glGetFloatvDelegate>(GetMethodAddress("glGetFloatv"));
	// public delegate void glGetFloatvDelegate(GLenum pname, GLfloat* data);

	// public static readonly glGetIntegervDelegate glGetIntegerv = Marshal.GetDelegateForFunctionPointer<glGetIntegervDelegate>(GetMethodAddress("glGetIntegerv"));
	// public delegate void glGetIntegervDelegate(GLenum pname, GLint* data);

	// public static readonly glGetInteger64vDelegate glGetInteger64v = Marshal.GetDelegateForFunctionPointer<glGetInteger64vDelegate>(GetMethodAddress("glGetInteger64v"));
	// public delegate void glGetInteger64vDelegate(GLenum pname, GLint64* data);

	// public static readonly glGetBooleani_vDelegate glGetBooleani_v = Marshal.GetDelegateForFunctionPointer<glGetBooleani_vDelegate>(GetMethodAddress("glGetBooleani_v"));
	// public delegate void glGetBooleani_vDelegate(GLenum target, GLuint index, GLboolean* data);

	// public static readonly glGetIntegeri_vDelegate glGetIntegeri_v = Marshal.GetDelegateForFunctionPointer<glGetIntegeri_vDelegate>(GetMethodAddress("glGetIntegeri_v"));
	// public delegate void glGetIntegeri_vDelegate(GLenum target, GLuint index, GLint* data);

	// public static readonly glGetFloati_vDelegate glGetFloati_v = Marshal.GetDelegateForFunctionPointer<glGetFloati_vDelegate>(GetMethodAddress("glGetFloati_v"));
	// public delegate void glGetFloati_vDelegate(GLenum target, GLuint index, GLfloat* data);

	// public static readonly glGetDoublei_vDelegate glGetDoublei_v = Marshal.GetDelegateForFunctionPointer<glGetDoublei_vDelegate>(GetMethodAddress("glGetDoublei_v"));
	// public delegate void glGetDoublei_vDelegate(GLenum target, GLuint index, GLdouble* data);

	// public static readonly glGetInteger64i_vDelegate glGetInteger64i_v = Marshal.GetDelegateForFunctionPointer<glGetInteger64i_vDelegate>(GetMethodAddress("glGetInteger64i_v"));
	// public delegate void glGetInteger64i_vDelegate(GLenum target, GLuint index, GLint64* data);

	public static readonly glGetActiveAtomicCounterBufferivDelegate glGetActiveAtomicCounterBufferiv = Marshal.GetDelegateForFunctionPointer<glGetActiveAtomicCounterBufferivDelegate>(GetMethodAddress("glGetActiveAtomicCounterBufferiv"));
	public delegate void glGetActiveAtomicCounterBufferivDelegate(GLuint program, GLuint bufferIndex, GLenum pname, GLint* parameters);

	public static readonly glGetActiveAttribDelegate glGetActiveAttrib = Marshal.GetDelegateForFunctionPointer<glGetActiveAttribDelegate>(GetMethodAddress("glGetActiveAttrib"));
	public delegate void glGetActiveAttribDelegate(GLuint program, GLuint index, GLsizei bufSize, GLsizei* length, GLint* size, GLenum* type, sbyte* name);

	public static readonly glGetActiveSubroutineNameDelegate glGetActiveSubroutineName = Marshal.GetDelegateForFunctionPointer<glGetActiveSubroutineNameDelegate>(GetMethodAddress("glGetActiveSubroutineName"));
	public delegate void glGetActiveSubroutineNameDelegate(GLuint program, GLenum shadertype, GLuint index, GLsizei bufsize, GLsizei* length, sbyte* name);

	public static readonly glGetActiveSubroutineUniformivDelegate glGetActiveSubroutineUniformiv = Marshal.GetDelegateForFunctionPointer<glGetActiveSubroutineUniformivDelegate>(GetMethodAddress("glGetActiveSubroutineUniformiv"));
	public delegate void glGetActiveSubroutineUniformivDelegate(GLuint program, GLenum shadertype, GLuint index, GLenum pname, GLint* values);

	public static readonly glGetActiveSubroutineUniformNameDelegate glGetActiveSubroutineUniformName = Marshal.GetDelegateForFunctionPointer<glGetActiveSubroutineUniformNameDelegate>(GetMethodAddress("glGetActiveSubroutineUniformName"));
	public delegate void glGetActiveSubroutineUniformNameDelegate(GLuint program, GLenum shadertype, GLuint index, GLsizei bufsize, GLsizei* length, sbyte* name);

	public static readonly glGetActiveUniformDelegate glGetActiveUniform = Marshal.GetDelegateForFunctionPointer<glGetActiveUniformDelegate>(GetMethodAddress("glGetActiveUniform"));
	public delegate void glGetActiveUniformDelegate(GLuint program, GLuint index, GLsizei bufSize, GLsizei* length, GLint* size, GLenum* type, sbyte* name);

	public static readonly glGetActiveUniformBlockivDelegate glGetActiveUniformBlockiv = Marshal.GetDelegateForFunctionPointer<glGetActiveUniformBlockivDelegate>(GetMethodAddress("glGetActiveUniformBlockiv"));
	public delegate void glGetActiveUniformBlockivDelegate(GLuint program, GLuint uniformBlockIndex, GLenum pname, GLint* parameters);

	public static readonly glGetActiveUniformBlockNameDelegate glGetActiveUniformBlockName = Marshal.GetDelegateForFunctionPointer<glGetActiveUniformBlockNameDelegate>(GetMethodAddress("glGetActiveUniformBlockName"));
	public delegate void glGetActiveUniformBlockNameDelegate(GLuint program, GLuint uniformBlockIndex, GLsizei bufSize, GLsizei* length, sbyte* uniformBlockName);

	public static readonly glGetActiveUniformNameDelegate glGetActiveUniformName = Marshal.GetDelegateForFunctionPointer<glGetActiveUniformNameDelegate>(GetMethodAddress("glGetActiveUniformName"));
	public delegate void glGetActiveUniformNameDelegate(GLuint program, GLuint uniformIndex, GLsizei bufSize, GLsizei* length, sbyte* uniformName);

	public static readonly glGetActiveUniformsivDelegate glGetActiveUniformsiv = Marshal.GetDelegateForFunctionPointer<glGetActiveUniformsivDelegate>(GetMethodAddress("glGetActiveUniformsiv"));
	public delegate void glGetActiveUniformsivDelegate(GLuint program, GLsizei uniformCount, GLuint* uniformIndices, GLenum pname, GLint* parameters);

	public static readonly glGetAttachedShadersDelegate glGetAttachedShaders = Marshal.GetDelegateForFunctionPointer<glGetAttachedShadersDelegate>(GetMethodAddress("glGetAttachedShaders"));
	public delegate void glGetAttachedShadersDelegate(GLuint program, GLsizei maxCount, GLsizei* count, GLuint* shaders);

	public static readonly glGetAttribLocationDelegate glGetAttribLocation = Marshal.GetDelegateForFunctionPointer<glGetAttribLocationDelegate>(GetMethodAddress("glGetAttribLocation"));
	public delegate GLint glGetAttribLocationDelegate(GLuint program, sbyte* name);

	public static readonly glGetBufferParameterivDelegate glGetBufferParameteriv = Marshal.GetDelegateForFunctionPointer<glGetBufferParameterivDelegate>(GetMethodAddress("glGetBufferParameteriv"));
	public delegate void glGetBufferParameterivDelegate(GLenum target, GLenum value, GLint* data);

	public static readonly glGetBufferParameteri64vDelegate glGetBufferParameteri64v = Marshal.GetDelegateForFunctionPointer<glGetBufferParameteri64vDelegate>(GetMethodAddress("glGetBufferParameteri64v"));
	public delegate void glGetBufferParameteri64vDelegate(GLenum target, GLenum value, GLint64* data);

	public static readonly glGetNamedBufferParameterivDelegate glGetNamedBufferParameteriv = Marshal.GetDelegateForFunctionPointer<glGetNamedBufferParameterivDelegate>(GetMethodAddress("glGetNamedBufferParameteriv"));
	public delegate void glGetNamedBufferParameterivDelegate(GLuint buffer, GLenum pname, GLint* parameters);

	public static readonly glGetNamedBufferParameteri64vDelegate glGetNamedBufferParameteri64v = Marshal.GetDelegateForFunctionPointer<glGetNamedBufferParameteri64vDelegate>(GetMethodAddress("glGetNamedBufferParameteri64v"));
	public delegate void glGetNamedBufferParameteri64vDelegate(GLuint buffer, GLenum pname, GLint64* parameters);

	public static readonly glGetBufferPointervDelegate glGetBufferPointerv = Marshal.GetDelegateForFunctionPointer<glGetBufferPointervDelegate>(GetMethodAddress("glGetBufferPointerv"));
	public delegate void glGetBufferPointervDelegate(GLenum target, GLenum pname, nint* parameters);

	public static readonly glGetNamedBufferPointervDelegate glGetNamedBufferPointerv = Marshal.GetDelegateForFunctionPointer<glGetNamedBufferPointervDelegate>(GetMethodAddress("glGetNamedBufferPointerv"));
	public delegate void glGetNamedBufferPointervDelegate(GLuint buffer, GLenum pname, nint* parameters);

	public static readonly glGetBufferSubDataDelegate glGetBufferSubData = Marshal.GetDelegateForFunctionPointer<glGetBufferSubDataDelegate>(GetMethodAddress("glGetBufferSubData"));
	public delegate void glGetBufferSubDataDelegate(GLenum target, GLintptr offset, GLsizeiptr size, nint data);

	public static readonly glGetNamedBufferSubDataDelegate glGetNamedBufferSubData = Marshal.GetDelegateForFunctionPointer<glGetNamedBufferSubDataDelegate>(GetMethodAddress("glGetNamedBufferSubData"));
	public delegate void glGetNamedBufferSubDataDelegate(GLuint buffer, GLintptr offset, GLsizei size, nint data);

	public static readonly glGetCompressedTexImageDelegate glGetCompressedTexImage = Marshal.GetDelegateForFunctionPointer<glGetCompressedTexImageDelegate>(GetMethodAddress("glGetCompressedTexImage"));
	public delegate void glGetCompressedTexImageDelegate(GLenum target, GLint level, nint pixels);

	public static readonly glGetnCompressedTexImageDelegate glGetnCompressedTexImage = Marshal.GetDelegateForFunctionPointer<glGetnCompressedTexImageDelegate>(GetMethodAddress("glGetnCompressedTexImage"));
	public delegate void glGetnCompressedTexImageDelegate(GLenum target, GLint level, GLsizei bufSize, nint pixels);

	public static readonly glGetCompressedTextureImageDelegate glGetCompressedTextureImage = Marshal.GetDelegateForFunctionPointer<glGetCompressedTextureImageDelegate>(GetMethodAddress("glGetCompressedTextureImage"));
	public delegate void glGetCompressedTextureImageDelegate(GLuint texture, GLint level, GLsizei bufSize, nint pixels);

	public static readonly glGetCompressedTextureSubImageDelegate glGetCompressedTextureSubImage = Marshal.GetDelegateForFunctionPointer<glGetCompressedTextureSubImageDelegate>(GetMethodAddress("glGetCompressedTextureSubImage"));
	public delegate void glGetCompressedTextureSubImageDelegate(GLuint texture, GLint level, GLint xoffset, GLint yoffset, GLint zoffset, GLsizei width, GLsizei height, GLsizei depth, GLsizei bufSize, nint pixels);

	public static readonly glGetDebugMessageLogDelegate glGetDebugMessageLog = Marshal.GetDelegateForFunctionPointer<glGetDebugMessageLogDelegate>(GetMethodAddress("glGetDebugMessageLog"));
	public delegate GLuint glGetDebugMessageLogDelegate(GLuint count, GLsizei bufSize, GLenum* sources, GLenum* types, GLuint* ids, GLenum* severities, GLsizei* lengths, sbyte* messageLog);

	[DllImport(GL_LIB)] public static extern GLenum glGetError();
	// public static readonly glGetErrorDelegate glGetError = Marshal.GetDelegateForFunctionPointer<glGetErrorDelegate>(GetMethodAddress("glGetError"));
	// public delegate GLenum glGetErrorDelegate();

	public static readonly glGetFragDataIndexDelegate glGetFragDataIndex = Marshal.GetDelegateForFunctionPointer<glGetFragDataIndexDelegate>(GetMethodAddress("glGetFragDataIndex"));
	public delegate GLint glGetFragDataIndexDelegate(GLuint program, sbyte* name);

	public static readonly glGetFragDataLocationDelegate glGetFragDataLocation = Marshal.GetDelegateForFunctionPointer<glGetFragDataLocationDelegate>(GetMethodAddress("glGetFragDataLocation"));
	public delegate GLint glGetFragDataLocationDelegate(GLuint program, sbyte* name);

	public static readonly glGetFramebufferAttachmentParameterivDelegate glGetFramebufferAttachmentParameteriv = Marshal.GetDelegateForFunctionPointer<glGetFramebufferAttachmentParameterivDelegate>(GetMethodAddress("glGetFramebufferAttachmentParameteriv"));
	public delegate void glGetFramebufferAttachmentParameterivDelegate(GLenum target, GLenum attachment, GLenum pname, GLint* parameters);

	public static readonly glGetNamedFramebufferAttachmentParameterivDelegate glGetNamedFramebufferAttachmentParameteriv = Marshal.GetDelegateForFunctionPointer<glGetNamedFramebufferAttachmentParameterivDelegate>(GetMethodAddress("glGetNamedFramebufferAttachmentParameteriv"));
	public delegate void glGetNamedFramebufferAttachmentParameterivDelegate(GLuint framebuffer, GLenum attachment, GLenum pname, GLint* parameters);

	public static readonly glGetFramebufferParameterivDelegate glGetFramebufferParameteriv = Marshal.GetDelegateForFunctionPointer<glGetFramebufferParameterivDelegate>(GetMethodAddress("glGetFramebufferParameteriv"));
	public delegate void glGetFramebufferParameterivDelegate(GLenum target, GLenum pname, GLint* parameters);

	public static readonly glGetNamedFramebufferParameterivDelegate glGetNamedFramebufferParameteriv = Marshal.GetDelegateForFunctionPointer<glGetNamedFramebufferParameterivDelegate>(GetMethodAddress("glGetNamedFramebufferParameteriv"));
	public delegate void glGetNamedFramebufferParameterivDelegate(GLuint framebuffer, GLenum pname, GLint* parameter);

	public static readonly glGetGraphicsResetStatusDelegate glGetGraphicsResetStatus = Marshal.GetDelegateForFunctionPointer<glGetGraphicsResetStatusDelegate>(GetMethodAddress("glGetGraphicsResetStatus"));
	public delegate GLenum glGetGraphicsResetStatusDelegate();

	public static readonly glGetInternalformativDelegate glGetInternalformativ = Marshal.GetDelegateForFunctionPointer<glGetInternalformativDelegate>(GetMethodAddress("glGetInternalformativ"));
	public delegate void glGetInternalformativDelegate(GLenum target, GLenum internalformat, GLenum pname, GLsizei bufSize, GLint* parameters);

	public static readonly glGetInternalformati64vDelegate glGetInternalformati64v = Marshal.GetDelegateForFunctionPointer<glGetInternalformati64vDelegate>(GetMethodAddress("glGetInternalformati64v"));
	public delegate void glGetInternalformati64vDelegate(GLenum target, GLenum internalformat, GLenum pname, GLsizei bufSize, GLint64* parameters);

	public static readonly glGetMultisamplefvDelegate glGetMultisamplefv = Marshal.GetDelegateForFunctionPointer<glGetMultisamplefvDelegate>(GetMethodAddress("glGetMultisamplefv"));
	public delegate void glGetMultisamplefvDelegate(GLenum pname, GLuint index, GLfloat* val);

	public static readonly glGetObjectLabelDelegate glGetObjectLabel = Marshal.GetDelegateForFunctionPointer<glGetObjectLabelDelegate>(GetMethodAddress("glGetObjectLabel"));
	public delegate void glGetObjectLabelDelegate(GLenum identifier, GLuint name, GLsizei bifSize, GLsizei* length, sbyte* label);

	public static readonly glGetObjectPtrLabelDelegate glGetObjectPtrLabel = Marshal.GetDelegateForFunctionPointer<glGetObjectPtrLabelDelegate>(GetMethodAddress("glGetObjectPtrLabel"));
	public delegate void glGetObjectPtrLabelDelegate(nint ptr, GLsizei bifSize, GLsizei* length, sbyte* label);

	public static readonly glGetPointervDelegate glGetPointerv = Marshal.GetDelegateForFunctionPointer<glGetPointervDelegate>(GetMethodAddress("glGetPointerv"));
	public delegate void glGetPointervDelegate(GLenum pname, nint* parameters);

	public static readonly glGetProgramivDelegate glGetProgramiv = Marshal.GetDelegateForFunctionPointer<glGetProgramivDelegate>(GetMethodAddress("glGetProgramiv"));
	public delegate void glGetProgramivDelegate(GLuint program, GLenum pname, GLint* parameters);

	public static readonly glGetProgramBinaryDelegate glGetProgramBinary = Marshal.GetDelegateForFunctionPointer<glGetProgramBinaryDelegate>(GetMethodAddress("glGetProgramBinary"));
	public delegate void glGetProgramBinaryDelegate(GLuint program, GLsizei bufsize, GLsizei* length, GLenum* binaryFormat, nint binary);

	public static readonly glGetProgramInfoLogDelegate glGetProgramInfoLog = Marshal.GetDelegateForFunctionPointer<glGetProgramInfoLogDelegate>(GetMethodAddress("glGetProgramInfoLog"));
	public delegate void glGetProgramInfoLogDelegate(GLuint program, GLsizei maxLength, GLsizei* length, sbyte* infoLog);

	public static readonly glGetProgramInterfaceivDelegate glGetProgramInterfaceiv = Marshal.GetDelegateForFunctionPointer<glGetProgramInterfaceivDelegate>(GetMethodAddress("glGetProgramInterfaceiv"));
	public delegate void glGetProgramInterfaceivDelegate(GLuint program, GLenum programInterface, GLenum pname, GLint* parameters);

	public static readonly glGetProgramPipelineivDelegate glGetProgramPipelineiv = Marshal.GetDelegateForFunctionPointer<glGetProgramPipelineivDelegate>(GetMethodAddress("glGetProgramPipelineiv"));
	public delegate void glGetProgramPipelineivDelegate(GLuint pipeline, GLenum pname, GLint* parameters);

	public static readonly glGetProgramPipelineInfoLogDelegate glGetProgramPipelineInfoLog = Marshal.GetDelegateForFunctionPointer<glGetProgramPipelineInfoLogDelegate>(GetMethodAddress("glGetProgramPipelineInfoLog"));
	public delegate void glGetProgramPipelineInfoLogDelegate(GLuint pipeline, GLsizei bufSize, GLsizei* length, sbyte* infoLog);

	public static readonly glGetProgramResourceivDelegate glGetProgramResourceiv = Marshal.GetDelegateForFunctionPointer<glGetProgramResourceivDelegate>(GetMethodAddress("glGetProgramResourceiv"));
	public delegate void glGetProgramResourceivDelegate(GLuint program, GLenum programInterface, GLuint index, GLsizei propCount, GLenum* props, GLsizei bufSize, GLsizei* length, GLint* parameters);

	public static readonly glGetProgramResourceIndexDelegate glGetProgramResourceIndex = Marshal.GetDelegateForFunctionPointer<glGetProgramResourceIndexDelegate>(GetMethodAddress("glGetProgramResourceIndex"));
	public delegate GLuint glGetProgramResourceIndexDelegate(GLuint program, GLenum programInterface, sbyte* name);

	public static readonly glGetProgramResourceLocationDelegate glGetProgramResourceLocation = Marshal.GetDelegateForFunctionPointer<glGetProgramResourceLocationDelegate>(GetMethodAddress("glGetProgramResourceLocation"));
	public delegate GLint glGetProgramResourceLocationDelegate(GLuint program, GLenum programInterface, sbyte* name);

	public static readonly glGetProgramResourceLocationIndexDelegate glGetProgramResourceLocationIndex = Marshal.GetDelegateForFunctionPointer<glGetProgramResourceLocationIndexDelegate>(GetMethodAddress("glGetProgramResourceLocationIndex"));
	public delegate GLint glGetProgramResourceLocationIndexDelegate(GLuint program, GLenum programInterface, sbyte* name);

	public static readonly glGetProgramResourceNameDelegate glGetProgramResourceName = Marshal.GetDelegateForFunctionPointer<glGetProgramResourceNameDelegate>(GetMethodAddress("glGetProgramResourceName"));
	public delegate void glGetProgramResourceNameDelegate(GLuint program, GLenum programInterface, GLuint index, GLsizei bufSize, GLsizei* length, sbyte* name);

	public static readonly glGetProgramStageivDelegate glGetProgramStageiv = Marshal.GetDelegateForFunctionPointer<glGetProgramStageivDelegate>(GetMethodAddress("glGetProgramStageiv"));
	public delegate void glGetProgramStageivDelegate(GLuint program, GLenum shadertype, GLenum pname, GLint* values);

	public static readonly glGetQueryIndexedivDelegate glGetQueryIndexediv = Marshal.GetDelegateForFunctionPointer<glGetQueryIndexedivDelegate>(GetMethodAddress("glGetQueryIndexediv"));
	public delegate void glGetQueryIndexedivDelegate(GLenum target, GLuint index, GLenum pname, GLint* parameters);

	public static readonly glGetQueryivDelegate glGetQueryiv = Marshal.GetDelegateForFunctionPointer<glGetQueryivDelegate>(GetMethodAddress("glGetQueryiv"));
	public delegate void glGetQueryivDelegate(GLenum target, GLenum pname, GLint* parameters);

	public static readonly glGetQueryObjectivDelegate glGetQueryObjectiv = Marshal.GetDelegateForFunctionPointer<glGetQueryObjectivDelegate>(GetMethodAddress("glGetQueryObjectiv"));
	public delegate void glGetQueryObjectivDelegate(GLuint id, GLenum pname, GLint* parameters);

	public static readonly glGetQueryObjectuivDelegate glGetQueryObjectuiv = Marshal.GetDelegateForFunctionPointer<glGetQueryObjectuivDelegate>(GetMethodAddress("glGetQueryObjectuiv"));
	public delegate void glGetQueryObjectuivDelegate(GLuint id, GLenum pname, GLuint* parameters);

	public static readonly glGetQueryObjecti64vDelegate glGetQueryObjecti64v = Marshal.GetDelegateForFunctionPointer<glGetQueryObjecti64vDelegate>(GetMethodAddress("glGetQueryObjecti64v"));
	public delegate void glGetQueryObjecti64vDelegate(GLuint id, GLenum pname, GLint64* parameters);

	public static readonly glGetQueryObjectui64vDelegate glGetQueryObjectui64v = Marshal.GetDelegateForFunctionPointer<glGetQueryObjectui64vDelegate>(GetMethodAddress("glGetQueryObjectui64v"));
	public delegate void glGetQueryObjectui64vDelegate(GLuint id, GLenum pname, GLuint64* parameters);

	public static readonly glGetRenderbufferParameterivDelegate glGetRenderbufferParameteriv = Marshal.GetDelegateForFunctionPointer<glGetRenderbufferParameterivDelegate>(GetMethodAddress("glGetRenderbufferParameteriv"));
	public delegate void glGetRenderbufferParameterivDelegate(GLenum target, GLenum pname, GLint* parameters);

	public static readonly glGetNamedRenderbufferParameterivDelegate glGetNamedRenderbufferParameteriv = Marshal.GetDelegateForFunctionPointer<glGetNamedRenderbufferParameterivDelegate>(GetMethodAddress("glGetNamedRenderbufferParameteriv"));
	public delegate void glGetNamedRenderbufferParameterivDelegate(GLuint renderbuffer, GLenum pname, GLint* parameters);

	public static readonly glGetSamplerParameterfvDelegate glGetSamplerParameterfv = Marshal.GetDelegateForFunctionPointer<glGetSamplerParameterfvDelegate>(GetMethodAddress("glGetSamplerParameterfv"));
	public delegate void glGetSamplerParameterfvDelegate(GLuint sampler, GLenum pname, GLfloat* parameters);

	public static readonly glGetSamplerParameterivDelegate glGetSamplerParameteriv = Marshal.GetDelegateForFunctionPointer<glGetSamplerParameterivDelegate>(GetMethodAddress("glGetSamplerParameteriv"));
	public delegate void glGetSamplerParameterivDelegate(GLuint sampler, GLenum pname, GLint* parameters);

	public static readonly glGetSamplerParameterIivDelegate glGetSamplerParameterIiv = Marshal.GetDelegateForFunctionPointer<glGetSamplerParameterIivDelegate>(GetMethodAddress("glGetSamplerParameterIiv"));
	public delegate void glGetSamplerParameterIivDelegate(GLuint sampler, GLenum pname, GLint* parameters);

	public static readonly glGetSamplerParameterIuivDelegate glGetSamplerParameterIuiv = Marshal.GetDelegateForFunctionPointer<glGetSamplerParameterIuivDelegate>(GetMethodAddress("glGetSamplerParameterIuiv"));
	public delegate void glGetSamplerParameterIuivDelegate(GLuint sampler, GLenum pname, GLuint* parameters);

	public static readonly glGetShaderivDelegate glGetShaderiv = Marshal.GetDelegateForFunctionPointer<glGetShaderivDelegate>(GetMethodAddress("glGetShaderiv"));
	public delegate void glGetShaderivDelegate(GLuint shader, GLenum pname, out GLint parameters);

	public static readonly glGetShaderInfoLogDelegate glGetShaderInfoLog = Marshal.GetDelegateForFunctionPointer<glGetShaderInfoLogDelegate>(GetMethodAddress("glGetShaderInfoLog"));
	public delegate void glGetShaderInfoLogDelegate(GLuint shader, GLsizei maxLength, out GLsizei length, ref sbyte infoLog);

	public static readonly glGetShaderPrecisionFormatDelegate glGetShaderPrecisionFormat = Marshal.GetDelegateForFunctionPointer<glGetShaderPrecisionFormatDelegate>(GetMethodAddress("glGetShaderPrecisionFormat"));
	public delegate void glGetShaderPrecisionFormatDelegate(GLenum shaderType, GLenum precisionType, GLint* range, GLint* precision);

	public static readonly glGetShaderSourceDelegate glGetShaderSource = Marshal.GetDelegateForFunctionPointer<glGetShaderSourceDelegate>(GetMethodAddress("glGetShaderSource"));
	public delegate void glGetShaderSourceDelegate(GLuint shader, GLsizei bufSize, GLsizei* length, sbyte* source);

	// public static readonly glGetStringDelegate glGetString = Marshal.GetDelegateForFunctionPointer<glGetStringDelegate>(GetMethodAddress("glGetString"));
	// public delegate nint glGetStringDelegate(GLenum name);

	// public static readonly glGetStringiDelegate glGetStringi = Marshal.GetDelegateForFunctionPointer<glGetStringiDelegate>(GetMethodAddress("glGetStringi"));
	// public delegate nint glGetStringiDelegate(GLenum name, GLuint index);

	public static readonly glGetSubroutineIndexDelegate glGetSubroutineIndex = Marshal.GetDelegateForFunctionPointer<glGetSubroutineIndexDelegate>(GetMethodAddress("glGetSubroutineIndex"));
	public delegate GLuint glGetSubroutineIndexDelegate(GLuint program, GLenum shadertype, sbyte* name);

	public static readonly glGetSubroutineUniformLocationDelegate glGetSubroutineUniformLocation = Marshal.GetDelegateForFunctionPointer<glGetSubroutineUniformLocationDelegate>(GetMethodAddress("glGetSubroutineUniformLocation"));
	public delegate GLint glGetSubroutineUniformLocationDelegate(GLuint program, GLenum shadertype, sbyte* name);

	public static readonly glGetSyncivDelegate glGetSynciv = Marshal.GetDelegateForFunctionPointer<glGetSyncivDelegate>(GetMethodAddress("glGetSynciv"));
	public delegate void glGetSyncivDelegate(GLsync sync, GLenum pname, GLsizei bufSize, GLsizei* length, GLint* values);

	// public static readonly glGetTexImageDelegate glGetTexImage = Marshal.GetDelegateForFunctionPointer<glGetTexImageDelegate>(GetMethodAddress("glGetTexImage"));
	// public delegate void glGetTexImageDelegate(GLenum target, GLint level, GLenum format, GLenum type, nint pixels);

	public static readonly glGetnTexImageDelegate glGetnTexImage = Marshal.GetDelegateForFunctionPointer<glGetnTexImageDelegate>(GetMethodAddress("glGetnTexImage"));
	public delegate void glGetnTexImageDelegate(GLenum target, GLint level, GLenum format, GLenum type, GLsizei bufSize, nint pixels);

	public static readonly glGetTextureImageDelegate glGetTextureImage = Marshal.GetDelegateForFunctionPointer<glGetTextureImageDelegate>(GetMethodAddress("glGetTextureImage"));
	public delegate void glGetTextureImageDelegate(GLuint texture, GLint level, GLenum format, GLenum type, GLsizei bufSize, nint pixels);

	// public static readonly glGetTexLevelParameterfvDelegate glGetTexLevelParameterfv = Marshal.GetDelegateForFunctionPointer<glGetTexLevelParameterfvDelegate>(GetMethodAddress("glGetTexLevelParameterfv"));
	// public delegate void glGetTexLevelParameterfvDelegate(GLenum target, GLint level, GLenum pname, GLfloat* parameters);

	// public static readonly glGetTexLevelParameterivDelegate glGetTexLevelParameteriv = Marshal.GetDelegateForFunctionPointer<glGetTexLevelParameterivDelegate>(GetMethodAddress("glGetTexLevelParameteriv"));
	// public delegate void glGetTexLevelParameterivDelegate(GLenum target, GLint level, GLenum pname, GLint* parameters);

	public static readonly glGetTextureLevelParameterfvDelegate glGetTextureLevelParameterfv = Marshal.GetDelegateForFunctionPointer<glGetTextureLevelParameterfvDelegate>(GetMethodAddress("glGetTextureLevelParameterfv"));
	public delegate void glGetTextureLevelParameterfvDelegate(GLuint texture, GLint level, GLenum pname, GLfloat* parameters);

	public static readonly glGetTextureLevelParameterivDelegate glGetTextureLevelParameteriv = Marshal.GetDelegateForFunctionPointer<glGetTextureLevelParameterivDelegate>(GetMethodAddress("glGetTextureLevelParameteriv"));
	public delegate void glGetTextureLevelParameterivDelegate(GLuint texture, GLint level, GLenum pname, GLint* parameters);

	// public static readonly glGetTexParameterfvDelegate glGetTexParameterfv = Marshal.GetDelegateForFunctionPointer<glGetTexParameterfvDelegate>(GetMethodAddress("glGetTexParameterfv"));
	// public delegate void glGetTexParameterfvDelegate(GLenum target, GLenum pname, GLfloat* parameters);

	// public static readonly glGetTexParameterivDelegate glGetTexParameteriv = Marshal.GetDelegateForFunctionPointer<glGetTexParameterivDelegate>(GetMethodAddress("glGetTexParameteriv"));
	// public delegate void glGetTexParameterivDelegate(GLenum target, GLenum pname, GLint* parameters);

	// public static readonly glGetTexParameterIivDelegate glGetTexParameterIiv = Marshal.GetDelegateForFunctionPointer<glGetTexParameterIivDelegate>(GetMethodAddress("glGetTexParameterIiv"));
	// public delegate void glGetTexParameterIivDelegate(GLenum target, GLenum pname, GLint* parameters);

	// public static readonly glGetTexParameterIuivDelegate glGetTexParameterIuiv = Marshal.GetDelegateForFunctionPointer<glGetTexParameterIuivDelegate>(GetMethodAddress("glGetTexParameterIuiv"));
	// public delegate void glGetTexParameterIuivDelegate(GLenum target, GLenum pname, GLuint* parameters);

	public static readonly glGetTextureParameterfvDelegate glGetTextureParameterfv = Marshal.GetDelegateForFunctionPointer<glGetTextureParameterfvDelegate>(GetMethodAddress("glGetTextureParameterfv"));
	public delegate void glGetTextureParameterfvDelegate(GLuint texture, GLenum pname, GLfloat* parameters);

	public static readonly glGetTextureParameterivDelegate glGetTextureParameteriv = Marshal.GetDelegateForFunctionPointer<glGetTextureParameterivDelegate>(GetMethodAddress("glGetTextureParameteriv"));
	public delegate void glGetTextureParameterivDelegate(GLuint texture, GLenum pname, GLint* parameters);

	public static readonly glGetTextureParameterIivDelegate glGetTextureParameterIiv = Marshal.GetDelegateForFunctionPointer<glGetTextureParameterIivDelegate>(GetMethodAddress("glGetTextureParameterIiv"));
	public delegate void glGetTextureParameterIivDelegate(GLuint texture, GLenum pname, GLint* parameters);

	public static readonly glGetTextureParameterIuivDelegate glGetTextureParameterIuiv = Marshal.GetDelegateForFunctionPointer<glGetTextureParameterIuivDelegate>(GetMethodAddress("glGetTextureParameterIuiv"));
	public delegate void glGetTextureParameterIuivDelegate(GLuint texture, GLenum pname, GLuint* parameters);

	public static readonly glGetTextureSubImageDelegate glGetTextureSubImage = Marshal.GetDelegateForFunctionPointer<glGetTextureSubImageDelegate>(GetMethodAddress("glGetTextureSubImage"));
	public delegate void glGetTextureSubImageDelegate(GLuint texture, GLint level, GLint xoffset, GLint yoffset, GLint zoffset, GLsizei width, GLsizei height, GLsizei depth, GLenum format, GLenum type, GLsizei bufSize, nint pixels);

	public static readonly glGetTransformFeedbackivDelegate glGetTransformFeedbackiv = Marshal.GetDelegateForFunctionPointer<glGetTransformFeedbackivDelegate>(GetMethodAddress("glGetTransformFeedbackiv"));
	public delegate void glGetTransformFeedbackivDelegate(GLuint xfb, GLenum pname, GLint* parameter);

	public static readonly glGetTransformFeedbacki_vDelegate glGetTransformFeedbacki_v = Marshal.GetDelegateForFunctionPointer<glGetTransformFeedbacki_vDelegate>(GetMethodAddress("glGetTransformFeedbacki_v"));
	public delegate void glGetTransformFeedbacki_vDelegate(GLuint xfb, GLenum pname, GLuint index, GLint* parameter);

	public static readonly glGetTransformFeedbacki64_vDelegate glGetTransformFeedbacki64_v = Marshal.GetDelegateForFunctionPointer<glGetTransformFeedbacki64_vDelegate>(GetMethodAddress("glGetTransformFeedbacki64_v"));
	public delegate void glGetTransformFeedbacki64_vDelegate(GLuint xfb, GLenum pname, GLuint index, GLint64* parameter);

	public static readonly glGetTransformFeedbackVaryingDelegate glGetTransformFeedbackVarying = Marshal.GetDelegateForFunctionPointer<glGetTransformFeedbackVaryingDelegate>(GetMethodAddress("glGetTransformFeedbackVarying"));
	public delegate void glGetTransformFeedbackVaryingDelegate(GLuint program, GLuint index, GLsizei bufSize, GLsizei* length, GLsizei* size, GLenum* type, sbyte* name);

	public static readonly glGetUniformfvDelegate glGetUniformfv = Marshal.GetDelegateForFunctionPointer<glGetUniformfvDelegate>(GetMethodAddress("glGetUniformfv"));
	public delegate void glGetUniformfvDelegate(GLuint program, GLint location, GLfloat* parameters);

	public static readonly glGetUniformivDelegate glGetUniformiv = Marshal.GetDelegateForFunctionPointer<glGetUniformivDelegate>(GetMethodAddress("glGetUniformiv"));
	public delegate void glGetUniformivDelegate(GLuint program, GLint location, GLint* parameters);

	public static readonly glGetUniformuivDelegate glGetUniformuiv = Marshal.GetDelegateForFunctionPointer<glGetUniformuivDelegate>(GetMethodAddress("glGetUniformuiv"));
	public delegate void glGetUniformuivDelegate(GLuint program, GLint location, GLuint* parameters);

	public static readonly glGetUniformdvDelegate glGetUniformdv = Marshal.GetDelegateForFunctionPointer<glGetUniformdvDelegate>(GetMethodAddress("glGetUniformdv"));
	public delegate void glGetUniformdvDelegate(GLuint program, GLint location, GLdouble* parameters);

	public static readonly glGetnUniformfvDelegate glGetnUniformfv = Marshal.GetDelegateForFunctionPointer<glGetnUniformfvDelegate>(GetMethodAddress("glGetnUniformfv"));
	public delegate void glGetnUniformfvDelegate(GLuint program, GLint location, GLsizei bufSize, GLfloat* parameters);

	public static readonly glGetnUniformivDelegate glGetnUniformiv = Marshal.GetDelegateForFunctionPointer<glGetnUniformivDelegate>(GetMethodAddress("glGetnUniformiv"));
	public delegate void glGetnUniformivDelegate(GLuint program, GLint location, GLsizei bufSize, GLint* parameters);

	public static readonly glGetnUniformuivDelegate glGetnUniformuiv = Marshal.GetDelegateForFunctionPointer<glGetnUniformuivDelegate>(GetMethodAddress("glGetnUniformuiv"));
	public delegate void glGetnUniformuivDelegate(GLuint program, GLint location, GLsizei bufSize, GLuint* parameters);

	public static readonly glGetnUniformdvDelegate glGetnUniformdv = Marshal.GetDelegateForFunctionPointer<glGetnUniformdvDelegate>(GetMethodAddress("glGetnUniformdv"));
	public delegate void glGetnUniformdvDelegate(GLuint program, GLint location, GLsizei bufSize, GLdouble* parameters);

	public static readonly glGetUniformBlockIndexDelegate glGetUniformBlockIndex = Marshal.GetDelegateForFunctionPointer<glGetUniformBlockIndexDelegate>(GetMethodAddress("glGetUniformBlockIndex"));
	public delegate GLuint glGetUniformBlockIndexDelegate(GLuint program, sbyte* uniformBlockName);

	public static readonly glGetUniformIndicesDelegate glGetUniformIndices = Marshal.GetDelegateForFunctionPointer<glGetUniformIndicesDelegate>(GetMethodAddress("glGetUniformIndices"));
	public delegate void glGetUniformIndicesDelegate(GLuint program, GLsizei uniformCount, sbyte** uniformNames, GLuint* uniformIndices);

	public static readonly glGetUniformLocationDelegate glGetUniformLocation = Marshal.GetDelegateForFunctionPointer<glGetUniformLocationDelegate>(GetMethodAddress("glGetUniformLocation"));
	public delegate GLint glGetUniformLocationDelegate(GLuint program, string name);

	public static readonly glGetUniformSubroutineuivDelegate glGetUniformSubroutineuiv = Marshal.GetDelegateForFunctionPointer<glGetUniformSubroutineuivDelegate>(GetMethodAddress("glGetUniformSubroutineuiv"));
	public delegate void glGetUniformSubroutineuivDelegate(GLenum shadertype, GLint location, GLuint* values);

	public static readonly glGetVertexArrayIndexed64ivDelegate glGetVertexArrayIndexed64iv = Marshal.GetDelegateForFunctionPointer<glGetVertexArrayIndexed64ivDelegate>(GetMethodAddress("glGetVertexArrayIndexed64iv"));
	public delegate void glGetVertexArrayIndexed64ivDelegate(GLuint vaobj, GLuint index, GLenum pname, GLint64* parameter);

	public static readonly glGetVertexArrayIndexedivDelegate glGetVertexArrayIndexediv = Marshal.GetDelegateForFunctionPointer<glGetVertexArrayIndexedivDelegate>(GetMethodAddress("glGetVertexArrayIndexediv"));
	public delegate void glGetVertexArrayIndexedivDelegate(GLuint vaobj, GLuint index, GLenum pname, GLint* parameter);

	public static readonly glGetVertexArrayivDelegate glGetVertexArrayiv = Marshal.GetDelegateForFunctionPointer<glGetVertexArrayivDelegate>(GetMethodAddress("glGetVertexArrayiv"));
	public delegate void glGetVertexArrayivDelegate(GLuint vaobj, GLenum pname, GLint* parameter);

	public static readonly glGetVertexAttribdvDelegate glGetVertexAttribdv = Marshal.GetDelegateForFunctionPointer<glGetVertexAttribdvDelegate>(GetMethodAddress("glGetVertexAttribdv"));
	public delegate void glGetVertexAttribdvDelegate(GLuint index, GLenum pname, GLdouble* parameters);

	public static readonly glGetVertexAttribfvDelegate glGetVertexAttribfv = Marshal.GetDelegateForFunctionPointer<glGetVertexAttribfvDelegate>(GetMethodAddress("glGetVertexAttribfv"));
	public delegate void glGetVertexAttribfvDelegate(GLuint index, GLenum pname, GLfloat* parameters);

	public static readonly glGetVertexAttribivDelegate glGetVertexAttribiv = Marshal.GetDelegateForFunctionPointer<glGetVertexAttribivDelegate>(GetMethodAddress("glGetVertexAttribiv"));
	public delegate void glGetVertexAttribivDelegate(GLuint index, GLenum pname, GLint* parameters);

	public static readonly glGetVertexAttribIivDelegate glGetVertexAttribIiv = Marshal.GetDelegateForFunctionPointer<glGetVertexAttribIivDelegate>(GetMethodAddress("glGetVertexAttribIiv"));
	public delegate void glGetVertexAttribIivDelegate(GLuint index, GLenum pname, GLint* parameters);

	public static readonly glGetVertexAttribIuivDelegate glGetVertexAttribIuiv = Marshal.GetDelegateForFunctionPointer<glGetVertexAttribIuivDelegate>(GetMethodAddress("glGetVertexAttribIuiv"));
	public delegate void glGetVertexAttribIuivDelegate(GLuint index, GLenum pname, GLuint* parameters);

	public static readonly glGetVertexAttribLdvDelegate glGetVertexAttribLdv = Marshal.GetDelegateForFunctionPointer<glGetVertexAttribLdvDelegate>(GetMethodAddress("glGetVertexAttribLdv"));
	public delegate void glGetVertexAttribLdvDelegate(GLuint index, GLenum pname, GLdouble* parameters);

	public static readonly glGetVertexAttribPointervDelegate glGetVertexAttribPointerv = Marshal.GetDelegateForFunctionPointer<glGetVertexAttribPointervDelegate>(GetMethodAddress("glGetVertexAttribPointerv"));
	public delegate void glGetVertexAttribPointervDelegate(GLuint index, GLenum pname, nint* pointer);

	// public static readonly glHintDelegate glHint = Marshal.GetDelegateForFunctionPointer<glHintDelegate>(GetMethodAddress("glHint"));
	// public delegate void glHintDelegate(GLenum target, GLenum mode);

	public static readonly glInvalidateBufferDataDelegate glInvalidateBufferData = Marshal.GetDelegateForFunctionPointer<glInvalidateBufferDataDelegate>(GetMethodAddress("glInvalidateBufferData"));
	public delegate void glInvalidateBufferDataDelegate(GLuint buffer);

	public static readonly glInvalidateBufferSubDataDelegate glInvalidateBufferSubData = Marshal.GetDelegateForFunctionPointer<glInvalidateBufferSubDataDelegate>(GetMethodAddress("glInvalidateBufferSubData"));
	public delegate void glInvalidateBufferSubDataDelegate(GLuint buffer, GLintptr offset, GLsizeiptr length);

	public static readonly glInvalidateFramebufferDelegate glInvalidateFramebuffer = Marshal.GetDelegateForFunctionPointer<glInvalidateFramebufferDelegate>(GetMethodAddress("glInvalidateFramebuffer"));
	public delegate void glInvalidateFramebufferDelegate(GLenum target, GLsizei numAttachments, GLenum* attachments);

	public static readonly glInvalidateNamedFramebufferDataDelegate glInvalidateNamedFramebufferData = Marshal.GetDelegateForFunctionPointer<glInvalidateNamedFramebufferDataDelegate>(GetMethodAddress("glInvalidateNamedFramebufferData"));
	public delegate void glInvalidateNamedFramebufferDataDelegate(GLuint framebuffer, GLsizei numAttachments, GLenum* attachments);

	public static readonly glInvalidateSubFramebufferDelegate glInvalidateSubFramebuffer = Marshal.GetDelegateForFunctionPointer<glInvalidateSubFramebufferDelegate>(GetMethodAddress("glInvalidateSubFramebuffer"));
	public delegate void glInvalidateSubFramebufferDelegate(GLenum target, GLsizei numAttachments, GLenum* attachments, GLint x, GLint y, GLint width, GLint height);

	public static readonly glInvalidateNamedFramebufferSubDataDelegate glInvalidateNamedFramebufferSubData = Marshal.GetDelegateForFunctionPointer<glInvalidateNamedFramebufferSubDataDelegate>(GetMethodAddress("glInvalidateNamedFramebufferSubData"));
	public delegate void glInvalidateNamedFramebufferSubDataDelegate(GLuint framebuffer, GLsizei numAttachments, GLenum* attachments, GLint x, GLint y, GLsizei width, GLsizei height);

	public static readonly glInvalidateTexImageDelegate glInvalidateTexImage = Marshal.GetDelegateForFunctionPointer<glInvalidateTexImageDelegate>(GetMethodAddress("glInvalidateTexImage"));
	public delegate void glInvalidateTexImageDelegate(GLuint texture, GLint level);

	public static readonly glInvalidateTexSubImageDelegate glInvalidateTexSubImage = Marshal.GetDelegateForFunctionPointer<glInvalidateTexSubImageDelegate>(GetMethodAddress("glInvalidateTexSubImage"));
	public delegate void glInvalidateTexSubImageDelegate(GLuint texture, GLint level, GLint xoffset, GLint yoffset, GLint zoffset, GLsizei width, GLsizei height, GLsizei depth);

	public static readonly glIsBufferDelegate glIsBuffer = Marshal.GetDelegateForFunctionPointer<glIsBufferDelegate>(GetMethodAddress("glIsBuffer"));
	public delegate GLboolean glIsBufferDelegate(GLuint buffer);

	// public static readonly glIsEnabledDelegate glIsEnabled = Marshal.GetDelegateForFunctionPointer<glIsEnabledDelegate>(GetMethodAddress("glIsEnabled"));
	// public delegate GLboolean glIsEnabledDelegate(GLenum cap);

	// public static readonly glIsEnablediDelegate glIsEnabledi = Marshal.GetDelegateForFunctionPointer<glIsEnablediDelegate>(GetMethodAddress("glIsEnabledi"));
	// public delegate GLboolean glIsEnablediDelegate(GLenum cap, GLuint index);

	public static readonly glIsFramebufferDelegate glIsFramebuffer = Marshal.GetDelegateForFunctionPointer<glIsFramebufferDelegate>(GetMethodAddress("glIsFramebuffer"));
	public delegate GLboolean glIsFramebufferDelegate(GLuint framebuffer);

	public static readonly glIsProgramDelegate glIsProgram = Marshal.GetDelegateForFunctionPointer<glIsProgramDelegate>(GetMethodAddress("glIsProgram"));
	public delegate GLboolean glIsProgramDelegate(GLuint program);

	public static readonly glIsProgramPipelineDelegate glIsProgramPipeline = Marshal.GetDelegateForFunctionPointer<glIsProgramPipelineDelegate>(GetMethodAddress("glIsProgramPipeline"));
	public delegate GLboolean glIsProgramPipelineDelegate(GLuint pipeline);

	public static readonly glIsQueryDelegate glIsQuery = Marshal.GetDelegateForFunctionPointer<glIsQueryDelegate>(GetMethodAddress("glIsQuery"));
	public delegate GLboolean glIsQueryDelegate(GLuint id);

	public static readonly glIsRenderbufferDelegate glIsRenderbuffer = Marshal.GetDelegateForFunctionPointer<glIsRenderbufferDelegate>(GetMethodAddress("glIsRenderbuffer"));
	public delegate GLboolean glIsRenderbufferDelegate(GLuint renderbuffer);

	public static readonly glIsSamplerDelegate glIsSampler = Marshal.GetDelegateForFunctionPointer<glIsSamplerDelegate>(GetMethodAddress("glIsSampler"));
	public delegate GLboolean glIsSamplerDelegate(GLuint id);

	public static readonly glIsShaderDelegate glIsShader = Marshal.GetDelegateForFunctionPointer<glIsShaderDelegate>(GetMethodAddress("glIsShader"));
	public delegate GLboolean glIsShaderDelegate(GLuint shader);

	public static readonly glIsSyncDelegate glIsSync = Marshal.GetDelegateForFunctionPointer<glIsSyncDelegate>(GetMethodAddress("glIsSync"));
	public delegate GLboolean glIsSyncDelegate(GLsync sync);

	public static readonly glIsTextureDelegate glIsTexture = Marshal.GetDelegateForFunctionPointer<glIsTextureDelegate>(GetMethodAddress("glIsTexture"));
	public delegate GLboolean glIsTextureDelegate(GLuint texture);

	public static readonly glIsTransformFeedbackDelegate glIsTransformFeedback = Marshal.GetDelegateForFunctionPointer<glIsTransformFeedbackDelegate>(GetMethodAddress("glIsTransformFeedback"));
	public delegate GLboolean glIsTransformFeedbackDelegate(GLuint id);

	public static readonly glIsVertexArrayDelegate glIsVertexArray = Marshal.GetDelegateForFunctionPointer<glIsVertexArrayDelegate>(GetMethodAddress("glIsVertexArray"));
	public delegate GLboolean glIsVertexArrayDelegate(GLuint array);

	// public static readonly glLineWidthDelegate glLineWidth = Marshal.GetDelegateForFunctionPointer<glLineWidthDelegate>(GetMethodAddress("glLineWidth"));
	// public delegate void glLineWidthDelegate(GLfloat width);

	public static readonly glLinkProgramDelegate glLinkProgram = Marshal.GetDelegateForFunctionPointer<glLinkProgramDelegate>(GetMethodAddress("glLinkProgram"));
	public delegate void glLinkProgramDelegate(GLuint program);

	// public static readonly glLogicOpDelegate glLogicOp = Marshal.GetDelegateForFunctionPointer<glLogicOpDelegate>(GetMethodAddress("glLogicOp"));
	// public delegate void glLogicOpDelegate(GLenum opcode);

	public static readonly glMapBufferDelegate glMapBuffer = Marshal.GetDelegateForFunctionPointer<glMapBufferDelegate>(GetMethodAddress("glMapBuffer"));
	public delegate nint glMapBufferDelegate(GLenum target, GLenum access);

	public static readonly glMapNamedBufferDelegate glMapNamedBuffer = Marshal.GetDelegateForFunctionPointer<glMapNamedBufferDelegate>(GetMethodAddress("glMapNamedBuffer"));
	public delegate nint glMapNamedBufferDelegate(GLuint buffer, GLenum access);

	public static readonly glMapBufferRangeDelegate glMapBufferRange = Marshal.GetDelegateForFunctionPointer<glMapBufferRangeDelegate>(GetMethodAddress("glMapBufferRange"));
	public delegate nint glMapBufferRangeDelegate(GLenum target, GLintptr offset, GLsizeiptr length, GLbitfield access);

	public static readonly glMapNamedBufferRangeDelegate glMapNamedBufferRange = Marshal.GetDelegateForFunctionPointer<glMapNamedBufferRangeDelegate>(GetMethodAddress("glMapNamedBufferRange"));
	public delegate nint glMapNamedBufferRangeDelegate(GLuint buffer, GLintptr offset, GLsizei length, GLbitfield access);

	public static readonly glMemoryBarrierDelegate glMemoryBarrier = Marshal.GetDelegateForFunctionPointer<glMemoryBarrierDelegate>(GetMethodAddress("glMemoryBarrier"));
	public delegate void glMemoryBarrierDelegate(GLbitfield barriers);

	public static readonly glMemoryBarrierByRegionDelegate glMemoryBarrierByRegion = Marshal.GetDelegateForFunctionPointer<glMemoryBarrierByRegionDelegate>(GetMethodAddress("glMemoryBarrierByRegion"));
	public delegate void glMemoryBarrierByRegionDelegate(GLbitfield barriers);

	public static readonly glMinSampleShadingDelegate glMinSampleShading = Marshal.GetDelegateForFunctionPointer<glMinSampleShadingDelegate>(GetMethodAddress("glMinSampleShading"));
	public delegate void glMinSampleShadingDelegate(GLfloat value);

	public static readonly glMultiDrawArraysDelegate glMultiDrawArrays = Marshal.GetDelegateForFunctionPointer<glMultiDrawArraysDelegate>(GetMethodAddress("glMultiDrawArrays"));
	public delegate void glMultiDrawArraysDelegate(GLenum mode, GLint* first, GLsizei* count, GLsizei drawcount);

	public static readonly glMultiDrawArraysIndirectDelegate glMultiDrawArraysIndirect = Marshal.GetDelegateForFunctionPointer<glMultiDrawArraysIndirectDelegate>(GetMethodAddress("glMultiDrawArraysIndirect"));
	public delegate void glMultiDrawArraysIndirectDelegate(GLenum mode, nint indirect, GLsizei drawcount, GLsizei stride);

	public static readonly glMultiDrawElementsDelegate glMultiDrawElements = Marshal.GetDelegateForFunctionPointer<glMultiDrawElementsDelegate>(GetMethodAddress("glMultiDrawElements"));
	public delegate void glMultiDrawElementsDelegate(GLenum mode, GLsizei* count, GLenum type, nint indices, GLsizei drawcount);

	public static readonly glMultiDrawElementsBaseVertexDelegate glMultiDrawElementsBaseVertex = Marshal.GetDelegateForFunctionPointer<glMultiDrawElementsBaseVertexDelegate>(GetMethodAddress("glMultiDrawElementsBaseVertex"));
	public delegate void glMultiDrawElementsBaseVertexDelegate(GLenum mode, GLsizei* count, GLenum type, nint indices, GLsizei drawcount, GLint* basevertex);

	public static readonly glMultiDrawElementsIndirectDelegate glMultiDrawElementsIndirect = Marshal.GetDelegateForFunctionPointer<glMultiDrawElementsIndirectDelegate>(GetMethodAddress("glMultiDrawElementsIndirect"));
	public delegate void glMultiDrawElementsIndirectDelegate(GLenum mode, GLenum type, nint indirect, GLsizei drawcount, GLsizei stride);

	public static readonly glObjectLabelDelegate glObjectLabel = Marshal.GetDelegateForFunctionPointer<glObjectLabelDelegate>(GetMethodAddress("glObjectLabel"));
	public delegate void glObjectLabelDelegate(GLenum identifier, GLuint name, GLsizei length, sbyte* label);

	public static readonly glObjectPtrLabelDelegate glObjectPtrLabel = Marshal.GetDelegateForFunctionPointer<glObjectPtrLabelDelegate>(GetMethodAddress("glObjectPtrLabel"));
	public delegate void glObjectPtrLabelDelegate(nint ptr, GLsizei length, sbyte* label);

	public static readonly glPatchParameteriDelegate glPatchParameteri = Marshal.GetDelegateForFunctionPointer<glPatchParameteriDelegate>(GetMethodAddress("glPatchParameteri"));
	public delegate void glPatchParameteriDelegate(GLenum pname, GLint value);

	public static readonly glPatchParameterfvDelegate glPatchParameterfv = Marshal.GetDelegateForFunctionPointer<glPatchParameterfvDelegate>(GetMethodAddress("glPatchParameterfv"));
	public delegate void glPatchParameterfvDelegate(GLenum pname, GLfloat* values);

	public static readonly glPauseTransformFeedbackDelegate glPauseTransformFeedback = Marshal.GetDelegateForFunctionPointer<glPauseTransformFeedbackDelegate>(GetMethodAddress("glPauseTransformFeedback"));
	public delegate void glPauseTransformFeedbackDelegate();

	// public static readonly glPixelStorefDelegate glPixelStoref = Marshal.GetDelegateForFunctionPointer<glPixelStorefDelegate>(GetMethodAddress("glPixelStoref"));
	// public delegate void glPixelStorefDelegate(GLenum pname, GLfloat parameter);

	// public static readonly glPixelStoreiDelegate glPixelStorei = Marshal.GetDelegateForFunctionPointer<glPixelStoreiDelegate>(GetMethodAddress("glPixelStorei"));
	// public delegate void glPixelStoreiDelegate(GLenum pname, GLint parameter);

	public static readonly glPointParameterfDelegate glPointParameterf = Marshal.GetDelegateForFunctionPointer<glPointParameterfDelegate>(GetMethodAddress("glPointParameterf"));
	public delegate void glPointParameterfDelegate(GLenum pname, GLfloat parameter);

	public static readonly glPointParameteriDelegate glPointParameteri = Marshal.GetDelegateForFunctionPointer<glPointParameteriDelegate>(GetMethodAddress("glPointParameteri"));
	public delegate void glPointParameteriDelegate(GLenum pname, GLint parameter);

	public static readonly glPointParameterfvDelegate glPointParameterfv = Marshal.GetDelegateForFunctionPointer<glPointParameterfvDelegate>(GetMethodAddress("glPointParameterfv"));
	public delegate void glPointParameterfvDelegate(GLenum pname, GLfloat* parameters);

	public static readonly glPointParameterivDelegate glPointParameteriv = Marshal.GetDelegateForFunctionPointer<glPointParameterivDelegate>(GetMethodAddress("glPointParameteriv"));
	public delegate void glPointParameterivDelegate(GLenum pname, GLint* parameters);

	// public static readonly glPointSizeDelegate glPointSize = Marshal.GetDelegateForFunctionPointer<glPointSizeDelegate>(GetMethodAddress("glPointSize"));
	// public delegate void glPointSizeDelegate(GLfloat size);

	// public static readonly glPolygonModeDelegate glPolygonMode = Marshal.GetDelegateForFunctionPointer<glPolygonModeDelegate>(GetMethodAddress("glPolygonMode"));
	// public delegate void glPolygonModeDelegate(GLenum face, GLenum mode);

	// public static readonly glPolygonOffsetDelegate glPolygonOffset = Marshal.GetDelegateForFunctionPointer<glPolygonOffsetDelegate>(GetMethodAddress("glPolygonOffset"));
	// public delegate void glPolygonOffsetDelegate(GLfloat factor, GLfloat units);

	public static readonly glPopDebugGroupDelegate glPopDebugGroup = Marshal.GetDelegateForFunctionPointer<glPopDebugGroupDelegate>(GetMethodAddress("glPopDebugGroup"));
	public delegate void glPopDebugGroupDelegate();

	public static readonly glPrimitiveRestartIndexDelegate glPrimitiveRestartIndex = Marshal.GetDelegateForFunctionPointer<glPrimitiveRestartIndexDelegate>(GetMethodAddress("glPrimitiveRestartIndex"));
	public delegate void glPrimitiveRestartIndexDelegate(GLuint index);

	public static readonly glProgramBinaryDelegate glProgramBinary = Marshal.GetDelegateForFunctionPointer<glProgramBinaryDelegate>(GetMethodAddress("glProgramBinary"));
	public delegate void glProgramBinaryDelegate(GLuint program, GLenum binaryFormat, nint binary, GLsizei length);

	public static readonly glProgramParameteriDelegate glProgramParameteri = Marshal.GetDelegateForFunctionPointer<glProgramParameteriDelegate>(GetMethodAddress("glProgramParameteri"));
	public delegate void glProgramParameteriDelegate(GLuint program, GLenum pname, GLint value);

	public static readonly glProgramUniform1fDelegate glProgramUniform1f = Marshal.GetDelegateForFunctionPointer<glProgramUniform1fDelegate>(GetMethodAddress("glProgramUniform1f"));
	public delegate void glProgramUniform1fDelegate(GLuint program, GLint location, GLfloat v0);

	public static readonly glProgramUniform2fDelegate glProgramUniform2f = Marshal.GetDelegateForFunctionPointer<glProgramUniform2fDelegate>(GetMethodAddress("glProgramUniform2f"));
	public delegate void glProgramUniform2fDelegate(GLuint program, GLint location, GLfloat v0, GLfloat v1);

	public static readonly glProgramUniform3fDelegate glProgramUniform3f = Marshal.GetDelegateForFunctionPointer<glProgramUniform3fDelegate>(GetMethodAddress("glProgramUniform3f"));
	public delegate void glProgramUniform3fDelegate(GLuint program, GLint location, GLfloat v0, GLfloat v1, GLfloat v2);

	public static readonly glProgramUniform4fDelegate glProgramUniform4f = Marshal.GetDelegateForFunctionPointer<glProgramUniform4fDelegate>(GetMethodAddress("glProgramUniform4f"));
	public delegate void glProgramUniform4fDelegate(GLuint program, GLint location, GLfloat v0, GLfloat v1, GLfloat v2, GLfloat v3);

	public static readonly glProgramUniform1iDelegate glProgramUniform1i = Marshal.GetDelegateForFunctionPointer<glProgramUniform1iDelegate>(GetMethodAddress("glProgramUniform1i"));
	public delegate void glProgramUniform1iDelegate(GLuint program, GLint location, GLint v0);

	public static readonly glProgramUniform2iDelegate glProgramUniform2i = Marshal.GetDelegateForFunctionPointer<glProgramUniform2iDelegate>(GetMethodAddress("glProgramUniform2i"));
	public delegate void glProgramUniform2iDelegate(GLuint program, GLint location, GLint v0, GLint v1);

	public static readonly glProgramUniform3iDelegate glProgramUniform3i = Marshal.GetDelegateForFunctionPointer<glProgramUniform3iDelegate>(GetMethodAddress("glProgramUniform3i"));
	public delegate void glProgramUniform3iDelegate(GLuint program, GLint location, GLint v0, GLint v1, GLint v2);

	public static readonly glProgramUniform4iDelegate glProgramUniform4i = Marshal.GetDelegateForFunctionPointer<glProgramUniform4iDelegate>(GetMethodAddress("glProgramUniform4i"));
	public delegate void glProgramUniform4iDelegate(GLuint program, GLint location, GLint v0, GLint v1, GLint v2, GLint v3);

	public static readonly glProgramUniform1uiDelegate glProgramUniform1ui = Marshal.GetDelegateForFunctionPointer<glProgramUniform1uiDelegate>(GetMethodAddress("glProgramUniform1ui"));
	public delegate void glProgramUniform1uiDelegate(GLuint program, GLint location, GLuint v0);

	public static readonly glProgramUniform2uiDelegate glProgramUniform2ui = Marshal.GetDelegateForFunctionPointer<glProgramUniform2uiDelegate>(GetMethodAddress("glProgramUniform2ui"));
	public delegate void glProgramUniform2uiDelegate(GLuint program, GLint location, GLuint v0, GLuint v1);

	public static readonly glProgramUniform3uiDelegate glProgramUniform3ui = Marshal.GetDelegateForFunctionPointer<glProgramUniform3uiDelegate>(GetMethodAddress("glProgramUniform3ui"));
	public delegate void glProgramUniform3uiDelegate(GLuint program, GLint location, GLuint v0, GLuint v1, GLuint v2);

	public static readonly glProgramUniform4uiDelegate glProgramUniform4ui = Marshal.GetDelegateForFunctionPointer<glProgramUniform4uiDelegate>(GetMethodAddress("glProgramUniform4ui"));
	public delegate void glProgramUniform4uiDelegate(GLuint program, GLint location, GLuint v0, GLuint v1, GLuint v2, GLuint v3);

	public static readonly glProgramUniform1fvDelegate glProgramUniform1fv = Marshal.GetDelegateForFunctionPointer<glProgramUniform1fvDelegate>(GetMethodAddress("glProgramUniform1fv"));
	public delegate void glProgramUniform1fvDelegate(GLuint program, GLint location, GLsizei count, GLfloat* value);

	public static readonly glProgramUniform2fvDelegate glProgramUniform2fv = Marshal.GetDelegateForFunctionPointer<glProgramUniform2fvDelegate>(GetMethodAddress("glProgramUniform2fv"));
	public delegate void glProgramUniform2fvDelegate(GLuint program, GLint location, GLsizei count, GLfloat* value);

	public static readonly glProgramUniform3fvDelegate glProgramUniform3fv = Marshal.GetDelegateForFunctionPointer<glProgramUniform3fvDelegate>(GetMethodAddress("glProgramUniform3fv"));
	public delegate void glProgramUniform3fvDelegate(GLuint program, GLint location, GLsizei count, GLfloat* value);

	public static readonly glProgramUniform4fvDelegate glProgramUniform4fv = Marshal.GetDelegateForFunctionPointer<glProgramUniform4fvDelegate>(GetMethodAddress("glProgramUniform4fv"));
	public delegate void glProgramUniform4fvDelegate(GLuint program, GLint location, GLsizei count, GLfloat* value);

	public static readonly glProgramUniform1ivDelegate glProgramUniform1iv = Marshal.GetDelegateForFunctionPointer<glProgramUniform1ivDelegate>(GetMethodAddress("glProgramUniform1iv"));
	public delegate void glProgramUniform1ivDelegate(GLuint program, GLint location, GLsizei count, GLint* value);

	public static readonly glProgramUniform2ivDelegate glProgramUniform2iv = Marshal.GetDelegateForFunctionPointer<glProgramUniform2ivDelegate>(GetMethodAddress("glProgramUniform2iv"));
	public delegate void glProgramUniform2ivDelegate(GLuint program, GLint location, GLsizei count, GLint* value);

	public static readonly glProgramUniform3ivDelegate glProgramUniform3iv = Marshal.GetDelegateForFunctionPointer<glProgramUniform3ivDelegate>(GetMethodAddress("glProgramUniform3iv"));
	public delegate void glProgramUniform3ivDelegate(GLuint program, GLint location, GLsizei count, GLint* value);

	public static readonly glProgramUniform4ivDelegate glProgramUniform4iv = Marshal.GetDelegateForFunctionPointer<glProgramUniform4ivDelegate>(GetMethodAddress("glProgramUniform4iv"));
	public delegate void glProgramUniform4ivDelegate(GLuint program, GLint location, GLsizei count, GLint* value);

	public static readonly glProgramUniform1uivDelegate glProgramUniform1uiv = Marshal.GetDelegateForFunctionPointer<glProgramUniform1uivDelegate>(GetMethodAddress("glProgramUniform1uiv"));
	public delegate void glProgramUniform1uivDelegate(GLuint program, GLint location, GLsizei count, GLuint* value);

	public static readonly glProgramUniform2uivDelegate glProgramUniform2uiv = Marshal.GetDelegateForFunctionPointer<glProgramUniform2uivDelegate>(GetMethodAddress("glProgramUniform2uiv"));
	public delegate void glProgramUniform2uivDelegate(GLuint program, GLint location, GLsizei count, GLuint* value);

	public static readonly glProgramUniform3uivDelegate glProgramUniform3uiv = Marshal.GetDelegateForFunctionPointer<glProgramUniform3uivDelegate>(GetMethodAddress("glProgramUniform3uiv"));
	public delegate void glProgramUniform3uivDelegate(GLuint program, GLint location, GLsizei count, GLuint* value);

	public static readonly glProgramUniform4uivDelegate glProgramUniform4uiv = Marshal.GetDelegateForFunctionPointer<glProgramUniform4uivDelegate>(GetMethodAddress("glProgramUniform4uiv"));
	public delegate void glProgramUniform4uivDelegate(GLuint program, GLint location, GLsizei count, GLuint* value);

	public static readonly glProgramUniformMatrix2fvDelegate glProgramUniformMatrix2fv = Marshal.GetDelegateForFunctionPointer<glProgramUniformMatrix2fvDelegate>(GetMethodAddress("glProgramUniformMatrix2fv"));
	public delegate void glProgramUniformMatrix2fvDelegate(GLuint program, GLint location, GLsizei count, GLboolean transpose, GLfloat* value);

	public static readonly glProgramUniformMatrix3fvDelegate glProgramUniformMatrix3fv = Marshal.GetDelegateForFunctionPointer<glProgramUniformMatrix3fvDelegate>(GetMethodAddress("glProgramUniformMatrix3fv"));
	public delegate void glProgramUniformMatrix3fvDelegate(GLuint program, GLint location, GLsizei count, GLboolean transpose, GLfloat* value);

	public static readonly glProgramUniformMatrix4fvDelegate glProgramUniformMatrix4fv = Marshal.GetDelegateForFunctionPointer<glProgramUniformMatrix4fvDelegate>(GetMethodAddress("glProgramUniformMatrix4fv"));
	public delegate void glProgramUniformMatrix4fvDelegate(GLuint program, GLint location, GLsizei count, GLboolean transpose, GLfloat* value);

	public static readonly glProgramUniformMatrix2x3fvDelegate glProgramUniformMatrix2x3fv = Marshal.GetDelegateForFunctionPointer<glProgramUniformMatrix2x3fvDelegate>(GetMethodAddress("glProgramUniformMatrix2x3fv"));
	public delegate void glProgramUniformMatrix2x3fvDelegate(GLuint program, GLint location, GLsizei count, GLboolean transpose, GLfloat* value);

	public static readonly glProgramUniformMatrix3x2fvDelegate glProgramUniformMatrix3x2fv = Marshal.GetDelegateForFunctionPointer<glProgramUniformMatrix3x2fvDelegate>(GetMethodAddress("glProgramUniformMatrix3x2fv"));
	public delegate void glProgramUniformMatrix3x2fvDelegate(GLuint program, GLint location, GLsizei count, GLboolean transpose, GLfloat* value);

	public static readonly glProgramUniformMatrix2x4fvDelegate glProgramUniformMatrix2x4fv = Marshal.GetDelegateForFunctionPointer<glProgramUniformMatrix2x4fvDelegate>(GetMethodAddress("glProgramUniformMatrix2x4fv"));
	public delegate void glProgramUniformMatrix2x4fvDelegate(GLuint program, GLint location, GLsizei count, GLboolean transpose, GLfloat* value);

	public static readonly glProgramUniformMatrix4x2fvDelegate glProgramUniformMatrix4x2fv = Marshal.GetDelegateForFunctionPointer<glProgramUniformMatrix4x2fvDelegate>(GetMethodAddress("glProgramUniformMatrix4x2fv"));
	public delegate void glProgramUniformMatrix4x2fvDelegate(GLuint program, GLint location, GLsizei count, GLboolean transpose, GLfloat* value);

	public static readonly glProgramUniformMatrix3x4fvDelegate glProgramUniformMatrix3x4fv = Marshal.GetDelegateForFunctionPointer<glProgramUniformMatrix3x4fvDelegate>(GetMethodAddress("glProgramUniformMatrix3x4fv"));
	public delegate void glProgramUniformMatrix3x4fvDelegate(GLuint program, GLint location, GLsizei count, GLboolean transpose, GLfloat* value);

	public static readonly glProgramUniformMatrix4x3fvDelegate glProgramUniformMatrix4x3fv = Marshal.GetDelegateForFunctionPointer<glProgramUniformMatrix4x3fvDelegate>(GetMethodAddress("glProgramUniformMatrix4x3fv"));
	public delegate void glProgramUniformMatrix4x3fvDelegate(GLuint program, GLint location, GLsizei count, GLboolean transpose, GLfloat* value);

	public static readonly glProvokingVertexDelegate glProvokingVertex = Marshal.GetDelegateForFunctionPointer<glProvokingVertexDelegate>(GetMethodAddress("glProvokingVertex"));
	public delegate void glProvokingVertexDelegate(GLenum provokeMode);

	public static readonly glPushDebugGroupDelegate glPushDebugGroup = Marshal.GetDelegateForFunctionPointer<glPushDebugGroupDelegate>(GetMethodAddress("glPushDebugGroup"));
	public delegate void glPushDebugGroupDelegate(GLenum source, GLuint id, GLsizei length, sbyte* message);

	public static readonly glQueryCounterDelegate glQueryCounter = Marshal.GetDelegateForFunctionPointer<glQueryCounterDelegate>(GetMethodAddress("glQueryCounter"));
	public delegate void glQueryCounterDelegate(GLuint id, GLenum target);

	// public static readonly glReadBufferDelegate glReadBuffer = Marshal.GetDelegateForFunctionPointer<glReadBufferDelegate>(GetMethodAddress("glReadBuffer"));
	// public delegate void glReadBufferDelegate(GLenum mode);

	public static readonly glNamedFramebufferReadBufferDelegate glNamedFramebufferReadBuffer = Marshal.GetDelegateForFunctionPointer<glNamedFramebufferReadBufferDelegate>(GetMethodAddress("glNamedFramebufferReadBuffer"));
	public delegate void glNamedFramebufferReadBufferDelegate(GLuint framebuffer, GLenum mode);

	// public static readonly glReadPixelsDelegate glReadPixels = Marshal.GetDelegateForFunctionPointer<glReadPixelsDelegate>(GetMethodAddress("glReadPixels"));
	// public delegate void glReadPixelsDelegate(GLint x, GLint y, GLsizei width, GLsizei height, GLenum format, GLenum type, nint data);

	public static readonly glReadnPixelsDelegate glReadnPixels = Marshal.GetDelegateForFunctionPointer<glReadnPixelsDelegate>(GetMethodAddress("glReadnPixels"));
	public delegate void glReadnPixelsDelegate(GLint x, GLint y, GLsizei width, GLsizei height, GLenum format, GLenum type, GLsizei bufSize, nint data);

	public static readonly glReleaseShaderCompilerDelegate glReleaseShaderCompiler = Marshal.GetDelegateForFunctionPointer<glReleaseShaderCompilerDelegate>(GetMethodAddress("glReleaseShaderCompiler"));
	public delegate void glReleaseShaderCompilerDelegate();

	public static readonly glRenderbufferStorageDelegate glRenderbufferStorage = Marshal.GetDelegateForFunctionPointer<glRenderbufferStorageDelegate>(GetMethodAddress("glRenderbufferStorage"));
	public delegate void glRenderbufferStorageDelegate(GLenum target, GLenum internalformat, GLsizei width, GLsizei height);

	public static readonly glNamedRenderbufferStorageDelegate glNamedRenderbufferStorage = Marshal.GetDelegateForFunctionPointer<glNamedRenderbufferStorageDelegate>(GetMethodAddress("glNamedRenderbufferStorage"));
	public delegate void glNamedRenderbufferStorageDelegate(GLuint renderbuffer, GLenum internalformat, GLsizei width, GLsizei height);

	public static readonly glRenderbufferStorageMultisampleDelegate glRenderbufferStorageMultisample = Marshal.GetDelegateForFunctionPointer<glRenderbufferStorageMultisampleDelegate>(GetMethodAddress("glRenderbufferStorageMultisample"));
	public delegate void glRenderbufferStorageMultisampleDelegate(GLenum target, GLsizei samples, GLenum internalformat, GLsizei width, GLsizei height);

	public static readonly glNamedRenderbufferStorageMultisampleDelegate glNamedRenderbufferStorageMultisample = Marshal.GetDelegateForFunctionPointer<glNamedRenderbufferStorageMultisampleDelegate>(GetMethodAddress("glNamedRenderbufferStorageMultisample"));
	public delegate void glNamedRenderbufferStorageMultisampleDelegate(GLuint renderbuffer, GLsizei samples, GLenum internalformat, GLsizei width, GLsizei height);

	public static readonly glResumeTransformFeedbackDelegate glResumeTransformFeedback = Marshal.GetDelegateForFunctionPointer<glResumeTransformFeedbackDelegate>(GetMethodAddress("glResumeTransformFeedback"));
	public delegate void glResumeTransformFeedbackDelegate();

	public static readonly glSampleCoverageDelegate glSampleCoverage = Marshal.GetDelegateForFunctionPointer<glSampleCoverageDelegate>(GetMethodAddress("glSampleCoverage"));
	public delegate void glSampleCoverageDelegate(GLfloat value, GLboolean invert);

	public static readonly glSampleMaskiDelegate glSampleMaski = Marshal.GetDelegateForFunctionPointer<glSampleMaskiDelegate>(GetMethodAddress("glSampleMaski"));
	public delegate void glSampleMaskiDelegate(GLuint maskNumber, GLbitfield mask);

	public static readonly glSamplerParameterfDelegate glSamplerParameterf = Marshal.GetDelegateForFunctionPointer<glSamplerParameterfDelegate>(GetMethodAddress("glSamplerParameterf"));
	public delegate void glSamplerParameterfDelegate(GLuint sampler, GLenum pname, GLfloat parameter);

	public static readonly glSamplerParameteriDelegate glSamplerParameteri = Marshal.GetDelegateForFunctionPointer<glSamplerParameteriDelegate>(GetMethodAddress("glSamplerParameteri"));
	public delegate void glSamplerParameteriDelegate(GLuint sampler, GLenum pname, GLint parameter);

	public static readonly glSamplerParameterfvDelegate glSamplerParameterfv = Marshal.GetDelegateForFunctionPointer<glSamplerParameterfvDelegate>(GetMethodAddress("glSamplerParameterfv"));
	public delegate void glSamplerParameterfvDelegate(GLuint sampler, GLenum pname, GLfloat* parameters);

	public static readonly glSamplerParameterivDelegate glSamplerParameteriv = Marshal.GetDelegateForFunctionPointer<glSamplerParameterivDelegate>(GetMethodAddress("glSamplerParameteriv"));
	public delegate void glSamplerParameterivDelegate(GLuint sampler, GLenum pname, GLint* parameters);

	public static readonly glSamplerParameterIivDelegate glSamplerParameterIiv = Marshal.GetDelegateForFunctionPointer<glSamplerParameterIivDelegate>(GetMethodAddress("glSamplerParameterIiv"));
	public delegate void glSamplerParameterIivDelegate(GLuint sampler, GLenum pname, GLint* parameters);

	public static readonly glSamplerParameterIuivDelegate glSamplerParameterIuiv = Marshal.GetDelegateForFunctionPointer<glSamplerParameterIuivDelegate>(GetMethodAddress("glSamplerParameterIuiv"));
	public delegate void glSamplerParameterIuivDelegate(GLuint sampler, GLenum pname, GLuint* parameters);

	// public static readonly glScissorDelegate glScissor = Marshal.GetDelegateForFunctionPointer<glScissorDelegate>(GetMethodAddress("glScissor"));
	// public delegate void glScissorDelegate(GLint x, GLint y, GLsizei width, GLsizei height);

	public static readonly glScissorArrayvDelegate glScissorArrayv = Marshal.GetDelegateForFunctionPointer<glScissorArrayvDelegate>(GetMethodAddress("glScissorArrayv"));
	public delegate void glScissorArrayvDelegate(GLuint first, GLsizei count, GLint* v);

	public static readonly glScissorIndexedDelegate glScissorIndexed = Marshal.GetDelegateForFunctionPointer<glScissorIndexedDelegate>(GetMethodAddress("glScissorIndexed"));
	public delegate void glScissorIndexedDelegate(GLuint index, GLint left, GLint bottom, GLsizei width, GLsizei height);

	public static readonly glScissorIndexedvDelegate glScissorIndexedv = Marshal.GetDelegateForFunctionPointer<glScissorIndexedvDelegate>(GetMethodAddress("glScissorIndexedv"));
	public delegate void glScissorIndexedvDelegate(GLuint index, GLint* v);

	public static readonly glShaderBinaryDelegate glShaderBinary = Marshal.GetDelegateForFunctionPointer<glShaderBinaryDelegate>(GetMethodAddress("glShaderBinary"));
	public delegate void glShaderBinaryDelegate(GLsizei count, GLuint* shaders, GLenum binaryFormat, nint binary, GLsizei length);

	public static readonly glShaderSourceDelegate glShaderSource = Marshal.GetDelegateForFunctionPointer<glShaderSourceDelegate>(GetMethodAddress("glShaderSource"));
	public delegate void glShaderSourceDelegate(GLuint shader, GLsizei count, ref string str, ref GLint length);

	public static readonly glShaderStorageBlockBindingDelegate glShaderStorageBlockBinding = Marshal.GetDelegateForFunctionPointer<glShaderStorageBlockBindingDelegate>(GetMethodAddress("glShaderStorageBlockBinding"));
	public delegate void glShaderStorageBlockBindingDelegate(GLuint program, GLuint storageBlockIndex, GLuint storageBlockBinding);

	// public static readonly glStencilFuncDelegate glStencilFunc = Marshal.GetDelegateForFunctionPointer<glStencilFuncDelegate>(GetMethodAddress("glStencilFunc"));
	// public delegate void glStencilFuncDelegate(GLenum func, GLint reference, GLuint mask);

	public static readonly glStencilFuncSeparateDelegate glStencilFuncSeparate = Marshal.GetDelegateForFunctionPointer<glStencilFuncSeparateDelegate>(GetMethodAddress("glStencilFuncSeparate"));
	public delegate void glStencilFuncSeparateDelegate(GLenum face, GLenum func, GLint reference, GLuint mask);

	// public static readonly glStencilMaskDelegate glStencilMask = Marshal.GetDelegateForFunctionPointer<glStencilMaskDelegate>(GetMethodAddress("glStencilMask"));
	// public delegate void glStencilMaskDelegate(GLuint mask);

	public static readonly glStencilMaskSeparateDelegate glStencilMaskSeparate = Marshal.GetDelegateForFunctionPointer<glStencilMaskSeparateDelegate>(GetMethodAddress("glStencilMaskSeparate"));
	public delegate void glStencilMaskSeparateDelegate(GLenum face, GLuint mask);

	// public static readonly glStencilOpDelegate glStencilOp = Marshal.GetDelegateForFunctionPointer<glStencilOpDelegate>(GetMethodAddress("glStencilOp"));
	// public delegate void glStencilOpDelegate(GLenum sfail, GLenum dpfail, GLenum dppass);

	public static readonly glStencilOpSeparateDelegate glStencilOpSeparate = Marshal.GetDelegateForFunctionPointer<glStencilOpSeparateDelegate>(GetMethodAddress("glStencilOpSeparate"));
	public delegate void glStencilOpSeparateDelegate(GLenum face, GLenum sfail, GLenum dpfail, GLenum dppass);

	public static readonly glTexBufferDelegate glTexBuffer = Marshal.GetDelegateForFunctionPointer<glTexBufferDelegate>(GetMethodAddress("glTexBuffer"));
	public delegate void glTexBufferDelegate(GLenum target, GLenum internalFormat, GLuint buffer);

	public static readonly glTextureBufferDelegate glTextureBuffer = Marshal.GetDelegateForFunctionPointer<glTextureBufferDelegate>(GetMethodAddress("glTextureBuffer"));
	public delegate void glTextureBufferDelegate(GLuint texture, GLenum internalformat, GLuint buffer);

	public static readonly glTexBufferRangeDelegate glTexBufferRange = Marshal.GetDelegateForFunctionPointer<glTexBufferRangeDelegate>(GetMethodAddress("glTexBufferRange"));
	public delegate void glTexBufferRangeDelegate(GLenum target, GLenum internalFormat, GLuint buffer, GLintptr offset, GLsizeiptr size);

	public static readonly glTextureBufferRangeDelegate glTextureBufferRange = Marshal.GetDelegateForFunctionPointer<glTextureBufferRangeDelegate>(GetMethodAddress("glTextureBufferRange"));
	public delegate void glTextureBufferRangeDelegate(GLuint texture, GLenum internalformat, GLuint buffer, GLintptr offset, GLsizei size);

	[DllImport(GL_LIB)] public static extern void glTexImage1D(GLenum target, GLint level, GLint internalFormat, GLsizei width, GLint border, GLenum format, GLenum type, nint data);
	// public static readonly glTexImage1DDelegate glTexImage1D = Marshal.GetDelegateForFunctionPointer<glTexImage1DDelegate>(GetMethodAddress("glTexImage1D"));
	// public delegate void glTexImage1DDelegate(GLenum target, GLint level, GLint internalFormat, GLsizei width, GLint border, GLenum format, GLenum type, nint data);

	[DllImport(GL_LIB)] public static extern void glTexImage2D(GLenum target, GLint level, GLint internalFormat, GLsizei width, GLsizei height, GLint border, GLenum format, GLenum type, nint data);
	// public static readonly glTexImage2DDelegate glTexImage2D = Marshal.GetDelegateForFunctionPointer<glTexImage2DDelegate>(GetMethodAddress("glTexImage2D"));
	// public delegate void glTexImage2DDelegate(GLenum target, GLint level, GLint internalFormat, GLsizei width, GLsizei height, GLint border, GLenum format, GLenum type, nint data);

	public static readonly glTexImage2DMultisampleDelegate glTexImage2DMultisample = Marshal.GetDelegateForFunctionPointer<glTexImage2DMultisampleDelegate>(GetMethodAddress("glTexImage2DMultisample"));
	public delegate void glTexImage2DMultisampleDelegate(GLenum target, GLsizei samples, GLenum internalformat, GLsizei width, GLsizei height, GLboolean fixedsamplelocations);

	public static readonly glTexImage3DDelegate glTexImage3D = Marshal.GetDelegateForFunctionPointer<glTexImage3DDelegate>(GetMethodAddress("glTexImage3D"));
	public delegate void glTexImage3DDelegate(GLenum target, GLint level, GLint internalFormat, GLsizei width, GLsizei height, GLsizei depth, GLint border, GLenum format, GLenum type, nint data);

	public static readonly glTexImage3DMultisampleDelegate glTexImage3DMultisample = Marshal.GetDelegateForFunctionPointer<glTexImage3DMultisampleDelegate>(GetMethodAddress("glTexImage3DMultisample"));
	public delegate void glTexImage3DMultisampleDelegate(GLenum target, GLsizei samples, GLenum internalformat, GLsizei width, GLsizei height, GLsizei depth, GLboolean fixedsamplelocations);

	[DllImport(GL_LIB)] public static extern void glTexParameterf(GLenum target, GLenum pname, GLfloat parameter);
	// public static readonly glTexParameterfDelegate glTexParameterf = Marshal.GetDelegateForFunctionPointer<glTexParameterfDelegate>(GetMethodAddress("glTexParameterf"));
	// public delegate void glTexParameterfDelegate(GLenum target, GLenum pname, GLfloat parameter);

	[DllImport(GL_LIB)] public static extern void glTexParameteri(GLenum target, GLenum pname, GLint parameter);
	// public static readonly glTexParameteriDelegate glTexParameteri = Marshal.GetDelegateForFunctionPointer<glTexParameteriDelegate>(GetMethodAddress("glTexParameteri"));
	// public delegate void glTexParameteriDelegate(GLenum target, GLenum pname, GLint parameter);

	public static readonly glTextureParameterfDelegate glTextureParameterf = Marshal.GetDelegateForFunctionPointer<glTextureParameterfDelegate>(GetMethodAddress("glTextureParameterf"));
	public delegate void glTextureParameterfDelegate(GLuint texture, GLenum pname, GLfloat parameter);

	public static readonly glTextureParameteriDelegate glTextureParameteri = Marshal.GetDelegateForFunctionPointer<glTextureParameteriDelegate>(GetMethodAddress("glTextureParameteri"));
	public delegate void glTextureParameteriDelegate(GLuint texture, GLenum pname, GLint parameter);

	[DllImport(GL_LIB)] public static extern void glTexParameterfv(GLenum target, GLenum pname, ref GLfloat parameters);
	// public static readonly glTexParameterfvDelegate glTexParameterfv = Marshal.GetDelegateForFunctionPointer<glTexParameterfvDelegate>(GetMethodAddress("glTexParameterfv"));
	// public delegate void glTexParameterfvDelegate(GLenum target, GLenum pname, GLfloat* parameters);

	[DllImport(GL_LIB)] public static extern void glTexParameteriv(GLenum target, GLenum pname, ref GLint parameters);
	// public static readonly glTexParameterivDelegate glTexParameteriv = Marshal.GetDelegateForFunctionPointer<glTexParameterivDelegate>(GetMethodAddress("glTexParameteriv"));
	// public delegate void glTexParameterivDelegate(GLenum target, GLenum pname, GLint* parameters);

	public static readonly glTexParameterIivDelegate glTexParameterIiv = Marshal.GetDelegateForFunctionPointer<glTexParameterIivDelegate>(GetMethodAddress("glTexParameterIiv"));
	public delegate void glTexParameterIivDelegate(GLenum target, GLenum pname, GLint* parameters);

	public static readonly glTexParameterIuivDelegate glTexParameterIuiv = Marshal.GetDelegateForFunctionPointer<glTexParameterIuivDelegate>(GetMethodAddress("glTexParameterIuiv"));
	public delegate void glTexParameterIuivDelegate(GLenum target, GLenum pname, GLuint* parameters);

	public static readonly glTextureParameterfvDelegate glTextureParameterfv = Marshal.GetDelegateForFunctionPointer<glTextureParameterfvDelegate>(GetMethodAddress("glTextureParameterfv"));
	public delegate void glTextureParameterfvDelegate(GLuint texture, GLenum pname, GLfloat* paramtexture);

	public static readonly glTextureParameterivDelegate glTextureParameteriv = Marshal.GetDelegateForFunctionPointer<glTextureParameterivDelegate>(GetMethodAddress("glTextureParameteriv"));
	public delegate void glTextureParameterivDelegate(GLuint texture, GLenum pname, GLint* parameter);

	public static readonly glTextureParameterIivDelegate glTextureParameterIiv = Marshal.GetDelegateForFunctionPointer<glTextureParameterIivDelegate>(GetMethodAddress("glTextureParameterIiv"));
	public delegate void glTextureParameterIivDelegate(GLuint texture, GLenum pname, GLint* parameters);

	public static readonly glTextureParameterIuivDelegate glTextureParameterIuiv = Marshal.GetDelegateForFunctionPointer<glTextureParameterIuivDelegate>(GetMethodAddress("glTextureParameterIuiv"));
	public delegate void glTextureParameterIuivDelegate(GLuint texture, GLenum pname, GLuint* parameters);

	public static readonly glTexStorage1DDelegate glTexStorage1D = Marshal.GetDelegateForFunctionPointer<glTexStorage1DDelegate>(GetMethodAddress("glTexStorage1D"));
	public delegate void glTexStorage1DDelegate(GLenum target, GLsizei levels, GLenum internalformat, GLsizei width);

	public static readonly glTextureStorage1DDelegate glTextureStorage1D = Marshal.GetDelegateForFunctionPointer<glTextureStorage1DDelegate>(GetMethodAddress("glTextureStorage1D"));
	public delegate void glTextureStorage1DDelegate(GLuint texture, GLsizei levels, GLenum internalformat, GLsizei width);

	public static readonly glTexStorage2DDelegate glTexStorage2D = Marshal.GetDelegateForFunctionPointer<glTexStorage2DDelegate>(GetMethodAddress("glTexStorage2D"));
	public delegate void glTexStorage2DDelegate(GLenum target, GLsizei levels, GLenum internalformat, GLsizei width, GLsizei height);

	public static readonly glTextureStorage2DDelegate glTextureStorage2D = Marshal.GetDelegateForFunctionPointer<glTextureStorage2DDelegate>(GetMethodAddress("glTextureStorage2D"));
	public delegate void glTextureStorage2DDelegate(GLuint texture, GLsizei levels, GLenum internalformat, GLsizei width, GLsizei height);

	public static readonly glTexStorage2DMultisampleDelegate glTexStorage2DMultisample = Marshal.GetDelegateForFunctionPointer<glTexStorage2DMultisampleDelegate>(GetMethodAddress("glTexStorage2DMultisample"));
	public delegate void glTexStorage2DMultisampleDelegate(GLenum target, GLsizei samples, GLenum internalformat, GLsizei width, GLsizei height, GLboolean fixedsamplelocations);

	public static readonly glTextureStorage2DMultisampleDelegate glTextureStorage2DMultisample = Marshal.GetDelegateForFunctionPointer<glTextureStorage2DMultisampleDelegate>(GetMethodAddress("glTextureStorage2DMultisample"));
	public delegate void glTextureStorage2DMultisampleDelegate(GLuint texture, GLsizei samples, GLenum internalformat, GLsizei width, GLsizei height, GLboolean fixedsamplelocations);

	public static readonly glTexStorage3DDelegate glTexStorage3D = Marshal.GetDelegateForFunctionPointer<glTexStorage3DDelegate>(GetMethodAddress("glTexStorage3D"));
	public delegate void glTexStorage3DDelegate(GLenum target, GLsizei levels, GLenum internalformat, GLsizei width, GLsizei height, GLsizei depth);

	public static readonly glTextureStorage3DDelegate glTextureStorage3D = Marshal.GetDelegateForFunctionPointer<glTextureStorage3DDelegate>(GetMethodAddress("glTextureStorage3D"));
	public delegate void glTextureStorage3DDelegate(GLuint texture, GLsizei levels, GLenum internalformat, GLsizei width, GLsizei height, GLsizei depth);

	public static readonly glTexStorage3DMultisampleDelegate glTexStorage3DMultisample = Marshal.GetDelegateForFunctionPointer<glTexStorage3DMultisampleDelegate>(GetMethodAddress("glTexStorage3DMultisample"));
	public delegate void glTexStorage3DMultisampleDelegate(GLenum target, GLsizei samples, GLenum internalformat, GLsizei width, GLsizei height, GLsizei depth, GLboolean fixedsamplelocations);

	public static readonly glTextureStorage3DMultisampleDelegate glTextureStorage3DMultisample = Marshal.GetDelegateForFunctionPointer<glTextureStorage3DMultisampleDelegate>(GetMethodAddress("glTextureStorage3DMultisample"));
	public delegate void glTextureStorage3DMultisampleDelegate(GLuint texture, GLsizei samples, GLenum internalformat, GLsizei width, GLsizei height, GLsizei depth, GLboolean fixedsamplelocations);

	public static readonly glTexSubImage1DDelegate glTexSubImage1D = Marshal.GetDelegateForFunctionPointer<glTexSubImage1DDelegate>(GetMethodAddress("glTexSubImage1D"));
	public delegate void glTexSubImage1DDelegate(GLenum target, GLint level, GLint xoffset, GLsizei width, GLenum format, GLenum type, nint pixels);

	public static readonly glTextureSubImage1DDelegate glTextureSubImage1D = Marshal.GetDelegateForFunctionPointer<glTextureSubImage1DDelegate>(GetMethodAddress("glTextureSubImage1D"));
	public delegate void glTextureSubImage1DDelegate(GLuint texture, GLint level, GLint xoffset, GLsizei width, GLenum format, GLenum type, nint pixels);

	public static readonly glTexSubImage2DDelegate glTexSubImage2D = Marshal.GetDelegateForFunctionPointer<glTexSubImage2DDelegate>(GetMethodAddress("glTexSubImage2D"));
	public delegate void glTexSubImage2DDelegate(GLenum target, GLint level, GLint xoffset, GLint yoffset, GLsizei width, GLsizei height, GLenum format, GLenum type, nint pixels);

	public static readonly glTextureSubImage2DDelegate glTextureSubImage2D = Marshal.GetDelegateForFunctionPointer<glTextureSubImage2DDelegate>(GetMethodAddress("glTextureSubImage2D"));
	public delegate void glTextureSubImage2DDelegate(GLuint texture, GLint level, GLint xoffset, GLint yoffset, GLsizei width, GLsizei height, GLenum format, GLenum type, nint pixels);

	public static readonly glTexSubImage3DDelegate glTexSubImage3D = Marshal.GetDelegateForFunctionPointer<glTexSubImage3DDelegate>(GetMethodAddress("glTexSubImage3D"));
	public delegate void glTexSubImage3DDelegate(GLenum target, GLint level, GLint xoffset, GLint yoffset, GLint zoffset, GLsizei width, GLsizei height, GLsizei depth, GLenum format, GLenum type, nint pixels);

	public static readonly glTextureSubImage3DDelegate glTextureSubImage3D = Marshal.GetDelegateForFunctionPointer<glTextureSubImage3DDelegate>(GetMethodAddress("glTextureSubImage3D"));
	public delegate void glTextureSubImage3DDelegate(GLuint texture, GLint level, GLint xoffset, GLint yoffset, GLint zoffset, GLsizei width, GLsizei height, GLsizei depth, GLenum format, GLenum type, nint pixels);

	public static readonly glTextureBarrierDelegate glTextureBarrier = Marshal.GetDelegateForFunctionPointer<glTextureBarrierDelegate>(GetMethodAddress("glTextureBarrier"));
	public delegate void glTextureBarrierDelegate();

	public static readonly glTextureViewDelegate glTextureView = Marshal.GetDelegateForFunctionPointer<glTextureViewDelegate>(GetMethodAddress("glTextureView"));
	public delegate void glTextureViewDelegate(GLuint texture, GLenum target, GLuint origtexture, GLenum internalformat, GLuint minlevel, GLuint numlevels, GLuint minlayer, GLuint numlayers);

	public static readonly glTransformFeedbackBufferBaseDelegate glTransformFeedbackBufferBase = Marshal.GetDelegateForFunctionPointer<glTransformFeedbackBufferBaseDelegate>(GetMethodAddress("glTransformFeedbackBufferBase"));
	public delegate void glTransformFeedbackBufferBaseDelegate(GLuint xfb, GLuint index, GLuint buffer);

	public static readonly glTransformFeedbackBufferRangeDelegate glTransformFeedbackBufferRange = Marshal.GetDelegateForFunctionPointer<glTransformFeedbackBufferRangeDelegate>(GetMethodAddress("glTransformFeedbackBufferRange"));
	public delegate void glTransformFeedbackBufferRangeDelegate(GLuint xfb, GLuint index, GLuint buffer, GLintptr offset, GLsizei size);

	public static readonly glTransformFeedbackVaryingsDelegate glTransformFeedbackVaryings = Marshal.GetDelegateForFunctionPointer<glTransformFeedbackVaryingsDelegate>(GetMethodAddress("glTransformFeedbackVaryings"));
	public delegate void glTransformFeedbackVaryingsDelegate(GLuint program, GLsizei count, sbyte** varyings, GLenum bufferMode);

	public static readonly glUniform1fDelegate glUniform1f = Marshal.GetDelegateForFunctionPointer<glUniform1fDelegate>(GetMethodAddress("glUniform1f"));
	public delegate void glUniform1fDelegate(GLint location, GLfloat v0);

	public static readonly glUniform2fDelegate glUniform2f = Marshal.GetDelegateForFunctionPointer<glUniform2fDelegate>(GetMethodAddress("glUniform2f"));
	public delegate void glUniform2fDelegate(GLint location, GLfloat v0, GLfloat v1);

	public static readonly glUniform3fDelegate glUniform3f = Marshal.GetDelegateForFunctionPointer<glUniform3fDelegate>(GetMethodAddress("glUniform3f"));
	public delegate void glUniform3fDelegate(GLint location, GLfloat v0, GLfloat v1, GLfloat v2);

	public static readonly glUniform4fDelegate glUniform4f = Marshal.GetDelegateForFunctionPointer<glUniform4fDelegate>(GetMethodAddress("glUniform4f"));
	public delegate void glUniform4fDelegate(GLint location, GLfloat v0, GLfloat v1, GLfloat v2, GLfloat v3);

	public static readonly glUniform1iDelegate glUniform1i = Marshal.GetDelegateForFunctionPointer<glUniform1iDelegate>(GetMethodAddress("glUniform1i"));
	public delegate void glUniform1iDelegate(GLint location, GLint v0);

	public static readonly glUniform2iDelegate glUniform2i = Marshal.GetDelegateForFunctionPointer<glUniform2iDelegate>(GetMethodAddress("glUniform2i"));
	public delegate void glUniform2iDelegate(GLint location, GLint v0, GLint v1);

	public static readonly glUniform3iDelegate glUniform3i = Marshal.GetDelegateForFunctionPointer<glUniform3iDelegate>(GetMethodAddress("glUniform3i"));
	public delegate void glUniform3iDelegate(GLint location, GLint v0, GLint v1, GLint v2);

	public static readonly glUniform4iDelegate glUniform4i = Marshal.GetDelegateForFunctionPointer<glUniform4iDelegate>(GetMethodAddress("glUniform4i"));
	public delegate void glUniform4iDelegate(GLint location, GLint v0, GLint v1, GLint v2, GLint v3);

	public static readonly glUniform1uiDelegate glUniform1ui = Marshal.GetDelegateForFunctionPointer<glUniform1uiDelegate>(GetMethodAddress("glUniform1ui"));
	public delegate void glUniform1uiDelegate(GLint location, GLuint v0);

	public static readonly glUniform2uiDelegate glUniform2ui = Marshal.GetDelegateForFunctionPointer<glUniform2uiDelegate>(GetMethodAddress("glUniform2ui"));
	public delegate void glUniform2uiDelegate(GLint location, GLuint v0, GLuint v1);

	public static readonly glUniform3uiDelegate glUniform3ui = Marshal.GetDelegateForFunctionPointer<glUniform3uiDelegate>(GetMethodAddress("glUniform3ui"));
	public delegate void glUniform3uiDelegate(GLint location, GLuint v0, GLuint v1, GLuint v2);

	public static readonly glUniform4uiDelegate glUniform4ui = Marshal.GetDelegateForFunctionPointer<glUniform4uiDelegate>(GetMethodAddress("glUniform4ui"));
	public delegate void glUniform4uiDelegate(GLint location, GLuint v0, GLuint v1, GLuint v2, GLuint v3);

	public static readonly glUniform1fvDelegate glUniform1fv = Marshal.GetDelegateForFunctionPointer<glUniform1fvDelegate>(GetMethodAddress("glUniform1fv"));
	public delegate void glUniform1fvDelegate(GLint location, GLsizei count, ref GLfloat value);

	public static readonly glUniform2fvDelegate glUniform2fv = Marshal.GetDelegateForFunctionPointer<glUniform2fvDelegate>(GetMethodAddress("glUniform2fv"));
	public delegate void glUniform2fvDelegate(GLint location, GLsizei count, ref GLfloat value);

	public static readonly glUniform3fvDelegate glUniform3fv = Marshal.GetDelegateForFunctionPointer<glUniform3fvDelegate>(GetMethodAddress("glUniform3fv"));
	public delegate void glUniform3fvDelegate(GLint location, GLsizei count, ref GLfloat value);

	public static readonly glUniform4fvDelegate glUniform4fv = Marshal.GetDelegateForFunctionPointer<glUniform4fvDelegate>(GetMethodAddress("glUniform4fv"));
	public delegate void glUniform4fvDelegate(GLint location, GLsizei count, ref GLfloat value);

	public static readonly glUniform1ivDelegate glUniform1iv = Marshal.GetDelegateForFunctionPointer<glUniform1ivDelegate>(GetMethodAddress("glUniform1iv"));
	public delegate void glUniform1ivDelegate(GLint location, GLsizei count, ref GLint value);

	public static readonly glUniform2ivDelegate glUniform2iv = Marshal.GetDelegateForFunctionPointer<glUniform2ivDelegate>(GetMethodAddress("glUniform2iv"));
	public delegate void glUniform2ivDelegate(GLint location, GLsizei count, ref GLint value);

	public static readonly glUniform3ivDelegate glUniform3iv = Marshal.GetDelegateForFunctionPointer<glUniform3ivDelegate>(GetMethodAddress("glUniform3iv"));
	public delegate void glUniform3ivDelegate(GLint location, GLsizei count, ref GLint value);

	public static readonly glUniform4ivDelegate glUniform4iv = Marshal.GetDelegateForFunctionPointer<glUniform4ivDelegate>(GetMethodAddress("glUniform4iv"));
	public delegate void glUniform4ivDelegate(GLint location, GLsizei count, ref GLint value);

	public static readonly glUniform1uivDelegate glUniform1uiv = Marshal.GetDelegateForFunctionPointer<glUniform1uivDelegate>(GetMethodAddress("glUniform1uiv"));
	public delegate void glUniform1uivDelegate(GLint location, GLsizei count, ref GLuint value);

	public static readonly glUniform2uivDelegate glUniform2uiv = Marshal.GetDelegateForFunctionPointer<glUniform2uivDelegate>(GetMethodAddress("glUniform2uiv"));
	public delegate void glUniform2uivDelegate(GLint location, GLsizei count, ref GLuint value);

	public static readonly glUniform3uivDelegate glUniform3uiv = Marshal.GetDelegateForFunctionPointer<glUniform3uivDelegate>(GetMethodAddress("glUniform3uiv"));
	public delegate void glUniform3uivDelegate(GLint location, GLsizei count, ref GLuint value);

	public static readonly glUniform4uivDelegate glUniform4uiv = Marshal.GetDelegateForFunctionPointer<glUniform4uivDelegate>(GetMethodAddress("glUniform4uiv"));
	public delegate void glUniform4uivDelegate(GLint location, GLsizei count, ref GLuint value);

	public static readonly glUniformMatrix2fvDelegate glUniformMatrix2fv = Marshal.GetDelegateForFunctionPointer<glUniformMatrix2fvDelegate>(GetMethodAddress("glUniformMatrix2fv"));
	public delegate void glUniformMatrix2fvDelegate(GLint location, GLsizei count, GLboolean transpose, ref GLfloat value);

	public static readonly glUniformMatrix3fvDelegate glUniformMatrix3fv = Marshal.GetDelegateForFunctionPointer<glUniformMatrix3fvDelegate>(GetMethodAddress("glUniformMatrix3fv"));
	public delegate void glUniformMatrix3fvDelegate(GLint location, GLsizei count, GLboolean transpose, ref GLfloat value);

	public static readonly glUniformMatrix4fvDelegate glUniformMatrix4fv = Marshal.GetDelegateForFunctionPointer<glUniformMatrix4fvDelegate>(GetMethodAddress("glUniformMatrix4fv"));
	public delegate void glUniformMatrix4fvDelegate(GLint location, GLsizei count, GLboolean transpose, ref GLfloat value);

	public static readonly glUniformMatrix2x3fvDelegate glUniformMatrix2x3fv = Marshal.GetDelegateForFunctionPointer<glUniformMatrix2x3fvDelegate>(GetMethodAddress("glUniformMatrix2x3fv"));
	public delegate void glUniformMatrix2x3fvDelegate(GLint location, GLsizei count, GLboolean transpose, ref GLfloat value);

	public static readonly glUniformMatrix3x2fvDelegate glUniformMatrix3x2fv = Marshal.GetDelegateForFunctionPointer<glUniformMatrix3x2fvDelegate>(GetMethodAddress("glUniformMatrix3x2fv"));
	public delegate void glUniformMatrix3x2fvDelegate(GLint location, GLsizei count, GLboolean transpose, ref GLfloat value);

	public static readonly glUniformMatrix2x4fvDelegate glUniformMatrix2x4fv = Marshal.GetDelegateForFunctionPointer<glUniformMatrix2x4fvDelegate>(GetMethodAddress("glUniformMatrix2x4fv"));
	public delegate void glUniformMatrix2x4fvDelegate(GLint location, GLsizei count, GLboolean transpose, ref GLfloat value);

	public static readonly glUniformMatrix4x2fvDelegate glUniformMatrix4x2fv = Marshal.GetDelegateForFunctionPointer<glUniformMatrix4x2fvDelegate>(GetMethodAddress("glUniformMatrix4x2fv"));
	public delegate void glUniformMatrix4x2fvDelegate(GLint location, GLsizei count, GLboolean transpose, ref GLfloat value);

	public static readonly glUniformMatrix3x4fvDelegate glUniformMatrix3x4fv = Marshal.GetDelegateForFunctionPointer<glUniformMatrix3x4fvDelegate>(GetMethodAddress("glUniformMatrix3x4fv"));
	public delegate void glUniformMatrix3x4fvDelegate(GLint location, GLsizei count, GLboolean transpose, ref GLfloat value);

	public static readonly glUniformMatrix4x3fvDelegate glUniformMatrix4x3fv = Marshal.GetDelegateForFunctionPointer<glUniformMatrix4x3fvDelegate>(GetMethodAddress("glUniformMatrix4x3fv"));
	public delegate void glUniformMatrix4x3fvDelegate(GLint location, GLsizei count, GLboolean transpose, ref GLfloat value);

	public static readonly glUniformBlockBindingDelegate glUniformBlockBinding = Marshal.GetDelegateForFunctionPointer<glUniformBlockBindingDelegate>(GetMethodAddress("glUniformBlockBinding"));
	public delegate void glUniformBlockBindingDelegate(GLuint program, GLuint uniformBlockIndex, GLuint uniformBlockBinding);

	public static readonly glUniformSubroutinesuivDelegate glUniformSubroutinesuiv = Marshal.GetDelegateForFunctionPointer<glUniformSubroutinesuivDelegate>(GetMethodAddress("glUniformSubroutinesuiv"));
	public delegate void glUniformSubroutinesuivDelegate(GLenum shadertype, GLsizei count, GLuint* indices);

	public static readonly glUnmapBufferDelegate glUnmapBuffer = Marshal.GetDelegateForFunctionPointer<glUnmapBufferDelegate>(GetMethodAddress("glUnmapBuffer"));
	public delegate GLboolean glUnmapBufferDelegate(GLenum target);

	public static readonly glUnmapNamedBufferDelegate glUnmapNamedBuffer = Marshal.GetDelegateForFunctionPointer<glUnmapNamedBufferDelegate>(GetMethodAddress("glUnmapNamedBuffer"));
	public delegate GLboolean glUnmapNamedBufferDelegate(GLuint buffer);

	public static readonly glUseProgramDelegate glUseProgram = Marshal.GetDelegateForFunctionPointer<glUseProgramDelegate>(GetMethodAddress("glUseProgram"));
	public delegate void glUseProgramDelegate(GLuint program);

	public static readonly glUseProgramStagesDelegate glUseProgramStages = Marshal.GetDelegateForFunctionPointer<glUseProgramStagesDelegate>(GetMethodAddress("glUseProgramStages"));
	public delegate void glUseProgramStagesDelegate(GLuint pipeline, GLbitfield stages, GLuint program);

	public static readonly glValidateProgramDelegate glValidateProgram = Marshal.GetDelegateForFunctionPointer<glValidateProgramDelegate>(GetMethodAddress("glValidateProgram"));
	public delegate void glValidateProgramDelegate(GLuint program);

	public static readonly glValidateProgramPipelineDelegate glValidateProgramPipeline = Marshal.GetDelegateForFunctionPointer<glValidateProgramPipelineDelegate>(GetMethodAddress("glValidateProgramPipeline"));
	public delegate void glValidateProgramPipelineDelegate(GLuint pipeline);

	public static readonly glVertexArrayElementBufferDelegate glVertexArrayElementBuffer = Marshal.GetDelegateForFunctionPointer<glVertexArrayElementBufferDelegate>(GetMethodAddress("glVertexArrayElementBuffer"));
	public delegate void glVertexArrayElementBufferDelegate(GLuint vaobj, GLuint buffer);

	public static readonly glVertexAttrib1fDelegate glVertexAttrib1f = Marshal.GetDelegateForFunctionPointer<glVertexAttrib1fDelegate>(GetMethodAddress("glVertexAttrib1f"));
	public delegate void glVertexAttrib1fDelegate(GLuint index, GLfloat v0);

	public static readonly glVertexAttrib1sDelegate glVertexAttrib1s = Marshal.GetDelegateForFunctionPointer<glVertexAttrib1sDelegate>(GetMethodAddress("glVertexAttrib1s"));
	public delegate void glVertexAttrib1sDelegate(GLuint index, GLshort v0);

	public static readonly glVertexAttrib1dDelegate glVertexAttrib1d = Marshal.GetDelegateForFunctionPointer<glVertexAttrib1dDelegate>(GetMethodAddress("glVertexAttrib1d"));
	public delegate void glVertexAttrib1dDelegate(GLuint index, GLdouble v0);

	public static readonly glVertexAttribI1iDelegate glVertexAttribI1i = Marshal.GetDelegateForFunctionPointer<glVertexAttribI1iDelegate>(GetMethodAddress("glVertexAttribI1i"));
	public delegate void glVertexAttribI1iDelegate(GLuint index, GLint v0);

	public static readonly glVertexAttribI1uiDelegate glVertexAttribI1ui = Marshal.GetDelegateForFunctionPointer<glVertexAttribI1uiDelegate>(GetMethodAddress("glVertexAttribI1ui"));
	public delegate void glVertexAttribI1uiDelegate(GLuint index, GLuint v0);

	public static readonly glVertexAttrib2fDelegate glVertexAttrib2f = Marshal.GetDelegateForFunctionPointer<glVertexAttrib2fDelegate>(GetMethodAddress("glVertexAttrib2f"));
	public delegate void glVertexAttrib2fDelegate(GLuint index, GLfloat v0, GLfloat v1);

	public static readonly glVertexAttrib2sDelegate glVertexAttrib2s = Marshal.GetDelegateForFunctionPointer<glVertexAttrib2sDelegate>(GetMethodAddress("glVertexAttrib2s"));
	public delegate void glVertexAttrib2sDelegate(GLuint index, GLshort v0, GLshort v1);

	public static readonly glVertexAttrib2dDelegate glVertexAttrib2d = Marshal.GetDelegateForFunctionPointer<glVertexAttrib2dDelegate>(GetMethodAddress("glVertexAttrib2d"));
	public delegate void glVertexAttrib2dDelegate(GLuint index, GLdouble v0, GLdouble v1);

	public static readonly glVertexAttribI2iDelegate glVertexAttribI2i = Marshal.GetDelegateForFunctionPointer<glVertexAttribI2iDelegate>(GetMethodAddress("glVertexAttribI2i"));
	public delegate void glVertexAttribI2iDelegate(GLuint index, GLint v0, GLint v1);

	public static readonly glVertexAttribI2uiDelegate glVertexAttribI2ui = Marshal.GetDelegateForFunctionPointer<glVertexAttribI2uiDelegate>(GetMethodAddress("glVertexAttribI2ui"));
	public delegate void glVertexAttribI2uiDelegate(GLuint index, GLuint v0, GLuint v1);

	public static readonly glVertexAttrib3fDelegate glVertexAttrib3f = Marshal.GetDelegateForFunctionPointer<glVertexAttrib3fDelegate>(GetMethodAddress("glVertexAttrib3f"));
	public delegate void glVertexAttrib3fDelegate(GLuint index, GLfloat v0, GLfloat v1, GLfloat v2);

	public static readonly glVertexAttrib3sDelegate glVertexAttrib3s = Marshal.GetDelegateForFunctionPointer<glVertexAttrib3sDelegate>(GetMethodAddress("glVertexAttrib3s"));
	public delegate void glVertexAttrib3sDelegate(GLuint index, GLshort v0, GLshort v1, GLshort v2);

	public static readonly glVertexAttrib3dDelegate glVertexAttrib3d = Marshal.GetDelegateForFunctionPointer<glVertexAttrib3dDelegate>(GetMethodAddress("glVertexAttrib3d"));
	public delegate void glVertexAttrib3dDelegate(GLuint index, GLdouble v0, GLdouble v1, GLdouble v2);

	public static readonly glVertexAttribI3iDelegate glVertexAttribI3i = Marshal.GetDelegateForFunctionPointer<glVertexAttribI3iDelegate>(GetMethodAddress("glVertexAttribI3i"));
	public delegate void glVertexAttribI3iDelegate(GLuint index, GLint v0, GLint v1, GLint v2);

	public static readonly glVertexAttribI3uiDelegate glVertexAttribI3ui = Marshal.GetDelegateForFunctionPointer<glVertexAttribI3uiDelegate>(GetMethodAddress("glVertexAttribI3ui"));
	public delegate void glVertexAttribI3uiDelegate(GLuint index, GLuint v0, GLuint v1, GLuint v2);

	public static readonly glVertexAttrib4fDelegate glVertexAttrib4f = Marshal.GetDelegateForFunctionPointer<glVertexAttrib4fDelegate>(GetMethodAddress("glVertexAttrib4f"));
	public delegate void glVertexAttrib4fDelegate(GLuint index, GLfloat v0, GLfloat v1, GLfloat v2, GLfloat v3);

	public static readonly glVertexAttrib4sDelegate glVertexAttrib4s = Marshal.GetDelegateForFunctionPointer<glVertexAttrib4sDelegate>(GetMethodAddress("glVertexAttrib4s"));
	public delegate void glVertexAttrib4sDelegate(GLuint index, GLshort v0, GLshort v1, GLshort v2, GLshort v3);

	public static readonly glVertexAttrib4dDelegate glVertexAttrib4d = Marshal.GetDelegateForFunctionPointer<glVertexAttrib4dDelegate>(GetMethodAddress("glVertexAttrib4d"));
	public delegate void glVertexAttrib4dDelegate(GLuint index, GLdouble v0, GLdouble v1, GLdouble v2, GLdouble v3);

	public static readonly glVertexAttrib4NubDelegate glVertexAttrib4Nub = Marshal.GetDelegateForFunctionPointer<glVertexAttrib4NubDelegate>(GetMethodAddress("glVertexAttrib4Nub"));
	public delegate void glVertexAttrib4NubDelegate(GLuint index, GLubyte v0, GLubyte v1, GLubyte v2, GLubyte v3);

	public static readonly glVertexAttribI4iDelegate glVertexAttribI4i = Marshal.GetDelegateForFunctionPointer<glVertexAttribI4iDelegate>(GetMethodAddress("glVertexAttribI4i"));
	public delegate void glVertexAttribI4iDelegate(GLuint index, GLint v0, GLint v1, GLint v2, GLint v3);

	public static readonly glVertexAttribI4uiDelegate glVertexAttribI4ui = Marshal.GetDelegateForFunctionPointer<glVertexAttribI4uiDelegate>(GetMethodAddress("glVertexAttribI4ui"));
	public delegate void glVertexAttribI4uiDelegate(GLuint index, GLuint v0, GLuint v1, GLuint v2, GLuint v3);

	public static readonly glVertexAttribL1dDelegate glVertexAttribL1d = Marshal.GetDelegateForFunctionPointer<glVertexAttribL1dDelegate>(GetMethodAddress("glVertexAttribL1d"));
	public delegate void glVertexAttribL1dDelegate(GLuint index, GLdouble v0);

	public static readonly glVertexAttribL2dDelegate glVertexAttribL2d = Marshal.GetDelegateForFunctionPointer<glVertexAttribL2dDelegate>(GetMethodAddress("glVertexAttribL2d"));
	public delegate void glVertexAttribL2dDelegate(GLuint index, GLdouble v0, GLdouble v1);

	public static readonly glVertexAttribL3dDelegate glVertexAttribL3d = Marshal.GetDelegateForFunctionPointer<glVertexAttribL3dDelegate>(GetMethodAddress("glVertexAttribL3d"));
	public delegate void glVertexAttribL3dDelegate(GLuint index, GLdouble v0, GLdouble v1, GLdouble v2);

	public static readonly glVertexAttribL4dDelegate glVertexAttribL4d = Marshal.GetDelegateForFunctionPointer<glVertexAttribL4dDelegate>(GetMethodAddress("glVertexAttribL4d"));
	public delegate void glVertexAttribL4dDelegate(GLuint index, GLdouble v0, GLdouble v1, GLdouble v2, GLdouble v3);

	public static readonly glVertexAttrib1fvDelegate glVertexAttrib1fv = Marshal.GetDelegateForFunctionPointer<glVertexAttrib1fvDelegate>(GetMethodAddress("glVertexAttrib1fv"));
	public delegate void glVertexAttrib1fvDelegate(GLuint index, GLfloat* v);

	public static readonly glVertexAttrib1svDelegate glVertexAttrib1sv = Marshal.GetDelegateForFunctionPointer<glVertexAttrib1svDelegate>(GetMethodAddress("glVertexAttrib1sv"));
	public delegate void glVertexAttrib1svDelegate(GLuint index, GLshort* v);

	public static readonly glVertexAttrib1dvDelegate glVertexAttrib1dv = Marshal.GetDelegateForFunctionPointer<glVertexAttrib1dvDelegate>(GetMethodAddress("glVertexAttrib1dv"));
	public delegate void glVertexAttrib1dvDelegate(GLuint index, GLdouble* v);

	public static readonly glVertexAttribI1ivDelegate glVertexAttribI1iv = Marshal.GetDelegateForFunctionPointer<glVertexAttribI1ivDelegate>(GetMethodAddress("glVertexAttribI1iv"));
	public delegate void glVertexAttribI1ivDelegate(GLuint index, GLint* v);

	public static readonly glVertexAttribI1uivDelegate glVertexAttribI1uiv = Marshal.GetDelegateForFunctionPointer<glVertexAttribI1uivDelegate>(GetMethodAddress("glVertexAttribI1uiv"));
	public delegate void glVertexAttribI1uivDelegate(GLuint index, GLuint* v);

	public static readonly glVertexAttrib2fvDelegate glVertexAttrib2fv = Marshal.GetDelegateForFunctionPointer<glVertexAttrib2fvDelegate>(GetMethodAddress("glVertexAttrib2fv"));
	public delegate void glVertexAttrib2fvDelegate(GLuint index, GLfloat* v);

	public static readonly glVertexAttrib2svDelegate glVertexAttrib2sv = Marshal.GetDelegateForFunctionPointer<glVertexAttrib2svDelegate>(GetMethodAddress("glVertexAttrib2sv"));
	public delegate void glVertexAttrib2svDelegate(GLuint index, GLshort* v);

	public static readonly glVertexAttrib2dvDelegate glVertexAttrib2dv = Marshal.GetDelegateForFunctionPointer<glVertexAttrib2dvDelegate>(GetMethodAddress("glVertexAttrib2dv"));
	public delegate void glVertexAttrib2dvDelegate(GLuint index, GLdouble* v);

	public static readonly glVertexAttribI2ivDelegate glVertexAttribI2iv = Marshal.GetDelegateForFunctionPointer<glVertexAttribI2ivDelegate>(GetMethodAddress("glVertexAttribI2iv"));
	public delegate void glVertexAttribI2ivDelegate(GLuint index, GLint* v);

	public static readonly glVertexAttribI2uivDelegate glVertexAttribI2uiv = Marshal.GetDelegateForFunctionPointer<glVertexAttribI2uivDelegate>(GetMethodAddress("glVertexAttribI2uiv"));
	public delegate void glVertexAttribI2uivDelegate(GLuint index, GLuint* v);

	public static readonly glVertexAttrib3fvDelegate glVertexAttrib3fv = Marshal.GetDelegateForFunctionPointer<glVertexAttrib3fvDelegate>(GetMethodAddress("glVertexAttrib3fv"));
	public delegate void glVertexAttrib3fvDelegate(GLuint index, GLfloat* v);

	public static readonly glVertexAttrib3svDelegate glVertexAttrib3sv = Marshal.GetDelegateForFunctionPointer<glVertexAttrib3svDelegate>(GetMethodAddress("glVertexAttrib3sv"));
	public delegate void glVertexAttrib3svDelegate(GLuint index, GLshort* v);

	public static readonly glVertexAttrib3dvDelegate glVertexAttrib3dv = Marshal.GetDelegateForFunctionPointer<glVertexAttrib3dvDelegate>(GetMethodAddress("glVertexAttrib3dv"));
	public delegate void glVertexAttrib3dvDelegate(GLuint index, GLdouble* v);

	public static readonly glVertexAttribI3ivDelegate glVertexAttribI3iv = Marshal.GetDelegateForFunctionPointer<glVertexAttribI3ivDelegate>(GetMethodAddress("glVertexAttribI3iv"));
	public delegate void glVertexAttribI3ivDelegate(GLuint index, GLint* v);

	public static readonly glVertexAttribI3uivDelegate glVertexAttribI3uiv = Marshal.GetDelegateForFunctionPointer<glVertexAttribI3uivDelegate>(GetMethodAddress("glVertexAttribI3uiv"));
	public delegate void glVertexAttribI3uivDelegate(GLuint index, GLuint* v);

	public static readonly glVertexAttrib4fvDelegate glVertexAttrib4fv = Marshal.GetDelegateForFunctionPointer<glVertexAttrib4fvDelegate>(GetMethodAddress("glVertexAttrib4fv"));
	public delegate void glVertexAttrib4fvDelegate(GLuint index, GLfloat* v);

	public static readonly glVertexAttrib4svDelegate glVertexAttrib4sv = Marshal.GetDelegateForFunctionPointer<glVertexAttrib4svDelegate>(GetMethodAddress("glVertexAttrib4sv"));
	public delegate void glVertexAttrib4svDelegate(GLuint index, GLshort* v);

	public static readonly glVertexAttrib4dvDelegate glVertexAttrib4dv = Marshal.GetDelegateForFunctionPointer<glVertexAttrib4dvDelegate>(GetMethodAddress("glVertexAttrib4dv"));
	public delegate void glVertexAttrib4dvDelegate(GLuint index, GLdouble* v);

	public static readonly glVertexAttrib4ivDelegate glVertexAttrib4iv = Marshal.GetDelegateForFunctionPointer<glVertexAttrib4ivDelegate>(GetMethodAddress("glVertexAttrib4iv"));
	public delegate void glVertexAttrib4ivDelegate(GLuint index, GLint* v);

	public static readonly glVertexAttrib4bvDelegate glVertexAttrib4bv = Marshal.GetDelegateForFunctionPointer<glVertexAttrib4bvDelegate>(GetMethodAddress("glVertexAttrib4bv"));
	public delegate void glVertexAttrib4bvDelegate(GLuint index, GLbyte* v);

	public static readonly glVertexAttrib4ubvDelegate glVertexAttrib4ubv = Marshal.GetDelegateForFunctionPointer<glVertexAttrib4ubvDelegate>(GetMethodAddress("glVertexAttrib4ubv"));
	public delegate void glVertexAttrib4ubvDelegate(GLuint index, GLubyte* v);

	public static readonly glVertexAttrib4usvDelegate glVertexAttrib4usv = Marshal.GetDelegateForFunctionPointer<glVertexAttrib4usvDelegate>(GetMethodAddress("glVertexAttrib4usv"));
	public delegate void glVertexAttrib4usvDelegate(GLuint index, GLushort* v);

	public static readonly glVertexAttrib4uivDelegate glVertexAttrib4uiv = Marshal.GetDelegateForFunctionPointer<glVertexAttrib4uivDelegate>(GetMethodAddress("glVertexAttrib4uiv"));
	public delegate void glVertexAttrib4uivDelegate(GLuint index, GLuint* v);

	public static readonly glVertexAttrib4NbvDelegate glVertexAttrib4Nbv = Marshal.GetDelegateForFunctionPointer<glVertexAttrib4NbvDelegate>(GetMethodAddress("glVertexAttrib4Nbv"));
	public delegate void glVertexAttrib4NbvDelegate(GLuint index, GLbyte* v);

	public static readonly glVertexAttrib4NsvDelegate glVertexAttrib4Nsv = Marshal.GetDelegateForFunctionPointer<glVertexAttrib4NsvDelegate>(GetMethodAddress("glVertexAttrib4Nsv"));
	public delegate void glVertexAttrib4NsvDelegate(GLuint index, GLshort* v);

	public static readonly glVertexAttrib4NivDelegate glVertexAttrib4Niv = Marshal.GetDelegateForFunctionPointer<glVertexAttrib4NivDelegate>(GetMethodAddress("glVertexAttrib4Niv"));
	public delegate void glVertexAttrib4NivDelegate(GLuint index, GLint* v);

	public static readonly glVertexAttrib4NubvDelegate glVertexAttrib4Nubv = Marshal.GetDelegateForFunctionPointer<glVertexAttrib4NubvDelegate>(GetMethodAddress("glVertexAttrib4Nubv"));
	public delegate void glVertexAttrib4NubvDelegate(GLuint index, GLubyte* v);

	public static readonly glVertexAttrib4NusvDelegate glVertexAttrib4Nusv = Marshal.GetDelegateForFunctionPointer<glVertexAttrib4NusvDelegate>(GetMethodAddress("glVertexAttrib4Nusv"));
	public delegate void glVertexAttrib4NusvDelegate(GLuint index, GLushort* v);

	public static readonly glVertexAttrib4NuivDelegate glVertexAttrib4Nuiv = Marshal.GetDelegateForFunctionPointer<glVertexAttrib4NuivDelegate>(GetMethodAddress("glVertexAttrib4Nuiv"));
	public delegate void glVertexAttrib4NuivDelegate(GLuint index, GLuint* v);

	public static readonly glVertexAttribI4bvDelegate glVertexAttribI4bv = Marshal.GetDelegateForFunctionPointer<glVertexAttribI4bvDelegate>(GetMethodAddress("glVertexAttribI4bv"));
	public delegate void glVertexAttribI4bvDelegate(GLuint index, GLbyte* v);

	public static readonly glVertexAttribI4ubvDelegate glVertexAttribI4ubv = Marshal.GetDelegateForFunctionPointer<glVertexAttribI4ubvDelegate>(GetMethodAddress("glVertexAttribI4ubv"));
	public delegate void glVertexAttribI4ubvDelegate(GLuint index, GLubyte* v);

	public static readonly glVertexAttribI4svDelegate glVertexAttribI4sv = Marshal.GetDelegateForFunctionPointer<glVertexAttribI4svDelegate>(GetMethodAddress("glVertexAttribI4sv"));
	public delegate void glVertexAttribI4svDelegate(GLuint index, GLshort* v);

	public static readonly glVertexAttribI4usvDelegate glVertexAttribI4usv = Marshal.GetDelegateForFunctionPointer<glVertexAttribI4usvDelegate>(GetMethodAddress("glVertexAttribI4usv"));
	public delegate void glVertexAttribI4usvDelegate(GLuint index, GLushort* v);

	public static readonly glVertexAttribI4ivDelegate glVertexAttribI4iv = Marshal.GetDelegateForFunctionPointer<glVertexAttribI4ivDelegate>(GetMethodAddress("glVertexAttribI4iv"));
	public delegate void glVertexAttribI4ivDelegate(GLuint index, GLint* v);

	public static readonly glVertexAttribI4uivDelegate glVertexAttribI4uiv = Marshal.GetDelegateForFunctionPointer<glVertexAttribI4uivDelegate>(GetMethodAddress("glVertexAttribI4uiv"));
	public delegate void glVertexAttribI4uivDelegate(GLuint index, GLuint* v);

	public static readonly glVertexAttribL1dvDelegate glVertexAttribL1dv = Marshal.GetDelegateForFunctionPointer<glVertexAttribL1dvDelegate>(GetMethodAddress("glVertexAttribL1dv"));
	public delegate void glVertexAttribL1dvDelegate(GLuint index, GLdouble* v);

	public static readonly glVertexAttribL2dvDelegate glVertexAttribL2dv = Marshal.GetDelegateForFunctionPointer<glVertexAttribL2dvDelegate>(GetMethodAddress("glVertexAttribL2dv"));
	public delegate void glVertexAttribL2dvDelegate(GLuint index, GLdouble* v);

	public static readonly glVertexAttribL3dvDelegate glVertexAttribL3dv = Marshal.GetDelegateForFunctionPointer<glVertexAttribL3dvDelegate>(GetMethodAddress("glVertexAttribL3dv"));
	public delegate void glVertexAttribL3dvDelegate(GLuint index, GLdouble* v);

	public static readonly glVertexAttribL4dvDelegate glVertexAttribL4dv = Marshal.GetDelegateForFunctionPointer<glVertexAttribL4dvDelegate>(GetMethodAddress("glVertexAttribL4dv"));
	public delegate void glVertexAttribL4dvDelegate(GLuint index, GLdouble* v);

	public static readonly glVertexAttribP1uiDelegate glVertexAttribP1ui = Marshal.GetDelegateForFunctionPointer<glVertexAttribP1uiDelegate>(GetMethodAddress("glVertexAttribP1ui"));
	public delegate void glVertexAttribP1uiDelegate(GLuint index, GLenum type, GLboolean normalized, GLuint value);

	public static readonly glVertexAttribP2uiDelegate glVertexAttribP2ui = Marshal.GetDelegateForFunctionPointer<glVertexAttribP2uiDelegate>(GetMethodAddress("glVertexAttribP2ui"));
	public delegate void glVertexAttribP2uiDelegate(GLuint index, GLenum type, GLboolean normalized, GLuint value);

	public static readonly glVertexAttribP3uiDelegate glVertexAttribP3ui = Marshal.GetDelegateForFunctionPointer<glVertexAttribP3uiDelegate>(GetMethodAddress("glVertexAttribP3ui"));
	public delegate void glVertexAttribP3uiDelegate(GLuint index, GLenum type, GLboolean normalized, GLuint value);

	public static readonly glVertexAttribP4uiDelegate glVertexAttribP4ui = Marshal.GetDelegateForFunctionPointer<glVertexAttribP4uiDelegate>(GetMethodAddress("glVertexAttribP4ui"));
	public delegate void glVertexAttribP4uiDelegate(GLuint index, GLenum type, GLboolean normalized, GLuint value);

	public static readonly glVertexAttribBindingDelegate glVertexAttribBinding = Marshal.GetDelegateForFunctionPointer<glVertexAttribBindingDelegate>(GetMethodAddress("glVertexAttribBinding"));
	public delegate void glVertexAttribBindingDelegate(GLuint attribindex, GLuint bindingindex);

	public static readonly glVertexArrayAttribBindingDelegate glVertexArrayAttribBinding = Marshal.GetDelegateForFunctionPointer<glVertexArrayAttribBindingDelegate>(GetMethodAddress("glVertexArrayAttribBinding"));
	public delegate void glVertexArrayAttribBindingDelegate(GLuint vaobj, GLuint attribindex, GLuint bindingindex);

	public static readonly glVertexAttribDivisorDelegate glVertexAttribDivisor = Marshal.GetDelegateForFunctionPointer<glVertexAttribDivisorDelegate>(GetMethodAddress("glVertexAttribDivisor"));
	public delegate void glVertexAttribDivisorDelegate(GLuint index, GLuint divisor);

	public static readonly glVertexAttribFormatDelegate glVertexAttribFormat = Marshal.GetDelegateForFunctionPointer<glVertexAttribFormatDelegate>(GetMethodAddress("glVertexAttribFormat"));
	public delegate void glVertexAttribFormatDelegate(GLuint attribindex, GLint size, GLenum type, GLboolean normalized, GLuint relativeoffset);

	public static readonly glVertexAttribIFormatDelegate glVertexAttribIFormat = Marshal.GetDelegateForFunctionPointer<glVertexAttribIFormatDelegate>(GetMethodAddress("glVertexAttribIFormat"));
	public delegate void glVertexAttribIFormatDelegate(GLuint attribindex, GLint size, GLenum type, GLuint relativeoffset);

	public static readonly glVertexAttribLFormatDelegate glVertexAttribLFormat = Marshal.GetDelegateForFunctionPointer<glVertexAttribLFormatDelegate>(GetMethodAddress("glVertexAttribLFormat"));
	public delegate void glVertexAttribLFormatDelegate(GLuint attribindex, GLint size, GLenum type, GLuint relativeoffset);

	public static readonly glVertexArrayAttribFormatDelegate glVertexArrayAttribFormat = Marshal.GetDelegateForFunctionPointer<glVertexArrayAttribFormatDelegate>(GetMethodAddress("glVertexArrayAttribFormat"));
	public delegate void glVertexArrayAttribFormatDelegate(GLuint vaobj, GLuint attribindex, GLint size, GLenum type, GLboolean normalized, GLuint relativeoffset);

	public static readonly glVertexArrayAttribIFormatDelegate glVertexArrayAttribIFormat = Marshal.GetDelegateForFunctionPointer<glVertexArrayAttribIFormatDelegate>(GetMethodAddress("glVertexArrayAttribIFormat"));
	public delegate void glVertexArrayAttribIFormatDelegate(GLuint vaobj, GLuint attribindex, GLint size, GLenum type, GLuint relativeoffset);

	public static readonly glVertexArrayAttribLFormatDelegate glVertexArrayAttribLFormat = Marshal.GetDelegateForFunctionPointer<glVertexArrayAttribLFormatDelegate>(GetMethodAddress("glVertexArrayAttribLFormat"));
	public delegate void glVertexArrayAttribLFormatDelegate(GLuint vaobj, GLuint attribindex, GLint size, GLenum type, GLuint relativeoffset);

	public static readonly glVertexAttribPointerDelegate glVertexAttribPointer = Marshal.GetDelegateForFunctionPointer<glVertexAttribPointerDelegate>(GetMethodAddress("glVertexAttribPointer"));
	public delegate void glVertexAttribPointerDelegate(GLuint index, GLint size, GLenum type, GLboolean normalized, GLsizei stride, nint pointer);

	public static readonly glVertexAttribIPointerDelegate glVertexAttribIPointer = Marshal.GetDelegateForFunctionPointer<glVertexAttribIPointerDelegate>(GetMethodAddress("glVertexAttribIPointer"));
	public delegate void glVertexAttribIPointerDelegate(GLuint index, GLint size, GLenum type, GLsizei stride, nint pointer);

	public static readonly glVertexAttribLPointerDelegate glVertexAttribLPointer = Marshal.GetDelegateForFunctionPointer<glVertexAttribLPointerDelegate>(GetMethodAddress("glVertexAttribLPointer"));
	public delegate void glVertexAttribLPointerDelegate(GLuint index, GLint size, GLenum type, GLsizei stride, nint pointer);

	public static readonly glVertexBindingDivisorDelegate glVertexBindingDivisor = Marshal.GetDelegateForFunctionPointer<glVertexBindingDivisorDelegate>(GetMethodAddress("glVertexBindingDivisor"));
	public delegate void glVertexBindingDivisorDelegate(GLuint bindingindex, GLuint divisor);

	public static readonly glVertexArrayBindingDivisorDelegate glVertexArrayBindingDivisor = Marshal.GetDelegateForFunctionPointer<glVertexArrayBindingDivisorDelegate>(GetMethodAddress("glVertexArrayBindingDivisor"));
	public delegate void glVertexArrayBindingDivisorDelegate(GLuint vaobj, GLuint bindingindex, GLuint divisor);

	// public static readonly glViewportDelegate glViewport = Marshal.GetDelegateForFunctionPointer<glViewportDelegate>(GetMethodAddress("glViewport"));
	// public delegate void glViewportDelegate(GLint x, GLint y, GLsizei width, GLsizei height);

	public static readonly glViewportArrayvDelegate glViewportArrayv = Marshal.GetDelegateForFunctionPointer<glViewportArrayvDelegate>(GetMethodAddress("glViewportArrayv"));
	public delegate void glViewportArrayvDelegate(GLuint first, GLsizei count, GLfloat* v);

	public static readonly glViewportIndexedfDelegate glViewportIndexedf = Marshal.GetDelegateForFunctionPointer<glViewportIndexedfDelegate>(GetMethodAddress("glViewportIndexedf"));
	public delegate void glViewportIndexedfDelegate(GLuint index, GLfloat x, GLfloat y, GLfloat w, GLfloat h);

	public static readonly glViewportIndexedfvDelegate glViewportIndexedfv = Marshal.GetDelegateForFunctionPointer<glViewportIndexedfvDelegate>(GetMethodAddress("glViewportIndexedfv"));
	public delegate void glViewportIndexedfvDelegate(GLuint index, GLfloat* v);

	public static readonly glWaitSyncDelegate glWaitSync = Marshal.GetDelegateForFunctionPointer<glWaitSyncDelegate>(GetMethodAddress("glWaitSync"));
	public delegate void glWaitSyncDelegate(GLsync sync, GLbitfield flags, GLuint64 timeout);
}
