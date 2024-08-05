// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using System;
using HexaGen.Runtime;
using System.Numerics;

namespace Hexa.NET.ImGui
{
	/// <summary>
	/// To be documented.
	/// </summary>
	public enum ImDrawListFlags : int
	{
		/// <summary>
		/// To be documented.
		/// </summary>
		None = unchecked(0),

		/// <summary>
		/// Enable anti-aliased linesborders (*2 the number of triangles for 1.0f wide line or lines thin enough to be drawn using textures, otherwise *3 the number of triangles)<br/>
		/// </summary>
		AntiAliasedLines = unchecked(1),

		/// <summary>
		/// Enable anti-aliased linesborders using textures when possible. Require backend to render with bilinear filtering (NOT pointnearest filtering).<br/>
		/// </summary>
		AntiAliasedLinesUseTex = unchecked(2),

		/// <summary>
		/// Enable anti-aliased edge around filled shapes (rounded rectangles, circles).<br/>
		/// </summary>
		AntiAliasedFill = unchecked(4),

		/// <summary>
		/// Can emit 'VtxOffset &gt; 0' to allow large meshes. Set when 'ImGuiBackendFlags_RendererHasVtxOffset' is enabled.<br/>
		/// </summary>
		AllowVtxOffset = unchecked(8),
	}
}
