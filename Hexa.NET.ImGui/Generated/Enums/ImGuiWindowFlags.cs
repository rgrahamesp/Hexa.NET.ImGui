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
	public enum ImGuiWindowFlags : int
	{
		/// <summary>
		/// To be documented.
		/// </summary>
		None = unchecked(0),

		/// <summary>
		/// Disable title-bar<br/>
		/// </summary>
		NoTitleBar = unchecked(1),

		/// <summary>
		/// Disable user resizing with the lower-right grip<br/>
		/// </summary>
		NoResize = unchecked(2),

		/// <summary>
		/// Disable user moving the window<br/>
		/// </summary>
		NoMove = unchecked(4),

		/// <summary>
		/// Disable scrollbars (window can still scroll with mouse or programmatically)<br/>
		/// </summary>
		NoScrollbar = unchecked(8),

		/// <summary>
		/// Disable user vertically scrolling with mouse wheel. On child window, mouse wheel will be forwarded to the parent unless NoScrollbar is also set.<br/>
		/// </summary>
		NoScrollWithMouse = unchecked(16),

		/// <summary>
		/// Disable user collapsing window by double-clicking on it. Also referred to as Window Menu Button (e.g. within a docking node).<br/>
		/// </summary>
		NoCollapse = unchecked(32),

		/// <summary>
		/// Resize every window to its content every frame<br/>
		/// </summary>
		AlwaysAutoResize = unchecked(64),

		/// <summary>
		/// Disable drawing background color (WindowBg, etc.) and outside border. Similar as using SetNextWindowBgAlpha(0.0f).<br/>
		/// </summary>
		NoBackground = unchecked(128),

		/// <summary>
		/// Never loadsave settings in .ini file<br/>
		/// </summary>
		NoSavedSettings = unchecked(256),

		/// <summary>
		/// Disable catching mouse, hovering test with pass through.<br/>
		/// </summary>
		NoMouseInputs = unchecked(512),

		/// <summary>
		/// Has a menu-bar<br/>
		/// </summary>
		MenuBar = unchecked(1024),

		/// <summary>
		/// Allow horizontal scrollbar to appear (off by default). You may use SetNextWindowContentSize(ImVec2(width,0.0f)); prior to calling Begin() to specify width. Read code in imgui_demo in the "Horizontal Scrolling" section.<br/>
		/// </summary>
		HorizontalScrollbar = unchecked(2048),

		/// <summary>
		/// Disable taking focus when transitioning from hidden to visible state<br/>
		/// </summary>
		NoFocusOnAppearing = unchecked(4096),

		/// <summary>
		/// Disable bringing window to front when taking focus (e.g. clicking on it or programmatically giving it focus)<br/>
		/// </summary>
		NoBringToFrontOnFocus = unchecked(8192),

		/// <summary>
		/// Always show vertical scrollbar (even if ContentSize.y &lt; Size.y)<br/>
		/// </summary>
		AlwaysVerticalScrollbar = unchecked(16384),

		/// <summary>
		/// Always show horizontal scrollbar (even if ContentSize.x &lt; Size.x)<br/>
		/// </summary>
		AlwaysHorizontalScrollbar = unchecked(32768),

		/// <summary>
		/// No gamepadkeyboard navigation within the window<br/>
		/// </summary>
		NoNavInputs = unchecked(65536),

		/// <summary>
		/// No focusing toward this window with gamepadkeyboard navigation (e.g. skipped by CTRL+TAB)<br/>
		/// </summary>
		NoNavFocus = unchecked(131072),

		/// <summary>
		/// Display a dot next to the title. When used in a tabdocking context, tab is selected when clicking the X + closure is not assumed (will wait for user to stop submitting the tab). Otherwise closure is assumed when pressing the X, so if you keep submitting the tab may reappear at end of tab bar.<br/>
		/// </summary>
		UnsavedDocument = unchecked(262144),

		/// <summary>
		/// Disable docking of this window<br/>
		/// </summary>
		NoDocking = unchecked(524288),

		/// <summary>
		/// To be documented.
		/// </summary>
		NoNav = unchecked(196608),

		/// <summary>
		/// To be documented.
		/// </summary>
		NoDecoration = unchecked(43),

		/// <summary>
		/// To be documented.
		/// </summary>
		NoInputs = unchecked(197120),

		/// <summary>
		/// Don't use! For internal use by BeginChild()<br/>
		/// </summary>
		ChildWindow = unchecked(16777216),

		/// <summary>
		/// Don't use! For internal use by BeginTooltip()<br/>
		/// </summary>
		Tooltip = unchecked(33554432),

		/// <summary>
		/// Don't use! For internal use by BeginPopup()<br/>
		/// </summary>
		Popup = unchecked(67108864),

		/// <summary>
		/// Don't use! For internal use by BeginPopupModal()<br/>
		/// </summary>
		Modal = unchecked(134217728),

		/// <summary>
		/// Don't use! For internal use by BeginMenu()<br/>
		/// </summary>
		ChildMenu = unchecked(268435456),

		/// <summary>
		/// Don't use! For internal use by Begin()NewFrame()<br/>
		/// </summary>
		DockNodeHost = unchecked(536870912),
	}
}
