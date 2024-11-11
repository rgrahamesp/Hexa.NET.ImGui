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

namespace Hexa.NET.ImGui.Backends.Metal
{
	public unsafe partial class ImGuiImplMetal
	{
		/// <summary>
		/// Follow "Getting Started" link and check examples/ folder to learn about using backends!<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static byte InitNative(MTLDevice* device)
		{
			#if NET5_0_OR_GREATER
			return ((delegate* unmanaged[Cdecl]<MTLDevice*, byte>)funcTable[69])(device);
			#else
			return (byte)((delegate* unmanaged[Cdecl]<nint, byte>)funcTable[69])((nint)device);
			#endif
		}

		/// <summary>
		/// Follow "Getting Started" link and check examples/ folder to learn about using backends!<br/>
		/// </summary>
		public static bool Init(MTLDevicePtr device)
		{
			byte ret = InitNative(device);
			return ret != 0;
		}

		/// <summary>
		/// Follow "Getting Started" link and check examples/ folder to learn about using backends!<br/>
		/// </summary>
		public static bool Init(ref MTLDevice device)
		{
			fixed (MTLDevice* pdevice = &device)
			{
				byte ret = InitNative((MTLDevice*)pdevice);
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
			((delegate* unmanaged[Cdecl]<void>)funcTable[70])();
			#else
			((delegate* unmanaged[Cdecl]<void>)funcTable[70])();
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
		internal static void NewFrameNative(MTLRenderPassDescriptor* renderPassDescriptor)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<MTLRenderPassDescriptor*, void>)funcTable[71])(renderPassDescriptor);
			#else
			((delegate* unmanaged[Cdecl]<nint, void>)funcTable[71])((nint)renderPassDescriptor);
			#endif
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		public static void NewFrame(MTLRenderPassDescriptorPtr renderPassDescriptor)
		{
			NewFrameNative(renderPassDescriptor);
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		public static void NewFrame(ref MTLRenderPassDescriptor renderPassDescriptor)
		{
			fixed (MTLRenderPassDescriptor* prenderPassDescriptor = &renderPassDescriptor)
			{
				NewFrameNative((MTLRenderPassDescriptor*)prenderPassDescriptor);
			}
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void RenderDrawDataNative(ImDrawData* drawData, MTLCommandBuffer* commandBuffer, MTLRenderCommandEncoder* commandEncoder)
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<ImDrawData*, MTLCommandBuffer*, MTLRenderCommandEncoder*, void>)funcTable[72])(drawData, commandBuffer, commandEncoder);
			#else
			((delegate* unmanaged[Cdecl]<nint, nint, nint, void>)funcTable[72])((nint)drawData, (nint)commandBuffer, (nint)commandEncoder);
			#endif
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		public static void RenderDrawData(ImDrawDataPtr drawData, MTLCommandBufferPtr commandBuffer, MTLRenderCommandEncoderPtr commandEncoder)
		{
			RenderDrawDataNative(drawData, commandBuffer, commandEncoder);
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		public static void RenderDrawData(ref ImDrawData drawData, MTLCommandBufferPtr commandBuffer, MTLRenderCommandEncoderPtr commandEncoder)
		{
			fixed (ImDrawData* pdrawData = &drawData)
			{
				RenderDrawDataNative((ImDrawData*)pdrawData, commandBuffer, commandEncoder);
			}
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		public static void RenderDrawData(ImDrawDataPtr drawData, ref MTLCommandBuffer commandBuffer, MTLRenderCommandEncoderPtr commandEncoder)
		{
			fixed (MTLCommandBuffer* pcommandBuffer = &commandBuffer)
			{
				RenderDrawDataNative(drawData, (MTLCommandBuffer*)pcommandBuffer, commandEncoder);
			}
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		public static void RenderDrawData(ref ImDrawData drawData, ref MTLCommandBuffer commandBuffer, MTLRenderCommandEncoderPtr commandEncoder)
		{
			fixed (ImDrawData* pdrawData = &drawData)
			{
				fixed (MTLCommandBuffer* pcommandBuffer = &commandBuffer)
				{
					RenderDrawDataNative((ImDrawData*)pdrawData, (MTLCommandBuffer*)pcommandBuffer, commandEncoder);
				}
			}
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		public static void RenderDrawData(ImDrawDataPtr drawData, MTLCommandBufferPtr commandBuffer, ref MTLRenderCommandEncoder commandEncoder)
		{
			fixed (MTLRenderCommandEncoder* pcommandEncoder = &commandEncoder)
			{
				RenderDrawDataNative(drawData, commandBuffer, (MTLRenderCommandEncoder*)pcommandEncoder);
			}
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		public static void RenderDrawData(ref ImDrawData drawData, MTLCommandBufferPtr commandBuffer, ref MTLRenderCommandEncoder commandEncoder)
		{
			fixed (ImDrawData* pdrawData = &drawData)
			{
				fixed (MTLRenderCommandEncoder* pcommandEncoder = &commandEncoder)
				{
					RenderDrawDataNative((ImDrawData*)pdrawData, commandBuffer, (MTLRenderCommandEncoder*)pcommandEncoder);
				}
			}
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		public static void RenderDrawData(ImDrawDataPtr drawData, ref MTLCommandBuffer commandBuffer, ref MTLRenderCommandEncoder commandEncoder)
		{
			fixed (MTLCommandBuffer* pcommandBuffer = &commandBuffer)
			{
				fixed (MTLRenderCommandEncoder* pcommandEncoder = &commandEncoder)
				{
					RenderDrawDataNative(drawData, (MTLCommandBuffer*)pcommandBuffer, (MTLRenderCommandEncoder*)pcommandEncoder);
				}
			}
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		public static void RenderDrawData(ref ImDrawData drawData, ref MTLCommandBuffer commandBuffer, ref MTLRenderCommandEncoder commandEncoder)
		{
			fixed (ImDrawData* pdrawData = &drawData)
			{
				fixed (MTLCommandBuffer* pcommandBuffer = &commandBuffer)
				{
					fixed (MTLRenderCommandEncoder* pcommandEncoder = &commandEncoder)
					{
						RenderDrawDataNative((ImDrawData*)pdrawData, (MTLCommandBuffer*)pcommandBuffer, (MTLRenderCommandEncoder*)pcommandEncoder);
					}
				}
			}
		}

		/// <summary>
		/// Called by Init/NewFrame/Shutdown<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static byte CreateFontsTextureNative(MTLDevice* device)
		{
			#if NET5_0_OR_GREATER
			return ((delegate* unmanaged[Cdecl]<MTLDevice*, byte>)funcTable[73])(device);
			#else
			return (byte)((delegate* unmanaged[Cdecl]<nint, byte>)funcTable[73])((nint)device);
			#endif
		}

		/// <summary>
		/// Called by Init/NewFrame/Shutdown<br/>
		/// </summary>
		public static bool CreateFontsTexture(MTLDevicePtr device)
		{
			byte ret = CreateFontsTextureNative(device);
			return ret != 0;
		}

		/// <summary>
		/// Called by Init/NewFrame/Shutdown<br/>
		/// </summary>
		public static bool CreateFontsTexture(ref MTLDevice device)
		{
			fixed (MTLDevice* pdevice = &device)
			{
				byte ret = CreateFontsTextureNative((MTLDevice*)pdevice);
				return ret != 0;
			}
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void DestroyFontsTextureNative()
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<void>)funcTable[74])();
			#else
			((delegate* unmanaged[Cdecl]<void>)funcTable[74])();
			#endif
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		public static void DestroyFontsTexture()
		{
			DestroyFontsTextureNative();
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static byte CreateDeviceObjectsNative(MTLDevice* device)
		{
			#if NET5_0_OR_GREATER
			return ((delegate* unmanaged[Cdecl]<MTLDevice*, byte>)funcTable[75])(device);
			#else
			return (byte)((delegate* unmanaged[Cdecl]<nint, byte>)funcTable[75])((nint)device);
			#endif
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		public static bool CreateDeviceObjects(MTLDevicePtr device)
		{
			byte ret = CreateDeviceObjectsNative(device);
			return ret != 0;
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		public static bool CreateDeviceObjects(ref MTLDevice device)
		{
			fixed (MTLDevice* pdevice = &device)
			{
				byte ret = CreateDeviceObjectsNative((MTLDevice*)pdevice);
				return ret != 0;
			}
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void DestroyDeviceObjectsNative()
		{
			#if NET5_0_OR_GREATER
			((delegate* unmanaged[Cdecl]<void>)funcTable[76])();
			#else
			((delegate* unmanaged[Cdecl]<void>)funcTable[76])();
			#endif
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		public static void DestroyDeviceObjects()
		{
			DestroyDeviceObjectsNative();
		}

	}
}
