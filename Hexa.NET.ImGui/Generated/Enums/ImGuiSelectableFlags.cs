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
	public enum ImGuiSelectableFlags : int
	{
		/// <summary>
		/// To be documented.
		/// </summary>
		None = unchecked(0),

		/// <summary>
		/// Clicking this doesn't close parent popup window (overrides ImGuiItemFlags_AutoClosePopups)<br/>
		/// </summary>
		NoAutoClosePopups = unchecked(1),

		/// <summary>
		/// Frame will span all columns of its container table (text will still fit in current column)<br/>
		/// </summary>
		SpanAllColumns = unchecked(2),

		/// <summary>
		/// Generate press events on double clicks too<br/>
		/// </summary>
		AllowDoubleClick = unchecked(4),

		/// <summary>
		/// Cannot be selected, display grayed out text<br/>
		/// </summary>
		Disabled = unchecked(8),

		/// <summary>
		/// (WIP) Hit testing to allow subsequent widgets to overlap this one<br/>
		/// </summary>
		AllowOverlap = unchecked(16),

		/// <summary>
		/// Make the item be displayed as if it is hovered<br/>
		/// </summary>
		Highlight = unchecked(32),
	}
}
