// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using HexaGen.Runtime;
using System.Numerics;

namespace Hexa.NET.ImGui
{
	#if NET5_0_OR_GREATER
	/// <summary>
	/// To be documented.
	/// </summary>
	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public unsafe delegate void UserCallback([NativeName(NativeNameType.Param, "parent_list")] [NativeName(NativeNameType.Type, "const ImDrawList*")] ImDrawList* parentList, [NativeName(NativeNameType.Param, "cmd")] [NativeName(NativeNameType.Type, "const ImDrawCmd*")] ImDrawCmd* cmd);

	#else
	/// <summary>
	/// To be documented.
	/// </summary>
	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public unsafe delegate void UserCallback([NativeName(NativeNameType.Param, "parent_list")] [NativeName(NativeNameType.Type, "const ImDrawList*")] nint parentList, [NativeName(NativeNameType.Param, "cmd")] [NativeName(NativeNameType.Type, "const ImDrawCmd*")] nint cmd);

	#endif

	#if NET5_0_OR_GREATER
	/// <summary>
	/// To be documented.
	/// </summary>
	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public unsafe delegate byte FontBuilderBuild([NativeName(NativeNameType.Param, "atlas")] [NativeName(NativeNameType.Type, "ImFontAtlas*")] ImFontAtlas* atlas);

	#else
	/// <summary>
	/// To be documented.
	/// </summary>
	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public unsafe delegate byte FontBuilderBuild([NativeName(NativeNameType.Param, "atlas")] [NativeName(NativeNameType.Type, "ImFontAtlas*")] nint atlas);

	#endif

	#if NET5_0_OR_GREATER
	/// <summary>
	/// To be documented.
	/// </summary>
	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public unsafe delegate void DockNodeWindowMenuHandler([NativeName(NativeNameType.Param, "ctx")] [NativeName(NativeNameType.Type, "ImGuiContext*")] ImGuiContext* ctx, [NativeName(NativeNameType.Param, "node")] [NativeName(NativeNameType.Type, "ImGuiDockNode*")] ImGuiDockNode* node, [NativeName(NativeNameType.Param, "tab_bar")] [NativeName(NativeNameType.Type, "ImGuiTabBar*")] ImGuiTabBar* tabBar);

	#else
	/// <summary>
	/// To be documented.
	/// </summary>
	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public unsafe delegate void DockNodeWindowMenuHandler([NativeName(NativeNameType.Param, "ctx")] [NativeName(NativeNameType.Type, "ImGuiContext*")] nint ctx, [NativeName(NativeNameType.Param, "node")] [NativeName(NativeNameType.Type, "ImGuiDockNode*")] nint node, [NativeName(NativeNameType.Param, "tab_bar")] [NativeName(NativeNameType.Type, "ImGuiTabBar*")] nint tabBar);

	#endif

	#if NET5_0_OR_GREATER
	/// <summary>
	/// To be documented.
	/// </summary>
	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public unsafe delegate byte* PlatformGetClipboardTextFn([NativeName(NativeNameType.Param, "ctx")] [NativeName(NativeNameType.Type, "ImGuiContext*")] ImGuiContext* ctx);

	#else
	/// <summary>
	/// To be documented.
	/// </summary>
	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public unsafe delegate nint PlatformGetClipboardTextFn([NativeName(NativeNameType.Param, "ctx")] [NativeName(NativeNameType.Type, "ImGuiContext*")] nint ctx);

	#endif

	#if NET5_0_OR_GREATER
	/// <summary>
	/// To be documented.
	/// </summary>
	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public unsafe delegate void PlatformSetClipboardTextFn([NativeName(NativeNameType.Param, "ctx")] [NativeName(NativeNameType.Type, "ImGuiContext*")] ImGuiContext* ctx, [NativeName(NativeNameType.Param, "text")] [NativeName(NativeNameType.Type, "const char*")] byte* text);

	#else
	/// <summary>
	/// To be documented.
	/// </summary>
	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public unsafe delegate void PlatformSetClipboardTextFn([NativeName(NativeNameType.Param, "ctx")] [NativeName(NativeNameType.Type, "ImGuiContext*")] nint ctx, [NativeName(NativeNameType.Param, "text")] [NativeName(NativeNameType.Type, "const char*")] nint text);

	#endif

	#if NET5_0_OR_GREATER
	/// <summary>
	/// To be documented.
	/// </summary>
	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public unsafe delegate byte PlatformOpenInShellFn([NativeName(NativeNameType.Param, "ctx")] [NativeName(NativeNameType.Type, "ImGuiContext*")] ImGuiContext* ctx, [NativeName(NativeNameType.Param, "path")] [NativeName(NativeNameType.Type, "const char*")] byte* path);

	#else
	/// <summary>
	/// To be documented.
	/// </summary>
	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public unsafe delegate byte PlatformOpenInShellFn([NativeName(NativeNameType.Param, "ctx")] [NativeName(NativeNameType.Type, "ImGuiContext*")] nint ctx, [NativeName(NativeNameType.Param, "path")] [NativeName(NativeNameType.Type, "const char*")] nint path);

	#endif

	#if NET5_0_OR_GREATER
	/// <summary>
	/// To be documented.
	/// </summary>
	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public unsafe delegate void PlatformSetImeDataFn([NativeName(NativeNameType.Param, "ctx")] [NativeName(NativeNameType.Type, "ImGuiContext*")] ImGuiContext* ctx, [NativeName(NativeNameType.Param, "viewport")] [NativeName(NativeNameType.Type, "ImGuiViewport*")] ImGuiViewport* viewport, [NativeName(NativeNameType.Param, "data")] [NativeName(NativeNameType.Type, "ImGuiPlatformImeData*")] ImGuiPlatformImeData* data);

	#else
	/// <summary>
	/// To be documented.
	/// </summary>
	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public unsafe delegate void PlatformSetImeDataFn([NativeName(NativeNameType.Param, "ctx")] [NativeName(NativeNameType.Type, "ImGuiContext*")] nint ctx, [NativeName(NativeNameType.Param, "viewport")] [NativeName(NativeNameType.Type, "ImGuiViewport*")] nint viewport, [NativeName(NativeNameType.Param, "data")] [NativeName(NativeNameType.Type, "ImGuiPlatformImeData*")] nint data);

	#endif

	#if NET5_0_OR_GREATER
	/// <summary>
	/// To be documented.
	/// </summary>
	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public unsafe delegate void PlatformCreateWindow([NativeName(NativeNameType.Param, "vp")] [NativeName(NativeNameType.Type, "ImGuiViewport*")] ImGuiViewport* vp);

	#else
	/// <summary>
	/// To be documented.
	/// </summary>
	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public unsafe delegate void PlatformCreateWindow([NativeName(NativeNameType.Param, "vp")] [NativeName(NativeNameType.Type, "ImGuiViewport*")] nint vp);

	#endif

	#if NET5_0_OR_GREATER
	/// <summary>
	/// To be documented.
	/// </summary>
	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public unsafe delegate void PlatformDestroyWindow([NativeName(NativeNameType.Param, "vp")] [NativeName(NativeNameType.Type, "ImGuiViewport*")] ImGuiViewport* vp);

	#else
	/// <summary>
	/// To be documented.
	/// </summary>
	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public unsafe delegate void PlatformDestroyWindow([NativeName(NativeNameType.Param, "vp")] [NativeName(NativeNameType.Type, "ImGuiViewport*")] nint vp);

	#endif

	#if NET5_0_OR_GREATER
	/// <summary>
	/// To be documented.
	/// </summary>
	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public unsafe delegate void PlatformShowWindow([NativeName(NativeNameType.Param, "vp")] [NativeName(NativeNameType.Type, "ImGuiViewport*")] ImGuiViewport* vp);

	#else
	/// <summary>
	/// To be documented.
	/// </summary>
	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public unsafe delegate void PlatformShowWindow([NativeName(NativeNameType.Param, "vp")] [NativeName(NativeNameType.Type, "ImGuiViewport*")] nint vp);

	#endif

	#if NET5_0_OR_GREATER
	/// <summary>
	/// To be documented.
	/// </summary>
	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public unsafe delegate void PlatformSetWindowPos([NativeName(NativeNameType.Param, "vp")] [NativeName(NativeNameType.Type, "ImGuiViewport*")] ImGuiViewport* vp, [NativeName(NativeNameType.Param, "pos")] [NativeName(NativeNameType.Type, "ImVec2")] Vector2 pos);

	#else
	/// <summary>
	/// To be documented.
	/// </summary>
	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public unsafe delegate void PlatformSetWindowPos([NativeName(NativeNameType.Param, "vp")] [NativeName(NativeNameType.Type, "ImGuiViewport*")] nint vp, [NativeName(NativeNameType.Param, "pos")] [NativeName(NativeNameType.Type, "ImVec2")] Vector2 pos);

	#endif

	#if NET5_0_OR_GREATER
	/// <summary>
	/// To be documented.
	/// </summary>
	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public unsafe delegate Vector2* PlatformGetWindowPos(Vector2* pos, ImGuiViewport* viewport);

	#else
	/// <summary>
	/// To be documented.
	/// </summary>
	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public unsafe delegate Vector2* PlatformGetWindowPos(Vector2* pos, ImGuiViewport* viewport);

	#endif

	#if NET5_0_OR_GREATER
	/// <summary>
	/// To be documented.
	/// </summary>
	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public unsafe delegate void PlatformSetWindowSize([NativeName(NativeNameType.Param, "vp")] [NativeName(NativeNameType.Type, "ImGuiViewport*")] ImGuiViewport* vp, [NativeName(NativeNameType.Param, "size")] [NativeName(NativeNameType.Type, "ImVec2")] Vector2 size);

	#else
	/// <summary>
	/// To be documented.
	/// </summary>
	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public unsafe delegate void PlatformSetWindowSize([NativeName(NativeNameType.Param, "vp")] [NativeName(NativeNameType.Type, "ImGuiViewport*")] nint vp, [NativeName(NativeNameType.Param, "size")] [NativeName(NativeNameType.Type, "ImVec2")] Vector2 size);

	#endif

	#if NET5_0_OR_GREATER
	/// <summary>
	/// To be documented.
	/// </summary>
	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public unsafe delegate Vector2* PlatformGetWindowSize(Vector2* size, ImGuiViewport* viewport);

	#else
	/// <summary>
	/// To be documented.
	/// </summary>
	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public unsafe delegate Vector2* PlatformGetWindowSize(Vector2* size, ImGuiViewport* viewport);

	#endif

	#if NET5_0_OR_GREATER
	/// <summary>
	/// To be documented.
	/// </summary>
	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public unsafe delegate void PlatformSetWindowFocus([NativeName(NativeNameType.Param, "vp")] [NativeName(NativeNameType.Type, "ImGuiViewport*")] ImGuiViewport* vp);

	#else
	/// <summary>
	/// To be documented.
	/// </summary>
	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public unsafe delegate void PlatformSetWindowFocus([NativeName(NativeNameType.Param, "vp")] [NativeName(NativeNameType.Type, "ImGuiViewport*")] nint vp);

	#endif

	#if NET5_0_OR_GREATER
	/// <summary>
	/// To be documented.
	/// </summary>
	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public unsafe delegate byte PlatformGetWindowFocus([NativeName(NativeNameType.Param, "vp")] [NativeName(NativeNameType.Type, "ImGuiViewport*")] ImGuiViewport* vp);

	#else
	/// <summary>
	/// To be documented.
	/// </summary>
	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public unsafe delegate byte PlatformGetWindowFocus([NativeName(NativeNameType.Param, "vp")] [NativeName(NativeNameType.Type, "ImGuiViewport*")] nint vp);

	#endif

	#if NET5_0_OR_GREATER
	/// <summary>
	/// To be documented.
	/// </summary>
	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public unsafe delegate byte PlatformGetWindowMinimized([NativeName(NativeNameType.Param, "vp")] [NativeName(NativeNameType.Type, "ImGuiViewport*")] ImGuiViewport* vp);

	#else
	/// <summary>
	/// To be documented.
	/// </summary>
	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public unsafe delegate byte PlatformGetWindowMinimized([NativeName(NativeNameType.Param, "vp")] [NativeName(NativeNameType.Type, "ImGuiViewport*")] nint vp);

	#endif

	#if NET5_0_OR_GREATER
	/// <summary>
	/// To be documented.
	/// </summary>
	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public unsafe delegate void PlatformSetWindowTitle([NativeName(NativeNameType.Param, "vp")] [NativeName(NativeNameType.Type, "ImGuiViewport*")] ImGuiViewport* vp, [NativeName(NativeNameType.Param, "str")] [NativeName(NativeNameType.Type, "const char*")] byte* str);

	#else
	/// <summary>
	/// To be documented.
	/// </summary>
	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public unsafe delegate void PlatformSetWindowTitle([NativeName(NativeNameType.Param, "vp")] [NativeName(NativeNameType.Type, "ImGuiViewport*")] nint vp, [NativeName(NativeNameType.Param, "str")] [NativeName(NativeNameType.Type, "const char*")] nint str);

	#endif

	#if NET5_0_OR_GREATER
	/// <summary>
	/// To be documented.
	/// </summary>
	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public unsafe delegate void PlatformSetWindowAlpha([NativeName(NativeNameType.Param, "vp")] [NativeName(NativeNameType.Type, "ImGuiViewport*")] ImGuiViewport* vp, [NativeName(NativeNameType.Param, "alpha")] [NativeName(NativeNameType.Type, "float")] float alpha);

	#else
	/// <summary>
	/// To be documented.
	/// </summary>
	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public unsafe delegate void PlatformSetWindowAlpha([NativeName(NativeNameType.Param, "vp")] [NativeName(NativeNameType.Type, "ImGuiViewport*")] nint vp, [NativeName(NativeNameType.Param, "alpha")] [NativeName(NativeNameType.Type, "float")] float alpha);

	#endif

	#if NET5_0_OR_GREATER
	/// <summary>
	/// To be documented.
	/// </summary>
	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public unsafe delegate void PlatformUpdateWindow([NativeName(NativeNameType.Param, "vp")] [NativeName(NativeNameType.Type, "ImGuiViewport*")] ImGuiViewport* vp);

	#else
	/// <summary>
	/// To be documented.
	/// </summary>
	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public unsafe delegate void PlatformUpdateWindow([NativeName(NativeNameType.Param, "vp")] [NativeName(NativeNameType.Type, "ImGuiViewport*")] nint vp);

	#endif

	#if NET5_0_OR_GREATER
	/// <summary>
	/// To be documented.
	/// </summary>
	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public unsafe delegate void PlatformRenderWindow([NativeName(NativeNameType.Param, "vp")] [NativeName(NativeNameType.Type, "ImGuiViewport*")] ImGuiViewport* vp, [NativeName(NativeNameType.Param, "render_arg")] [NativeName(NativeNameType.Type, "void*")] void* renderArg);

	#else
	/// <summary>
	/// To be documented.
	/// </summary>
	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public unsafe delegate void PlatformRenderWindow([NativeName(NativeNameType.Param, "vp")] [NativeName(NativeNameType.Type, "ImGuiViewport*")] nint vp, [NativeName(NativeNameType.Param, "render_arg")] [NativeName(NativeNameType.Type, "void*")] nint renderArg);

	#endif

	#if NET5_0_OR_GREATER
	/// <summary>
	/// To be documented.
	/// </summary>
	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public unsafe delegate void PlatformSwapBuffers([NativeName(NativeNameType.Param, "vp")] [NativeName(NativeNameType.Type, "ImGuiViewport*")] ImGuiViewport* vp, [NativeName(NativeNameType.Param, "render_arg")] [NativeName(NativeNameType.Type, "void*")] void* renderArg);

	#else
	/// <summary>
	/// To be documented.
	/// </summary>
	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public unsafe delegate void PlatformSwapBuffers([NativeName(NativeNameType.Param, "vp")] [NativeName(NativeNameType.Type, "ImGuiViewport*")] nint vp, [NativeName(NativeNameType.Param, "render_arg")] [NativeName(NativeNameType.Type, "void*")] nint renderArg);

	#endif

	#if NET5_0_OR_GREATER
	/// <summary>
	/// To be documented.
	/// </summary>
	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public unsafe delegate float PlatformGetWindowDpiScale([NativeName(NativeNameType.Param, "vp")] [NativeName(NativeNameType.Type, "ImGuiViewport*")] ImGuiViewport* vp);

	#else
	/// <summary>
	/// To be documented.
	/// </summary>
	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public unsafe delegate float PlatformGetWindowDpiScale([NativeName(NativeNameType.Param, "vp")] [NativeName(NativeNameType.Type, "ImGuiViewport*")] nint vp);

	#endif

	#if NET5_0_OR_GREATER
	/// <summary>
	/// To be documented.
	/// </summary>
	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public unsafe delegate void PlatformOnChangedViewport([NativeName(NativeNameType.Param, "vp")] [NativeName(NativeNameType.Type, "ImGuiViewport*")] ImGuiViewport* vp);

	#else
	/// <summary>
	/// To be documented.
	/// </summary>
	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public unsafe delegate void PlatformOnChangedViewport([NativeName(NativeNameType.Param, "vp")] [NativeName(NativeNameType.Type, "ImGuiViewport*")] nint vp);

	#endif

	#if NET5_0_OR_GREATER
	/// <summary>
	/// To be documented.
	/// </summary>
	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public unsafe delegate Vector4 PlatformGetWindowWorkAreaInsets([NativeName(NativeNameType.Param, "vp")] [NativeName(NativeNameType.Type, "ImGuiViewport*")] ImGuiViewport* vp);

	#else
	/// <summary>
	/// To be documented.
	/// </summary>
	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public unsafe delegate Vector4 PlatformGetWindowWorkAreaInsets([NativeName(NativeNameType.Param, "vp")] [NativeName(NativeNameType.Type, "ImGuiViewport*")] nint vp);

	#endif

	#if NET5_0_OR_GREATER
	/// <summary>
	/// To be documented.
	/// </summary>
	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public unsafe delegate int PlatformCreateVkSurface([NativeName(NativeNameType.Param, "vp")] [NativeName(NativeNameType.Type, "ImGuiViewport*")] ImGuiViewport* vp, [NativeName(NativeNameType.Param, "vk_inst")] [NativeName(NativeNameType.Type, "ImU64")] ulong vkInst, [NativeName(NativeNameType.Param, "vk_allocators")] [NativeName(NativeNameType.Type, "const void*")] void* vkAllocators, [NativeName(NativeNameType.Param, "out_vk_surface")] [NativeName(NativeNameType.Type, "ImU64*")] ulong* outVkSurface);

	#else
	/// <summary>
	/// To be documented.
	/// </summary>
	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public unsafe delegate int PlatformCreateVkSurface([NativeName(NativeNameType.Param, "vp")] [NativeName(NativeNameType.Type, "ImGuiViewport*")] nint vp, [NativeName(NativeNameType.Param, "vk_inst")] [NativeName(NativeNameType.Type, "ImU64")] ulong vkInst, [NativeName(NativeNameType.Param, "vk_allocators")] [NativeName(NativeNameType.Type, "const void*")] nint vkAllocators, [NativeName(NativeNameType.Param, "out_vk_surface")] [NativeName(NativeNameType.Type, "ImU64*")] nint outVkSurface);

	#endif

	#if NET5_0_OR_GREATER
	/// <summary>
	/// To be documented.
	/// </summary>
	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public unsafe delegate void RendererCreateWindow([NativeName(NativeNameType.Param, "vp")] [NativeName(NativeNameType.Type, "ImGuiViewport*")] ImGuiViewport* vp);

	#else
	/// <summary>
	/// To be documented.
	/// </summary>
	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public unsafe delegate void RendererCreateWindow([NativeName(NativeNameType.Param, "vp")] [NativeName(NativeNameType.Type, "ImGuiViewport*")] nint vp);

	#endif

	#if NET5_0_OR_GREATER
	/// <summary>
	/// To be documented.
	/// </summary>
	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public unsafe delegate void RendererDestroyWindow([NativeName(NativeNameType.Param, "vp")] [NativeName(NativeNameType.Type, "ImGuiViewport*")] ImGuiViewport* vp);

	#else
	/// <summary>
	/// To be documented.
	/// </summary>
	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public unsafe delegate void RendererDestroyWindow([NativeName(NativeNameType.Param, "vp")] [NativeName(NativeNameType.Type, "ImGuiViewport*")] nint vp);

	#endif

	#if NET5_0_OR_GREATER
	/// <summary>
	/// To be documented.
	/// </summary>
	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public unsafe delegate void RendererSetWindowSize([NativeName(NativeNameType.Param, "vp")] [NativeName(NativeNameType.Type, "ImGuiViewport*")] ImGuiViewport* vp, [NativeName(NativeNameType.Param, "size")] [NativeName(NativeNameType.Type, "ImVec2")] Vector2 size);

	#else
	/// <summary>
	/// To be documented.
	/// </summary>
	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public unsafe delegate void RendererSetWindowSize([NativeName(NativeNameType.Param, "vp")] [NativeName(NativeNameType.Type, "ImGuiViewport*")] nint vp, [NativeName(NativeNameType.Param, "size")] [NativeName(NativeNameType.Type, "ImVec2")] Vector2 size);

	#endif

	#if NET5_0_OR_GREATER
	/// <summary>
	/// To be documented.
	/// </summary>
	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public unsafe delegate void RendererRenderWindow([NativeName(NativeNameType.Param, "vp")] [NativeName(NativeNameType.Type, "ImGuiViewport*")] ImGuiViewport* vp, [NativeName(NativeNameType.Param, "render_arg")] [NativeName(NativeNameType.Type, "void*")] void* renderArg);

	#else
	/// <summary>
	/// To be documented.
	/// </summary>
	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public unsafe delegate void RendererRenderWindow([NativeName(NativeNameType.Param, "vp")] [NativeName(NativeNameType.Type, "ImGuiViewport*")] nint vp, [NativeName(NativeNameType.Param, "render_arg")] [NativeName(NativeNameType.Type, "void*")] nint renderArg);

	#endif

	#if NET5_0_OR_GREATER
	/// <summary>
	/// To be documented.
	/// </summary>
	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public unsafe delegate void RendererSwapBuffers([NativeName(NativeNameType.Param, "vp")] [NativeName(NativeNameType.Type, "ImGuiViewport*")] ImGuiViewport* vp, [NativeName(NativeNameType.Param, "render_arg")] [NativeName(NativeNameType.Type, "void*")] void* renderArg);

	#else
	/// <summary>
	/// To be documented.
	/// </summary>
	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public unsafe delegate void RendererSwapBuffers([NativeName(NativeNameType.Param, "vp")] [NativeName(NativeNameType.Type, "ImGuiViewport*")] nint vp, [NativeName(NativeNameType.Param, "render_arg")] [NativeName(NativeNameType.Type, "void*")] nint renderArg);

	#endif

	#if NET5_0_OR_GREATER
	/// <summary>
	/// To be documented.
	/// </summary>
	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public unsafe delegate void SizeCallback([NativeName(NativeNameType.Param, "data")] [NativeName(NativeNameType.Type, "ImGuiSizeCallbackData*")] ImGuiSizeCallbackData* data);

	#else
	/// <summary>
	/// To be documented.
	/// </summary>
	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public unsafe delegate void SizeCallback([NativeName(NativeNameType.Param, "data")] [NativeName(NativeNameType.Type, "ImGuiSizeCallbackData*")] nint data);

	#endif

	#if NET5_0_OR_GREATER
	/// <summary>
	/// To be documented.
	/// </summary>
	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public unsafe delegate void ClearAllFn([NativeName(NativeNameType.Param, "ctx")] [NativeName(NativeNameType.Type, "ImGuiContext*")] ImGuiContext* ctx, [NativeName(NativeNameType.Param, "handler")] [NativeName(NativeNameType.Type, "ImGuiSettingsHandler*")] ImGuiSettingsHandler* handler);

	#else
	/// <summary>
	/// To be documented.
	/// </summary>
	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public unsafe delegate void ClearAllFn([NativeName(NativeNameType.Param, "ctx")] [NativeName(NativeNameType.Type, "ImGuiContext*")] nint ctx, [NativeName(NativeNameType.Param, "handler")] [NativeName(NativeNameType.Type, "ImGuiSettingsHandler*")] nint handler);

	#endif

	#if NET5_0_OR_GREATER
	/// <summary>
	/// To be documented.
	/// </summary>
	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public unsafe delegate void ReadInitFn([NativeName(NativeNameType.Param, "ctx")] [NativeName(NativeNameType.Type, "ImGuiContext*")] ImGuiContext* ctx, [NativeName(NativeNameType.Param, "handler")] [NativeName(NativeNameType.Type, "ImGuiSettingsHandler*")] ImGuiSettingsHandler* handler);

	#else
	/// <summary>
	/// To be documented.
	/// </summary>
	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public unsafe delegate void ReadInitFn([NativeName(NativeNameType.Param, "ctx")] [NativeName(NativeNameType.Type, "ImGuiContext*")] nint ctx, [NativeName(NativeNameType.Param, "handler")] [NativeName(NativeNameType.Type, "ImGuiSettingsHandler*")] nint handler);

	#endif

	#if NET5_0_OR_GREATER
	/// <summary>
	/// To be documented.
	/// </summary>
	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public unsafe delegate void* ReadOpenFn([NativeName(NativeNameType.Param, "ctx")] [NativeName(NativeNameType.Type, "ImGuiContext*")] ImGuiContext* ctx, [NativeName(NativeNameType.Param, "handler")] [NativeName(NativeNameType.Type, "ImGuiSettingsHandler*")] ImGuiSettingsHandler* handler, [NativeName(NativeNameType.Param, "name")] [NativeName(NativeNameType.Type, "const char*")] byte* name);

	#else
	/// <summary>
	/// To be documented.
	/// </summary>
	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public unsafe delegate nint ReadOpenFn([NativeName(NativeNameType.Param, "ctx")] [NativeName(NativeNameType.Type, "ImGuiContext*")] nint ctx, [NativeName(NativeNameType.Param, "handler")] [NativeName(NativeNameType.Type, "ImGuiSettingsHandler*")] nint handler, [NativeName(NativeNameType.Param, "name")] [NativeName(NativeNameType.Type, "const char*")] nint name);

	#endif

	#if NET5_0_OR_GREATER
	/// <summary>
	/// To be documented.
	/// </summary>
	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public unsafe delegate void ReadLineFn([NativeName(NativeNameType.Param, "ctx")] [NativeName(NativeNameType.Type, "ImGuiContext*")] ImGuiContext* ctx, [NativeName(NativeNameType.Param, "handler")] [NativeName(NativeNameType.Type, "ImGuiSettingsHandler*")] ImGuiSettingsHandler* handler, [NativeName(NativeNameType.Param, "entry")] [NativeName(NativeNameType.Type, "void*")] void* entry, [NativeName(NativeNameType.Param, "line")] [NativeName(NativeNameType.Type, "const char*")] byte* line);

	#else
	/// <summary>
	/// To be documented.
	/// </summary>
	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public unsafe delegate void ReadLineFn([NativeName(NativeNameType.Param, "ctx")] [NativeName(NativeNameType.Type, "ImGuiContext*")] nint ctx, [NativeName(NativeNameType.Param, "handler")] [NativeName(NativeNameType.Type, "ImGuiSettingsHandler*")] nint handler, [NativeName(NativeNameType.Param, "entry")] [NativeName(NativeNameType.Type, "void*")] nint entry, [NativeName(NativeNameType.Param, "line")] [NativeName(NativeNameType.Type, "const char*")] nint line);

	#endif

	#if NET5_0_OR_GREATER
	/// <summary>
	/// To be documented.
	/// </summary>
	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public unsafe delegate void ApplyAllFn([NativeName(NativeNameType.Param, "ctx")] [NativeName(NativeNameType.Type, "ImGuiContext*")] ImGuiContext* ctx, [NativeName(NativeNameType.Param, "handler")] [NativeName(NativeNameType.Type, "ImGuiSettingsHandler*")] ImGuiSettingsHandler* handler);

	#else
	/// <summary>
	/// To be documented.
	/// </summary>
	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public unsafe delegate void ApplyAllFn([NativeName(NativeNameType.Param, "ctx")] [NativeName(NativeNameType.Type, "ImGuiContext*")] nint ctx, [NativeName(NativeNameType.Param, "handler")] [NativeName(NativeNameType.Type, "ImGuiSettingsHandler*")] nint handler);

	#endif

	#if NET5_0_OR_GREATER
	/// <summary>
	/// To be documented.
	/// </summary>
	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public unsafe delegate void WriteAllFn([NativeName(NativeNameType.Param, "ctx")] [NativeName(NativeNameType.Type, "ImGuiContext*")] ImGuiContext* ctx, [NativeName(NativeNameType.Param, "handler")] [NativeName(NativeNameType.Type, "ImGuiSettingsHandler*")] ImGuiSettingsHandler* handler, [NativeName(NativeNameType.Param, "out_buf")] [NativeName(NativeNameType.Type, "ImGuiTextBuffer*")] ImGuiTextBuffer* outBuf);

	#else
	/// <summary>
	/// To be documented.
	/// </summary>
	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public unsafe delegate void WriteAllFn([NativeName(NativeNameType.Param, "ctx")] [NativeName(NativeNameType.Type, "ImGuiContext*")] nint ctx, [NativeName(NativeNameType.Param, "handler")] [NativeName(NativeNameType.Type, "ImGuiSettingsHandler*")] nint handler, [NativeName(NativeNameType.Param, "out_buf")] [NativeName(NativeNameType.Type, "ImGuiTextBuffer*")] nint outBuf);

	#endif

	#if NET5_0_OR_GREATER
	/// <summary>
	/// To be documented.
	/// </summary>
	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public unsafe delegate void Callback([NativeName(NativeNameType.Param, "ctx")] [NativeName(NativeNameType.Type, "ImGuiContext*")] ImGuiContext* ctx, [NativeName(NativeNameType.Param, "hook")] [NativeName(NativeNameType.Type, "ImGuiContextHook*")] ImGuiContextHook* hook);

	#else
	/// <summary>
	/// To be documented.
	/// </summary>
	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public unsafe delegate void Callback([NativeName(NativeNameType.Param, "ctx")] [NativeName(NativeNameType.Type, "ImGuiContext*")] nint ctx, [NativeName(NativeNameType.Param, "hook")] [NativeName(NativeNameType.Type, "ImGuiContextHook*")] nint hook);

	#endif

	#if NET5_0_OR_GREATER
	/// <summary>
	/// To be documented.
	/// </summary>
	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public unsafe delegate uint AdapterIndexToStorageId([NativeName(NativeNameType.Param, "self")] [NativeName(NativeNameType.Type, "ImGuiSelectionBasicStorage*")] ImGuiSelectionBasicStorage* self, [NativeName(NativeNameType.Param, "idx")] [NativeName(NativeNameType.Type, "int")] int idx);

	#else
	/// <summary>
	/// To be documented.
	/// </summary>
	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public unsafe delegate uint AdapterIndexToStorageId([NativeName(NativeNameType.Param, "self")] [NativeName(NativeNameType.Type, "ImGuiSelectionBasicStorage*")] nint self, [NativeName(NativeNameType.Param, "idx")] [NativeName(NativeNameType.Type, "int")] int idx);

	#endif

	#if NET5_0_OR_GREATER
	/// <summary>
	/// To be documented.
	/// </summary>
	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public unsafe delegate void AdapterSetItemSelected([NativeName(NativeNameType.Param, "self")] [NativeName(NativeNameType.Type, "ImGuiSelectionExternalStorage*")] ImGuiSelectionExternalStorage* self, [NativeName(NativeNameType.Param, "idx")] [NativeName(NativeNameType.Type, "int")] int idx, [NativeName(NativeNameType.Param, "selected")] [NativeName(NativeNameType.Type, "bool")] byte selected);

	#else
	/// <summary>
	/// To be documented.
	/// </summary>
	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public unsafe delegate void AdapterSetItemSelected([NativeName(NativeNameType.Param, "self")] [NativeName(NativeNameType.Type, "ImGuiSelectionExternalStorage*")] nint self, [NativeName(NativeNameType.Param, "idx")] [NativeName(NativeNameType.Type, "int")] int idx, [NativeName(NativeNameType.Param, "selected")] [NativeName(NativeNameType.Type, "bool")] byte selected);

	#endif

	#if NET5_0_OR_GREATER
	/// <summary>
	/// To be documented.
	/// </summary>
	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public unsafe delegate void ImDrawCallback([NativeName(NativeNameType.Param, "parent_list")] [NativeName(NativeNameType.Type, "const ImDrawList*")] ImDrawList* parentList, [NativeName(NativeNameType.Param, "cmd")] [NativeName(NativeNameType.Type, "const ImDrawCmd*")] ImDrawCmd* cmd);

	#else
	/// <summary>
	/// To be documented.
	/// </summary>
	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public unsafe delegate void ImDrawCallback([NativeName(NativeNameType.Param, "parent_list")] [NativeName(NativeNameType.Type, "const ImDrawList*")] nint parentList, [NativeName(NativeNameType.Param, "cmd")] [NativeName(NativeNameType.Type, "const ImDrawCmd*")] nint cmd);

	#endif

	#if NET5_0_OR_GREATER
	/// <summary>
	/// To be documented.
	/// </summary>
	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public unsafe delegate void ImGuiSizeCallback([NativeName(NativeNameType.Param, "data")] [NativeName(NativeNameType.Type, "ImGuiSizeCallbackData*")] ImGuiSizeCallbackData* data);

	#else
	/// <summary>
	/// To be documented.
	/// </summary>
	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public unsafe delegate void ImGuiSizeCallback([NativeName(NativeNameType.Param, "data")] [NativeName(NativeNameType.Type, "ImGuiSizeCallbackData*")] nint data);

	#endif

	#if NET5_0_OR_GREATER
	/// <summary>
	/// To be documented.
	/// </summary>
	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public unsafe delegate void ImGuiContextHookCallback([NativeName(NativeNameType.Param, "ctx")] [NativeName(NativeNameType.Type, "ImGuiContext*")] ImGuiContext* ctx, [NativeName(NativeNameType.Param, "hook")] [NativeName(NativeNameType.Type, "ImGuiContextHook*")] ImGuiContextHook* hook);

	#else
	/// <summary>
	/// To be documented.
	/// </summary>
	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public unsafe delegate void ImGuiContextHookCallback([NativeName(NativeNameType.Param, "ctx")] [NativeName(NativeNameType.Type, "ImGuiContext*")] nint ctx, [NativeName(NativeNameType.Param, "hook")] [NativeName(NativeNameType.Type, "ImGuiContextHook*")] nint hook);

	#endif

	#if NET5_0_OR_GREATER
	/// <summary>
	/// To be documented.
	/// </summary>
	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public unsafe delegate int ImGuiInputTextCallback([NativeName(NativeNameType.Param, "data")] [NativeName(NativeNameType.Type, "ImGuiInputTextCallbackData*")] ImGuiInputTextCallbackData* data);

	#else
	/// <summary>
	/// To be documented.
	/// </summary>
	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public unsafe delegate int ImGuiInputTextCallback([NativeName(NativeNameType.Param, "data")] [NativeName(NativeNameType.Type, "ImGuiInputTextCallbackData*")] nint data);

	#endif

	#if NET5_0_OR_GREATER
	/// <summary>
	/// To be documented.
	/// </summary>
	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public unsafe delegate void* ImGuiMemAllocFunc([NativeName(NativeNameType.Param, "sz")] [NativeName(NativeNameType.Type, "size_t")] ulong sz, [NativeName(NativeNameType.Param, "user_data")] [NativeName(NativeNameType.Type, "void*")] void* userData);

	#else
	/// <summary>
	/// To be documented.
	/// </summary>
	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public unsafe delegate nint ImGuiMemAllocFunc([NativeName(NativeNameType.Param, "sz")] [NativeName(NativeNameType.Type, "size_t")] ulong sz, [NativeName(NativeNameType.Param, "user_data")] [NativeName(NativeNameType.Type, "void*")] nint userData);

	#endif

	#if NET5_0_OR_GREATER
	/// <summary>
	/// To be documented.
	/// </summary>
	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public unsafe delegate void ImGuiMemFreeFunc([NativeName(NativeNameType.Param, "ptr")] [NativeName(NativeNameType.Type, "void*")] void* ptr, [NativeName(NativeNameType.Param, "user_data")] [NativeName(NativeNameType.Type, "void*")] void* userData);

	#else
	/// <summary>
	/// To be documented.
	/// </summary>
	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public unsafe delegate void ImGuiMemFreeFunc([NativeName(NativeNameType.Param, "ptr")] [NativeName(NativeNameType.Type, "void*")] nint ptr, [NativeName(NativeNameType.Param, "user_data")] [NativeName(NativeNameType.Type, "void*")] nint userData);

	#endif

	#if NET5_0_OR_GREATER
	/// <summary>
	/// To be documented.
	/// </summary>
	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public unsafe delegate void ImGuiErrorLogCallback([NativeName(NativeNameType.Param, "user_data")] [NativeName(NativeNameType.Type, "void*")] void* userData, [NativeName(NativeNameType.Param, "fmt")] [NativeName(NativeNameType.Type, "const char*")] byte* fmt);

	#else
	/// <summary>
	/// To be documented.
	/// </summary>
	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public unsafe delegate void ImGuiErrorLogCallback([NativeName(NativeNameType.Param, "user_data")] [NativeName(NativeNameType.Type, "void*")] nint userData, [NativeName(NativeNameType.Param, "fmt")] [NativeName(NativeNameType.Type, "const char*")] nint fmt);

	#endif

}
