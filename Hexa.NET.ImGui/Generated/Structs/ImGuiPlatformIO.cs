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
	/// <summary>
	/// (Optional) Access via ImGui::GetPlatformIO()<br/>
	/// </summary>
	[StructLayout(LayoutKind.Sequential)]
	public partial struct ImGuiPlatformIO
	{
		/// <summary>
		/// To be documented.
		/// </summary>
		public unsafe void* PlatformCreateWindow;

		/// <summary>
		/// To be documented.
		/// </summary>
		public unsafe void* PlatformDestroyWindow;

		/// <summary>
		/// To be documented.
		/// </summary>
		public unsafe void* PlatformShowWindow;

		/// <summary>
		/// To be documented.
		/// </summary>
		public unsafe void* PlatformSetWindowPos;

		/// <summary>
		/// To be documented.
		/// </summary>
		public unsafe void* PlatformGetWindowPos;

		/// <summary>
		/// To be documented.
		/// </summary>
		public unsafe void* PlatformSetWindowSize;

		/// <summary>
		/// To be documented.
		/// </summary>
		public unsafe void* PlatformGetWindowSize;

		/// <summary>
		/// To be documented.
		/// </summary>
		public unsafe void* PlatformSetWindowFocus;

		/// <summary>
		/// To be documented.
		/// </summary>
		public unsafe void* PlatformGetWindowFocus;

		/// <summary>
		/// To be documented.
		/// </summary>
		public unsafe void* PlatformGetWindowMinimized;

		/// <summary>
		/// To be documented.
		/// </summary>
		public unsafe void* PlatformSetWindowTitle;

		/// <summary>
		/// To be documented.
		/// </summary>
		public unsafe void* PlatformSetWindowAlpha;

		/// <summary>
		/// To be documented.
		/// </summary>
		public unsafe void* PlatformUpdateWindow;

		/// <summary>
		/// To be documented.
		/// </summary>
		public unsafe void* PlatformRenderWindow;

		/// <summary>
		/// To be documented.
		/// </summary>
		public unsafe void* PlatformSwapBuffers;

		/// <summary>
		/// To be documented.
		/// </summary>
		public unsafe void* PlatformGetWindowDpiScale;

		/// <summary>
		/// To be documented.
		/// </summary>
		public unsafe void* PlatformOnChangedViewport;

		/// <summary>
		/// To be documented.
		/// </summary>
		public unsafe void* PlatformCreateVkSurface;

		/// <summary>
		/// To be documented.
		/// </summary>
		public unsafe void* RendererCreateWindow;

		/// <summary>
		/// To be documented.
		/// </summary>
		public unsafe void* RendererDestroyWindow;

		/// <summary>
		/// To be documented.
		/// </summary>
		public unsafe void* RendererSetWindowSize;

		/// <summary>
		/// To be documented.
		/// </summary>
		public unsafe void* RendererRenderWindow;

		/// <summary>
		/// To be documented.
		/// </summary>
		public unsafe void* RendererSwapBuffers;

		/// <summary>
		/// To be documented.
		/// </summary>
		public ImVector<ImGuiPlatformMonitor> Monitors;

		/// <summary>
		/// To be documented.
		/// </summary>
		public ImVector<ImGuiViewportPtr> Viewports;


		/// <summary>
		/// To be documented.
		/// </summary>
		public unsafe ImGuiPlatformIO(delegate*<ImGuiViewport*, void> platformCreatewindow = default, delegate*<ImGuiViewport*, void> platformDestroywindow = default, delegate*<ImGuiViewport*, void> platformShowwindow = default, delegate*<ImGuiViewport*, Vector2, void> platformSetwindowpos = default, delegate*<ImGuiViewport*, Vector2> platformGetwindowpos = default, delegate*<ImGuiViewport*, Vector2, void> platformSetwindowsize = default, delegate*<ImGuiViewport*, Vector2> platformGetwindowsize = default, delegate*<ImGuiViewport*, void> platformSetwindowfocus = default, delegate*<ImGuiViewport*, bool> platformGetwindowfocus = default, delegate*<ImGuiViewport*, bool> platformGetwindowminimized = default, delegate*<ImGuiViewport*, byte*, void> platformSetwindowtitle = default, delegate*<ImGuiViewport*, float, void> platformSetwindowalpha = default, delegate*<ImGuiViewport*, void> platformUpdatewindow = default, delegate*<ImGuiViewport*, void*, void> platformRenderwindow = default, delegate*<ImGuiViewport*, void*, void> platformSwapbuffers = default, delegate*<ImGuiViewport*, float> platformGetwindowdpiscale = default, delegate*<ImGuiViewport*, void> platformOnchangedviewport = default, delegate*<ImGuiViewport*, ulong, void*, ulong*, int> platformCreatevksurface = default, delegate*<ImGuiViewport*, void> rendererCreatewindow = default, delegate*<ImGuiViewport*, void> rendererDestroywindow = default, delegate*<ImGuiViewport*, Vector2, void> rendererSetwindowsize = default, delegate*<ImGuiViewport*, void*, void> rendererRenderwindow = default, delegate*<ImGuiViewport*, void*, void> rendererSwapbuffers = default, ImVector<ImGuiPlatformMonitor> monitors = default, ImVector<ImGuiViewportPtr> viewports = default)
		{
			PlatformCreateWindow = (void*)platformCreatewindow;
			PlatformDestroyWindow = (void*)platformDestroywindow;
			PlatformShowWindow = (void*)platformShowwindow;
			PlatformSetWindowPos = (void*)platformSetwindowpos;
			PlatformGetWindowPos = (void*)platformGetwindowpos;
			PlatformSetWindowSize = (void*)platformSetwindowsize;
			PlatformGetWindowSize = (void*)platformGetwindowsize;
			PlatformSetWindowFocus = (void*)platformSetwindowfocus;
			PlatformGetWindowFocus = (void*)platformGetwindowfocus;
			PlatformGetWindowMinimized = (void*)platformGetwindowminimized;
			PlatformSetWindowTitle = (void*)platformSetwindowtitle;
			PlatformSetWindowAlpha = (void*)platformSetwindowalpha;
			PlatformUpdateWindow = (void*)platformUpdatewindow;
			PlatformRenderWindow = (void*)platformRenderwindow;
			PlatformSwapBuffers = (void*)platformSwapbuffers;
			PlatformGetWindowDpiScale = (void*)platformGetwindowdpiscale;
			PlatformOnChangedViewport = (void*)platformOnchangedviewport;
			PlatformCreateVkSurface = (void*)platformCreatevksurface;
			RendererCreateWindow = (void*)rendererCreatewindow;
			RendererDestroyWindow = (void*)rendererDestroywindow;
			RendererSetWindowSize = (void*)rendererSetwindowsize;
			RendererRenderWindow = (void*)rendererRenderwindow;
			RendererSwapBuffers = (void*)rendererSwapbuffers;
			Monitors = monitors;
			Viewports = viewports;
		}


		/// <summary>
		/// To be documented.
		/// </summary>
		public unsafe void Destroy()
		{
			fixed (ImGuiPlatformIO* @this = &this)
			{
				ImGui.DestroyNative(@this);
			}
		}

	}

	/// <summary>
	/// To be documented.
	/// </summary>
	#if NET5_0_OR_GREATER
	[DebuggerDisplay("{DebuggerDisplay,nq}")]
	#endif
	public unsafe struct ImGuiPlatformIOPtr : IEquatable<ImGuiPlatformIOPtr>
	{
		public ImGuiPlatformIOPtr(ImGuiPlatformIO* handle) { Handle = handle; }

		public ImGuiPlatformIO* Handle;

		public bool IsNull => Handle == null;

		public static ImGuiPlatformIOPtr Null => new ImGuiPlatformIOPtr(null);

		public ImGuiPlatformIO this[int index] { get => Handle[index]; set => Handle[index] = value; }

		public static implicit operator ImGuiPlatformIOPtr(ImGuiPlatformIO* handle) => new ImGuiPlatformIOPtr(handle);

		public static implicit operator ImGuiPlatformIO*(ImGuiPlatformIOPtr handle) => handle.Handle;

		public static bool operator ==(ImGuiPlatformIOPtr left, ImGuiPlatformIOPtr right) => left.Handle == right.Handle;

		public static bool operator !=(ImGuiPlatformIOPtr left, ImGuiPlatformIOPtr right) => left.Handle != right.Handle;

		public static bool operator ==(ImGuiPlatformIOPtr left, ImGuiPlatformIO* right) => left.Handle == right;

		public static bool operator !=(ImGuiPlatformIOPtr left, ImGuiPlatformIO* right) => left.Handle != right;

		public bool Equals(ImGuiPlatformIOPtr other) => Handle == other.Handle;

		/// <inheritdoc/>
		public override bool Equals(object obj) => obj is ImGuiPlatformIOPtr handle && Equals(handle);

		/// <inheritdoc/>
		public override int GetHashCode() => ((nuint)Handle).GetHashCode();

		#if NET5_0_OR_GREATER
		private string DebuggerDisplay => string.Format("ImGuiPlatformIOPtr [0x{0}]", ((nuint)Handle).ToString("X"));
		#endif
		/// <summary>
		/// To be documented.
		/// </summary>
		public void* PlatformCreateWindow { get => Handle->PlatformCreateWindow; set => Handle->PlatformCreateWindow = value; }
		/// <summary>
		/// To be documented.
		/// </summary>
		public void* PlatformDestroyWindow { get => Handle->PlatformDestroyWindow; set => Handle->PlatformDestroyWindow = value; }
		/// <summary>
		/// To be documented.
		/// </summary>
		public void* PlatformShowWindow { get => Handle->PlatformShowWindow; set => Handle->PlatformShowWindow = value; }
		/// <summary>
		/// To be documented.
		/// </summary>
		public void* PlatformSetWindowPos { get => Handle->PlatformSetWindowPos; set => Handle->PlatformSetWindowPos = value; }
		/// <summary>
		/// To be documented.
		/// </summary>
		public void* PlatformGetWindowPos { get => Handle->PlatformGetWindowPos; set => Handle->PlatformGetWindowPos = value; }
		/// <summary>
		/// To be documented.
		/// </summary>
		public void* PlatformSetWindowSize { get => Handle->PlatformSetWindowSize; set => Handle->PlatformSetWindowSize = value; }
		/// <summary>
		/// To be documented.
		/// </summary>
		public void* PlatformGetWindowSize { get => Handle->PlatformGetWindowSize; set => Handle->PlatformGetWindowSize = value; }
		/// <summary>
		/// To be documented.
		/// </summary>
		public void* PlatformSetWindowFocus { get => Handle->PlatformSetWindowFocus; set => Handle->PlatformSetWindowFocus = value; }
		/// <summary>
		/// To be documented.
		/// </summary>
		public void* PlatformGetWindowFocus { get => Handle->PlatformGetWindowFocus; set => Handle->PlatformGetWindowFocus = value; }
		/// <summary>
		/// To be documented.
		/// </summary>
		public void* PlatformGetWindowMinimized { get => Handle->PlatformGetWindowMinimized; set => Handle->PlatformGetWindowMinimized = value; }
		/// <summary>
		/// To be documented.
		/// </summary>
		public void* PlatformSetWindowTitle { get => Handle->PlatformSetWindowTitle; set => Handle->PlatformSetWindowTitle = value; }
		/// <summary>
		/// To be documented.
		/// </summary>
		public void* PlatformSetWindowAlpha { get => Handle->PlatformSetWindowAlpha; set => Handle->PlatformSetWindowAlpha = value; }
		/// <summary>
		/// To be documented.
		/// </summary>
		public void* PlatformUpdateWindow { get => Handle->PlatformUpdateWindow; set => Handle->PlatformUpdateWindow = value; }
		/// <summary>
		/// To be documented.
		/// </summary>
		public void* PlatformRenderWindow { get => Handle->PlatformRenderWindow; set => Handle->PlatformRenderWindow = value; }
		/// <summary>
		/// To be documented.
		/// </summary>
		public void* PlatformSwapBuffers { get => Handle->PlatformSwapBuffers; set => Handle->PlatformSwapBuffers = value; }
		/// <summary>
		/// To be documented.
		/// </summary>
		public void* PlatformGetWindowDpiScale { get => Handle->PlatformGetWindowDpiScale; set => Handle->PlatformGetWindowDpiScale = value; }
		/// <summary>
		/// To be documented.
		/// </summary>
		public void* PlatformOnChangedViewport { get => Handle->PlatformOnChangedViewport; set => Handle->PlatformOnChangedViewport = value; }
		/// <summary>
		/// To be documented.
		/// </summary>
		public void* PlatformCreateVkSurface { get => Handle->PlatformCreateVkSurface; set => Handle->PlatformCreateVkSurface = value; }
		/// <summary>
		/// To be documented.
		/// </summary>
		public void* RendererCreateWindow { get => Handle->RendererCreateWindow; set => Handle->RendererCreateWindow = value; }
		/// <summary>
		/// To be documented.
		/// </summary>
		public void* RendererDestroyWindow { get => Handle->RendererDestroyWindow; set => Handle->RendererDestroyWindow = value; }
		/// <summary>
		/// To be documented.
		/// </summary>
		public void* RendererSetWindowSize { get => Handle->RendererSetWindowSize; set => Handle->RendererSetWindowSize = value; }
		/// <summary>
		/// To be documented.
		/// </summary>
		public void* RendererRenderWindow { get => Handle->RendererRenderWindow; set => Handle->RendererRenderWindow = value; }
		/// <summary>
		/// To be documented.
		/// </summary>
		public void* RendererSwapBuffers { get => Handle->RendererSwapBuffers; set => Handle->RendererSwapBuffers = value; }
		/// <summary>
		/// To be documented.
		/// </summary>
		public ref ImVector<ImGuiPlatformMonitor> Monitors => ref Unsafe.AsRef<ImVector<ImGuiPlatformMonitor>>(&Handle->Monitors);
		/// <summary>
		/// To be documented.
		/// </summary>
		public ref ImVector<ImGuiViewportPtr> Viewports => ref Unsafe.AsRef<ImVector<ImGuiViewportPtr>>(&Handle->Viewports);
		/// <summary>
		/// To be documented.
		/// </summary>
		public unsafe void Destroy()
		{
			ImGui.DestroyNative(Handle);
		}

	}

}
