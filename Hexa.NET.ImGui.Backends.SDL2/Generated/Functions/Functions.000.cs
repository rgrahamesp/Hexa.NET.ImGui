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

namespace Hexa.NET.ImGui.Backends.SDL2
{
	public unsafe partial class ImGuiImplSDL2
	{
		/// <summary>
		/// To be documented.
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void SetCurrentContextNative(ImGuiContext* ctx)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<ImGuiContext*, void>)funcTable[0])(ctx);
			#else
			((delegate* unmanaged[Cdecl]<nint, void>)funcTable[0])((nint)ctx);
			#endif
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		public static void SetCurrentContext(ImGuiContextPtr ctx)
		{
			SetCurrentContextNative(ctx);
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		public static void SetCurrentContext(ref ImGuiContext ctx)
		{
			fixed (ImGuiContext* pctx = &ctx)
			{
				SetCurrentContextNative((ImGuiContext*)pctx);
			}
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static ImGuiContext* GetCurrentContextNative()
		{
			#if NET5_0_OR_GREATER
			return ((delegate* unmanaged[Cdecl]<ImGuiContext*>)funcTable[1])();
			#else
			return (ImGuiContext*)((delegate* unmanaged[Cdecl]<nint>)funcTable[1])();
			#endif
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		public static ImGuiContextPtr GetCurrentContext()
		{
			ImGuiContextPtr ret = GetCurrentContextNative();
			return ret;
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static byte InitForOpenGLNative(SDLWindow* window, void* sdlGlContext)
		{
			#if NET5_0_OR_GREATER
			return ((delegate* unmanaged[Cdecl]<SDLWindow*, void*, byte>)funcTable[2])(window, sdlGlContext);
			#else
			return (byte)((delegate* unmanaged[Cdecl]<nint, nint, byte>)funcTable[2])((nint)window, (nint)sdlGlContext);
			#endif
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		public static bool InitForOpenGL(SDLWindowPtr window, void* sdlGlContext)
		{
			byte ret = InitForOpenGLNative(window, sdlGlContext);
			return ret != 0;
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		public static bool InitForOpenGL(ref SDLWindow window, void* sdlGlContext)
		{
			fixed (SDLWindow* pwindow = &window)
			{
				byte ret = InitForOpenGLNative((SDLWindow*)pwindow, sdlGlContext);
				return ret != 0;
			}
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static byte InitForVulkanNative(SDLWindow* window)
		{
			#if NET5_0_OR_GREATER
			return ((delegate* unmanaged[Cdecl]<SDLWindow*, byte>)funcTable[3])(window);
			#else
			return (byte)((delegate* unmanaged[Cdecl]<nint, byte>)funcTable[3])((nint)window);
			#endif
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		public static bool InitForVulkan(SDLWindowPtr window)
		{
			byte ret = InitForVulkanNative(window);
			return ret != 0;
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		public static bool InitForVulkan(ref SDLWindow window)
		{
			fixed (SDLWindow* pwindow = &window)
			{
				byte ret = InitForVulkanNative((SDLWindow*)pwindow);
				return ret != 0;
			}
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static byte InitForD3DNative(SDLWindow* window)
		{
			#if NET5_0_OR_GREATER
			return ((delegate* unmanaged[Cdecl]<SDLWindow*, byte>)funcTable[4])(window);
			#else
			return (byte)((delegate* unmanaged[Cdecl]<nint, byte>)funcTable[4])((nint)window);
			#endif
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		public static bool InitForD3D(SDLWindowPtr window)
		{
			byte ret = InitForD3DNative(window);
			return ret != 0;
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		public static bool InitForD3D(ref SDLWindow window)
		{
			fixed (SDLWindow* pwindow = &window)
			{
				byte ret = InitForD3DNative((SDLWindow*)pwindow);
				return ret != 0;
			}
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static byte InitForMetalNative(SDLWindow* window)
		{
			#if NET5_0_OR_GREATER
			return ((delegate* unmanaged[Cdecl]<SDLWindow*, byte>)funcTable[5])(window);
			#else
			return (byte)((delegate* unmanaged[Cdecl]<nint, byte>)funcTable[5])((nint)window);
			#endif
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		public static bool InitForMetal(SDLWindowPtr window)
		{
			byte ret = InitForMetalNative(window);
			return ret != 0;
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		public static bool InitForMetal(ref SDLWindow window)
		{
			fixed (SDLWindow* pwindow = &window)
			{
				byte ret = InitForMetalNative((SDLWindow*)pwindow);
				return ret != 0;
			}
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static byte InitForSDLRendererNative(SDLWindow* window, SDLRenderer* renderer)
		{
			#if NET5_0_OR_GREATER
			return ((delegate* unmanaged[Cdecl]<SDLWindow*, SDLRenderer*, byte>)funcTable[6])(window, renderer);
			#else
			return (byte)((delegate* unmanaged[Cdecl]<nint, nint, byte>)funcTable[6])((nint)window, (nint)renderer);
			#endif
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		public static bool InitForSDLRenderer(SDLWindowPtr window, SDLRendererPtr renderer)
		{
			byte ret = InitForSDLRendererNative(window, renderer);
			return ret != 0;
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		public static bool InitForSDLRenderer(ref SDLWindow window, SDLRendererPtr renderer)
		{
			fixed (SDLWindow* pwindow = &window)
			{
				byte ret = InitForSDLRendererNative((SDLWindow*)pwindow, renderer);
				return ret != 0;
			}
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		public static bool InitForSDLRenderer(SDLWindowPtr window, ref SDLRenderer renderer)
		{
			fixed (SDLRenderer* prenderer = &renderer)
			{
				byte ret = InitForSDLRendererNative(window, (SDLRenderer*)prenderer);
				return ret != 0;
			}
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		public static bool InitForSDLRenderer(ref SDLWindow window, ref SDLRenderer renderer)
		{
			fixed (SDLWindow* pwindow = &window)
			{
				fixed (SDLRenderer* prenderer = &renderer)
				{
					byte ret = InitForSDLRendererNative((SDLWindow*)pwindow, (SDLRenderer*)prenderer);
					return ret != 0;
				}
			}
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static byte InitForOtherNative(SDLWindow* window)
		{
			#if NET5_0_OR_GREATER
			return ((delegate* unmanaged[Cdecl]<SDLWindow*, byte>)funcTable[7])(window);
			#else
			return (byte)((delegate* unmanaged[Cdecl]<nint, byte>)funcTable[7])((nint)window);
			#endif
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		public static bool InitForOther(SDLWindowPtr window)
		{
			byte ret = InitForOtherNative(window);
			return ret != 0;
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		public static bool InitForOther(ref SDLWindow window)
		{
			fixed (SDLWindow* pwindow = &window)
			{
				byte ret = InitForOtherNative((SDLWindow*)pwindow);
				return ret != 0;
			}
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void ShutdownNative()
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<void>)funcTable[8])();
			#else
			((delegate* unmanaged[Cdecl]<void>)funcTable[8])();
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
			((delegate* unmanaged[Cdecl]<void>)funcTable[9])();
			#else
			((delegate* unmanaged[Cdecl]<void>)funcTable[9])();
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
		/// To be documented.
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static byte ProcessEventNative(SDLEvent* evnt)
		{
			#if NET5_0_OR_GREATER
			return ((delegate* unmanaged[Cdecl]<SDLEvent*, byte>)funcTable[10])(evnt);
			#else
			return (byte)((delegate* unmanaged[Cdecl]<nint, byte>)funcTable[10])((nint)evnt);
			#endif
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		public static bool ProcessEvent(SDLEventPtr evnt)
		{
			byte ret = ProcessEventNative(evnt);
			return ret != 0;
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		public static bool ProcessEvent(ref SDLEvent evnt)
		{
			fixed (SDLEvent* pevnt = &evnt)
			{
				byte ret = ProcessEventNative((SDLEvent*)pevnt);
				return ret != 0;
			}
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void SetGamepadModeNative(ImGuiImplSDL2GamepadMode mode, SDLGameController** manualGamepadsArray, int manualGamepadsCount)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<ImGuiImplSDL2GamepadMode, SDLGameController**, int, void>)funcTable[11])(mode, manualGamepadsArray, manualGamepadsCount);
			#else
			((delegate* unmanaged[Cdecl]<ImGuiImplSDL2GamepadMode, nint, int, void>)funcTable[11])(mode, (nint)manualGamepadsArray, manualGamepadsCount);
			#endif
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		public static void SetGamepadMode(ImGuiImplSDL2GamepadMode mode, SDLGameControllerPtrPtr manualGamepadsArray, int manualGamepadsCount)
		{
			SetGamepadModeNative(mode, manualGamepadsArray, manualGamepadsCount);
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		public static void SetGamepadMode(ImGuiImplSDL2GamepadMode mode, ref SDLGameController* manualGamepadsArray, int manualGamepadsCount)
		{
			fixed (SDLGameController** pmanualGamepadsArray = &manualGamepadsArray)
			{
				SetGamepadModeNative(mode, (SDLGameController**)pmanualGamepadsArray, manualGamepadsCount);
			}
		}

		/// <summary>
		/// Follow "Getting Started" link and check examples/ folder to learn about using backends!<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static byte SDLRenderer2InitNative(SDLRenderer* renderer)
		{
			#if NET5_0_OR_GREATER
			return ((delegate* unmanaged[Cdecl]<SDLRenderer*, byte>)funcTable[12])(renderer);
			#else
			return (byte)((delegate* unmanaged[Cdecl]<nint, byte>)funcTable[12])((nint)renderer);
			#endif
		}

		/// <summary>
		/// Follow "Getting Started" link and check examples/ folder to learn about using backends!<br/>
		/// </summary>
		public static bool SDLRenderer2Init(SDLRendererPtr renderer)
		{
			byte ret = SDLRenderer2InitNative(renderer);
			return ret != 0;
		}

		/// <summary>
		/// Follow "Getting Started" link and check examples/ folder to learn about using backends!<br/>
		/// </summary>
		public static bool SDLRenderer2Init(ref SDLRenderer renderer)
		{
			fixed (SDLRenderer* prenderer = &renderer)
			{
				byte ret = SDLRenderer2InitNative((SDLRenderer*)prenderer);
				return ret != 0;
			}
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void SDLRenderer2ShutdownNative()
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<void>)funcTable[13])();
			#else
			((delegate* unmanaged[Cdecl]<void>)funcTable[13])();
			#endif
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		public static void SDLRenderer2Shutdown()
		{
			SDLRenderer2ShutdownNative();
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void SDLRenderer2NewFrameNative()
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<void>)funcTable[14])();
			#else
			((delegate* unmanaged[Cdecl]<void>)funcTable[14])();
			#endif
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		public static void SDLRenderer2NewFrame()
		{
			SDLRenderer2NewFrameNative();
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void SDLRenderer2RenderDrawDataNative(ImDrawData* drawData, SDLRenderer* renderer)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<ImDrawData*, SDLRenderer*, void>)funcTable[15])(drawData, renderer);
			#else
			((delegate* unmanaged[Cdecl]<nint, nint, void>)funcTable[15])((nint)drawData, (nint)renderer);
			#endif
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		public static void SDLRenderer2RenderDrawData(ImDrawDataPtr drawData, SDLRendererPtr renderer)
		{
			SDLRenderer2RenderDrawDataNative(drawData, renderer);
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		public static void SDLRenderer2RenderDrawData(ref ImDrawData drawData, SDLRendererPtr renderer)
		{
			fixed (ImDrawData* pdrawData = &drawData)
			{
				SDLRenderer2RenderDrawDataNative((ImDrawData*)pdrawData, renderer);
			}
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		public static void SDLRenderer2RenderDrawData(ImDrawDataPtr drawData, ref SDLRenderer renderer)
		{
			fixed (SDLRenderer* prenderer = &renderer)
			{
				SDLRenderer2RenderDrawDataNative(drawData, (SDLRenderer*)prenderer);
			}
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		public static void SDLRenderer2RenderDrawData(ref ImDrawData drawData, ref SDLRenderer renderer)
		{
			fixed (ImDrawData* pdrawData = &drawData)
			{
				fixed (SDLRenderer* prenderer = &renderer)
				{
					SDLRenderer2RenderDrawDataNative((ImDrawData*)pdrawData, (SDLRenderer*)prenderer);
				}
			}
		}

		/// <summary>
		/// Called by Init/NewFrame/Shutdown<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static byte SDLRenderer2CreateFontsTextureNative()
		{
			#if NET5_0_OR_GREATER
			return ((delegate* unmanaged[Cdecl]<byte>)funcTable[16])();
			#else
			return (byte)((delegate* unmanaged[Cdecl]<byte>)funcTable[16])();
			#endif
		}

		/// <summary>
		/// Called by Init/NewFrame/Shutdown<br/>
		/// </summary>
		public static bool SDLRenderer2CreateFontsTexture()
		{
			byte ret = SDLRenderer2CreateFontsTextureNative();
			return ret != 0;
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void SDLRenderer2DestroyFontsTextureNative()
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<void>)funcTable[17])();
			#else
			((delegate* unmanaged[Cdecl]<void>)funcTable[17])();
			#endif
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		public static void SDLRenderer2DestroyFontsTexture()
		{
			SDLRenderer2DestroyFontsTextureNative();
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static byte SDLRenderer2CreateDeviceObjectsNative()
		{
			#if NET5_0_OR_GREATER
			return ((delegate* unmanaged[Cdecl]<byte>)funcTable[18])();
			#else
			return (byte)((delegate* unmanaged[Cdecl]<byte>)funcTable[18])();
			#endif
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		public static bool SDLRenderer2CreateDeviceObjects()
		{
			byte ret = SDLRenderer2CreateDeviceObjectsNative();
			return ret != 0;
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void SDLRenderer2DestroyDeviceObjectsNative()
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<void>)funcTable[19])();
			#else
			((delegate* unmanaged[Cdecl]<void>)funcTable[19])();
			#endif
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		public static void SDLRenderer2DestroyDeviceObjects()
		{
			SDLRenderer2DestroyDeviceObjectsNative();
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static byte OSXInitNative(void* view)
		{
			#if NET5_0_OR_GREATER
			return ((delegate* unmanaged[Cdecl]<void*, byte>)funcTable[20])(view);
			#else
			return (byte)((delegate* unmanaged[Cdecl]<nint, byte>)funcTable[20])((nint)view);
			#endif
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		public static bool OSXInit(void* view)
		{
			byte ret = OSXInitNative(view);
			return ret != 0;
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void OSXShutdownNative()
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<void>)funcTable[21])();
			#else
			((delegate* unmanaged[Cdecl]<void>)funcTable[21])();
			#endif
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		public static void OSXShutdown()
		{
			OSXShutdownNative();
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void OSXNewFrameNative(void* view)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<void*, void>)funcTable[22])(view);
			#else
			((delegate* unmanaged[Cdecl]<nint, void>)funcTable[22])((nint)view);
			#endif
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		public static void OSXNewFrame(void* view)
		{
			OSXNewFrameNative(view);
		}

		/// <summary>
		/// Follow "Getting Started" link and check examples/ folder to learn about using backends!<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static byte MetalInitNative(MTLDevice* device)
		{
			#if NET5_0_OR_GREATER
			return ((delegate* unmanaged[Cdecl]<MTLDevice*, byte>)funcTable[23])(device);
			#else
			return (byte)((delegate* unmanaged[Cdecl]<nint, byte>)funcTable[23])((nint)device);
			#endif
		}

		/// <summary>
		/// Follow "Getting Started" link and check examples/ folder to learn about using backends!<br/>
		/// </summary>
		public static bool MetalInit(MTLDevicePtr device)
		{
			byte ret = MetalInitNative(device);
			return ret != 0;
		}

		/// <summary>
		/// Follow "Getting Started" link and check examples/ folder to learn about using backends!<br/>
		/// </summary>
		public static bool MetalInit(ref MTLDevice device)
		{
			fixed (MTLDevice* pdevice = &device)
			{
				byte ret = MetalInitNative((MTLDevice*)pdevice);
				return ret != 0;
			}
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void MetalShutdownNative()
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<void>)funcTable[24])();
			#else
			((delegate* unmanaged[Cdecl]<void>)funcTable[24])();
			#endif
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		public static void MetalShutdown()
		{
			MetalShutdownNative();
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void MetalNewFrameNative(MTLRenderPassDescriptor* renderPassDescriptor)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<MTLRenderPassDescriptor*, void>)funcTable[25])(renderPassDescriptor);
			#else
			((delegate* unmanaged[Cdecl]<nint, void>)funcTable[25])((nint)renderPassDescriptor);
			#endif
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		public static void MetalNewFrame(MTLRenderPassDescriptorPtr renderPassDescriptor)
		{
			MetalNewFrameNative(renderPassDescriptor);
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		public static void MetalNewFrame(ref MTLRenderPassDescriptor renderPassDescriptor)
		{
			fixed (MTLRenderPassDescriptor* prenderPassDescriptor = &renderPassDescriptor)
			{
				MetalNewFrameNative((MTLRenderPassDescriptor*)prenderPassDescriptor);
			}
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void MetalRenderDrawDataNative(ImDrawData* drawData, MTLCommandBuffer* commandBuffer, MTLRenderCommandEncoder* commandEncoder)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<ImDrawData*, MTLCommandBuffer*, MTLRenderCommandEncoder*, void>)funcTable[26])(drawData, commandBuffer, commandEncoder);
			#else
			((delegate* unmanaged[Cdecl]<nint, nint, nint, void>)funcTable[26])((nint)drawData, (nint)commandBuffer, (nint)commandEncoder);
			#endif
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		public static void MetalRenderDrawData(ImDrawDataPtr drawData, MTLCommandBufferPtr commandBuffer, MTLRenderCommandEncoderPtr commandEncoder)
		{
			MetalRenderDrawDataNative(drawData, commandBuffer, commandEncoder);
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		public static void MetalRenderDrawData(ref ImDrawData drawData, MTLCommandBufferPtr commandBuffer, MTLRenderCommandEncoderPtr commandEncoder)
		{
			fixed (ImDrawData* pdrawData = &drawData)
			{
				MetalRenderDrawDataNative((ImDrawData*)pdrawData, commandBuffer, commandEncoder);
			}
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		public static void MetalRenderDrawData(ImDrawDataPtr drawData, ref MTLCommandBuffer commandBuffer, MTLRenderCommandEncoderPtr commandEncoder)
		{
			fixed (MTLCommandBuffer* pcommandBuffer = &commandBuffer)
			{
				MetalRenderDrawDataNative(drawData, (MTLCommandBuffer*)pcommandBuffer, commandEncoder);
			}
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		public static void MetalRenderDrawData(ref ImDrawData drawData, ref MTLCommandBuffer commandBuffer, MTLRenderCommandEncoderPtr commandEncoder)
		{
			fixed (ImDrawData* pdrawData = &drawData)
			{
				fixed (MTLCommandBuffer* pcommandBuffer = &commandBuffer)
				{
					MetalRenderDrawDataNative((ImDrawData*)pdrawData, (MTLCommandBuffer*)pcommandBuffer, commandEncoder);
				}
			}
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		public static void MetalRenderDrawData(ImDrawDataPtr drawData, MTLCommandBufferPtr commandBuffer, ref MTLRenderCommandEncoder commandEncoder)
		{
			fixed (MTLRenderCommandEncoder* pcommandEncoder = &commandEncoder)
			{
				MetalRenderDrawDataNative(drawData, commandBuffer, (MTLRenderCommandEncoder*)pcommandEncoder);
			}
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		public static void MetalRenderDrawData(ref ImDrawData drawData, MTLCommandBufferPtr commandBuffer, ref MTLRenderCommandEncoder commandEncoder)
		{
			fixed (ImDrawData* pdrawData = &drawData)
			{
				fixed (MTLRenderCommandEncoder* pcommandEncoder = &commandEncoder)
				{
					MetalRenderDrawDataNative((ImDrawData*)pdrawData, commandBuffer, (MTLRenderCommandEncoder*)pcommandEncoder);
				}
			}
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		public static void MetalRenderDrawData(ImDrawDataPtr drawData, ref MTLCommandBuffer commandBuffer, ref MTLRenderCommandEncoder commandEncoder)
		{
			fixed (MTLCommandBuffer* pcommandBuffer = &commandBuffer)
			{
				fixed (MTLRenderCommandEncoder* pcommandEncoder = &commandEncoder)
				{
					MetalRenderDrawDataNative(drawData, (MTLCommandBuffer*)pcommandBuffer, (MTLRenderCommandEncoder*)pcommandEncoder);
				}
			}
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		public static void MetalRenderDrawData(ref ImDrawData drawData, ref MTLCommandBuffer commandBuffer, ref MTLRenderCommandEncoder commandEncoder)
		{
			fixed (ImDrawData* pdrawData = &drawData)
			{
				fixed (MTLCommandBuffer* pcommandBuffer = &commandBuffer)
				{
					fixed (MTLRenderCommandEncoder* pcommandEncoder = &commandEncoder)
					{
						MetalRenderDrawDataNative((ImDrawData*)pdrawData, (MTLCommandBuffer*)pcommandBuffer, (MTLRenderCommandEncoder*)pcommandEncoder);
					}
				}
			}
		}

		/// <summary>
		/// Called by Init/NewFrame/Shutdown<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static byte MetalCreateFontsTextureNative(MTLDevice* device)
		{
			#if NET5_0_OR_GREATER
			return ((delegate* unmanaged[Cdecl]<MTLDevice*, byte>)funcTable[27])(device);
			#else
			return (byte)((delegate* unmanaged[Cdecl]<nint, byte>)funcTable[27])((nint)device);
			#endif
		}

		/// <summary>
		/// Called by Init/NewFrame/Shutdown<br/>
		/// </summary>
		public static bool MetalCreateFontsTexture(MTLDevicePtr device)
		{
			byte ret = MetalCreateFontsTextureNative(device);
			return ret != 0;
		}

		/// <summary>
		/// Called by Init/NewFrame/Shutdown<br/>
		/// </summary>
		public static bool MetalCreateFontsTexture(ref MTLDevice device)
		{
			fixed (MTLDevice* pdevice = &device)
			{
				byte ret = MetalCreateFontsTextureNative((MTLDevice*)pdevice);
				return ret != 0;
			}
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void MetalDestroyFontsTextureNative()
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<void>)funcTable[28])();
			#else
			((delegate* unmanaged[Cdecl]<void>)funcTable[28])();
			#endif
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		public static void MetalDestroyFontsTexture()
		{
			MetalDestroyFontsTextureNative();
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static byte MetalCreateDeviceObjectsNative(MTLDevice* device)
		{
			#if NET5_0_OR_GREATER
			return ((delegate* unmanaged[Cdecl]<MTLDevice*, byte>)funcTable[29])(device);
			#else
			return (byte)((delegate* unmanaged[Cdecl]<nint, byte>)funcTable[29])((nint)device);
			#endif
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		public static bool MetalCreateDeviceObjects(MTLDevicePtr device)
		{
			byte ret = MetalCreateDeviceObjectsNative(device);
			return ret != 0;
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		public static bool MetalCreateDeviceObjects(ref MTLDevice device)
		{
			fixed (MTLDevice* pdevice = &device)
			{
				byte ret = MetalCreateDeviceObjectsNative((MTLDevice*)pdevice);
				return ret != 0;
			}
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void MetalDestroyDeviceObjectsNative()
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<void>)funcTable[30])();
			#else
			((delegate* unmanaged[Cdecl]<void>)funcTable[30])();
			#endif
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		public static void MetalDestroyDeviceObjects()
		{
			MetalDestroyDeviceObjectsNative();
		}

	}
}
