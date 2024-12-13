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
using Hexa.NET.ImGui;

namespace Hexa.NET.ImGui.Backends.Vulkan
{
	/// <summary>
	/// To be documented.
	/// </summary>
	[StructLayout(LayoutKind.Sequential)]
	public partial struct VkPipelineRenderingCreateInfo
	{
		/// <summary>
		/// To be documented.
		/// </summary>
		public uint SType;

		/// <summary>
		/// To be documented.
		/// </summary>
		public unsafe void* PNext;

		/// <summary>
		/// To be documented.
		/// </summary>
		public uint ViewMask;

		/// <summary>
		/// To be documented.
		/// </summary>
		public uint ColorAttachmentCount;

		/// <summary>
		/// To be documented.
		/// </summary>
		public unsafe uint* PColorAttachmentFormats;

		/// <summary>
		/// To be documented.
		/// </summary>
		public uint DepthAttachmentFormat;

		/// <summary>
		/// To be documented.
		/// </summary>
		public uint StencilAttachmentFormat;


		/// <summary>
		/// To be documented.
		/// </summary>
		public unsafe VkPipelineRenderingCreateInfo(uint sType = default, void* pNext = default, uint viewMask = default, uint colorAttachmentCount = default, uint* pColorAttachmentFormats = default, uint depthAttachmentFormat = default, uint stencilAttachmentFormat = default)
		{
			SType = sType;
			PNext = pNext;
			ViewMask = viewMask;
			ColorAttachmentCount = colorAttachmentCount;
			PColorAttachmentFormats = pColorAttachmentFormats;
			DepthAttachmentFormat = depthAttachmentFormat;
			StencilAttachmentFormat = stencilAttachmentFormat;
		}


	}

}
