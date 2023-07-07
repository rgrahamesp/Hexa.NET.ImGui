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
using System.Numerics;

namespace HexaEngine.ImGuiNET
{
	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public unsafe delegate void UserCallback(ImDrawList* parentList, ImDrawCmd* cmd);

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public unsafe delegate byte FontBuilderBuild(ImFontAtlas* atlas);

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public unsafe delegate void DockNodeWindowMenuHandler(ImGuiContext* ctx, ImGuiDockNode* node, ImGuiTabBar* tabBar);

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public unsafe delegate byte* GetClipboardTextFn(void* userData);

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public unsafe delegate void SetClipboardTextFn(void* userData, byte* text);

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public unsafe delegate void SetPlatformImeDataFn(ImGuiViewport* viewport, ImGuiPlatformImeData* data);

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public unsafe delegate void PlatformCreateWindow(ImGuiViewport* vp);

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public unsafe delegate void PlatformDestroyWindow(ImGuiViewport* vp);

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public unsafe delegate void PlatformShowWindow(ImGuiViewport* vp);

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public unsafe delegate void PlatformSetWindowPos(ImGuiViewport* vp, Vector2 pos);

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public unsafe delegate Vector2* PlatformGetWindowPos(Vector2* pos, ImGuiViewport* viewport);

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public unsafe delegate void PlatformSetWindowSize(ImGuiViewport* vp, Vector2 size);

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public unsafe delegate Vector2* PlatformGetWindowSize(Vector2* size, ImGuiViewport* viewport);

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public unsafe delegate void PlatformSetWindowFocus(ImGuiViewport* vp);

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public unsafe delegate byte PlatformGetWindowFocus(ImGuiViewport* vp);

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public unsafe delegate byte PlatformGetWindowMinimized(ImGuiViewport* vp);

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public unsafe delegate void PlatformSetWindowTitle(ImGuiViewport* vp, byte* str);

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public unsafe delegate void PlatformSetWindowAlpha(ImGuiViewport* vp, float alpha);

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public unsafe delegate void PlatformUpdateWindow(ImGuiViewport* vp);

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public unsafe delegate void PlatformRenderWindow(ImGuiViewport* vp, void* renderArg);

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public unsafe delegate void PlatformSwapBuffers(ImGuiViewport* vp, void* renderArg);

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public unsafe delegate float PlatformGetWindowDpiScale(ImGuiViewport* vp);

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public unsafe delegate void PlatformOnChangedViewport(ImGuiViewport* vp);

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public unsafe delegate int PlatformCreateVkSurface(ImGuiViewport* vp, ulong vkInst, void* vkAllocators, ulong* outVkSurface);

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public unsafe delegate void RendererCreateWindow(ImGuiViewport* vp);

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public unsafe delegate void RendererDestroyWindow(ImGuiViewport* vp);

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public unsafe delegate void RendererSetWindowSize(ImGuiViewport* vp, Vector2 size);

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public unsafe delegate void RendererRenderWindow(ImGuiViewport* vp, void* renderArg);

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public unsafe delegate void RendererSwapBuffers(ImGuiViewport* vp, void* renderArg);

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public unsafe delegate void SizeCallback(ImGuiSizeCallbackData* data);

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public unsafe delegate void ClearAllFn(ImGuiContext* ctx, ImGuiSettingsHandler* handler);

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public unsafe delegate void ReadInitFn(ImGuiContext* ctx, ImGuiSettingsHandler* handler);

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public unsafe delegate void* ReadOpenFn(ImGuiContext* ctx, ImGuiSettingsHandler* handler, byte* name);

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public unsafe delegate void ReadLineFn(ImGuiContext* ctx, ImGuiSettingsHandler* handler, void* entry, byte* line);

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public unsafe delegate void ApplyAllFn(ImGuiContext* ctx, ImGuiSettingsHandler* handler);

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public unsafe delegate void WriteAllFn(ImGuiContext* ctx, ImGuiSettingsHandler* handler, ImGuiTextBuffer* outBuf);

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public unsafe delegate void Callback(ImGuiContext* ctx, ImGuiContextHook* hook);

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public unsafe delegate void ImDrawCallback(ImDrawList* parentList, ImDrawCmd* cmd);

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public unsafe delegate void ImGuiSizeCallback(ImGuiSizeCallbackData* data);

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public unsafe delegate void ImGuiContextHookCallback(ImGuiContext* ctx, ImGuiContextHook* hook);

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public unsafe delegate int ImGuiInputTextCallback(ImGuiInputTextCallbackData* data);

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public unsafe delegate void* ImGuiMemAllocFunc(nuint sz, void* userData);

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public unsafe delegate void ImGuiMemFreeFunc(void* ptr, void* userData);

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public unsafe delegate void ImGuiErrorLogCallback(void* userData, byte* fmt);

}
