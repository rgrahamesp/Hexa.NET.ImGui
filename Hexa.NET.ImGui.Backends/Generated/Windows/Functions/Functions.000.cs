// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using HexaGen.Runtime;
using System.Numerics;
using Hexa.NET.ImGui;

namespace Hexa.NET.ImGui.Backends.Win32
{
	public unsafe partial class ImGuiImplWin32
	{
		/// <summary>
		/// Follow "Getting Started" link and check examples/ folder to learn about using backends!<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static byte InitNative(void* hwnd)
		{
			#if NET5_0_OR_GREATER
			return ((delegate* unmanaged[Cdecl]<void*, byte>)funcTable[45])(hwnd);
			#else
			return (byte)((delegate* unmanaged[Cdecl]<nint, byte>)funcTable[45])((nint)hwnd);
			#endif
		}

		/// <summary>
		/// Follow "Getting Started" link and check examples/ folder to learn about using backends!<br/>
		/// </summary>
		public static bool Init(void* hwnd)
		{
			byte ret = InitNative(hwnd);
			return ret != 0;
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static byte InitForOpenGLNative(void* hwnd)
		{
			#if NET5_0_OR_GREATER
			return ((delegate* unmanaged[Cdecl]<void*, byte>)funcTable[46])(hwnd);
			#else
			return (byte)((delegate* unmanaged[Cdecl]<nint, byte>)funcTable[46])((nint)hwnd);
			#endif
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		public static bool InitForOpenGL(void* hwnd)
		{
			byte ret = InitForOpenGLNative(hwnd);
			return ret != 0;
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void ShutdownNative()
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<void>)funcTable[47])();
			#else
			((delegate* unmanaged[Cdecl]<void>)funcTable[47])();
			#endif
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		public static void Shutdown()
		{
			ShutdownNative();
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void NewFrameNative()
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<void>)funcTable[48])();
			#else
			((delegate* unmanaged[Cdecl]<void>)funcTable[48])();
			#endif
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		public static void NewFrame()
		{
			NewFrameNative();
		}

		/// <summary>
		/// DPI-related helpers (optional)<br/>
		/// - Use to enable DPI awareness without having to create an application manifest.<br/>
		/// - Your own app may already do this via a manifest or explicit calls. This is mostly useful for our examples/ apps.<br/>
		/// - In theory we could call simple functions from Windows SDK such as SetProcessDPIAware(), SetProcessDpiAwareness(), etc.<br/>
		/// but most of the functions provided by Microsoft require Windows 8.1/10+ SDK at compile time and Windows 8/10+ at runtime,<br/>
		/// neither we want to require the user to have. So we dynamically select and load those functions to avoid dependencies.<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void EnableDpiAwarenessNative()
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<void>)funcTable[49])();
			#else
			((delegate* unmanaged[Cdecl]<void>)funcTable[49])();
			#endif
		}

		/// <summary>
		/// DPI-related helpers (optional)<br/>
		/// - Use to enable DPI awareness without having to create an application manifest.<br/>
		/// - Your own app may already do this via a manifest or explicit calls. This is mostly useful for our examples/ apps.<br/>
		/// - In theory we could call simple functions from Windows SDK such as SetProcessDPIAware(), SetProcessDpiAwareness(), etc.<br/>
		/// but most of the functions provided by Microsoft require Windows 8.1/10+ SDK at compile time and Windows 8/10+ at runtime,<br/>
		/// neither we want to require the user to have. So we dynamically select and load those functions to avoid dependencies.<br/>
		/// </summary>
		public static void EnableDpiAwareness()
		{
			EnableDpiAwarenessNative();
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static float GetDpiScaleForHwndNative(void* hwnd)
		{
			#if NET5_0_OR_GREATER
			return ((delegate* unmanaged[Cdecl]<void*, float>)funcTable[50])(hwnd);
			#else
			return (float)((delegate* unmanaged[Cdecl]<nint, float>)funcTable[50])((nint)hwnd);
			#endif
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		public static float GetDpiScaleForHwnd(void* hwnd)
		{
			float ret = GetDpiScaleForHwndNative(hwnd);
			return ret;
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static float GetDpiScaleForMonitorNative(void* monitor)
		{
			#if NET5_0_OR_GREATER
			return ((delegate* unmanaged[Cdecl]<void*, float>)funcTable[51])(monitor);
			#else
			return (float)((delegate* unmanaged[Cdecl]<nint, float>)funcTable[51])((nint)monitor);
			#endif
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		public static float GetDpiScaleForMonitor(void* monitor)
		{
			float ret = GetDpiScaleForMonitorNative(monitor);
			return ret;
		}

		/// <summary>
		/// Transparency related helpers (optional) [experimental]<br/>
		/// - Use to enable alpha compositing transparency with the desktop.<br/>
		/// - Use together with e.g. clearing your framebuffer with zero-alpha.<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void EnableAlphaCompositingNative(void* hwnd)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<void*, void>)funcTable[52])(hwnd);
			#else
			((delegate* unmanaged[Cdecl]<nint, void>)funcTable[52])((nint)hwnd);
			#endif
		}

		/// <summary>
		/// Transparency related helpers (optional) [experimental]<br/>
		/// - Use to enable alpha compositing transparency with the desktop.<br/>
		/// - Use together with e.g. clearing your framebuffer with zero-alpha.<br/>
		/// </summary>
		public static void EnableAlphaCompositing(void* hwnd)
		{
			EnableAlphaCompositingNative(hwnd);
		}

	}
}
