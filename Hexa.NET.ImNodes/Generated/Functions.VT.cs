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

namespace Hexa.NET.ImNodes
{
	public unsafe partial class ImNodes
	{
		internal static VTable vt;

		public static void InitApi()
		{
			vt = new VTable(GetLibraryName(), 89);
			vt.Load(0, "EmulateThreeButtonMouse_EmulateThreeButtonMouse");
			vt.Load(1, "EmulateThreeButtonMouse_destroy");
			vt.Load(2, "LinkDetachWithModifierClick_LinkDetachWithModifierClick");
			vt.Load(3, "LinkDetachWithModifierClick_destroy");
			vt.Load(4, "MultipleSelectModifier_MultipleSelectModifier");
			vt.Load(5, "MultipleSelectModifier_destroy");
			vt.Load(6, "ImNodesIO_ImNodesIO");
			vt.Load(7, "ImNodesIO_destroy");
			vt.Load(8, "ImNodesStyle_ImNodesStyle");
			vt.Load(9, "ImNodesStyle_destroy");
			vt.Load(10, "ImNodes_SetImGuiContext");
			vt.Load(11, "ImNodes_CreateContext");
			vt.Load(12, "ImNodes_DestroyContext");
			vt.Load(13, "ImNodes_GetCurrentContext");
			vt.Load(14, "ImNodes_SetCurrentContext");
			vt.Load(15, "ImNodes_EditorContextCreate");
			vt.Load(16, "ImNodes_EditorContextFree");
			vt.Load(17, "ImNodes_EditorContextSet");
			vt.Load(18, "ImNodes_EditorContextGetPanning");
			vt.Load(19, "ImNodes_EditorContextResetPanning");
			vt.Load(20, "ImNodes_EditorContextMoveToNode");
			vt.Load(21, "ImNodes_GetIO");
			vt.Load(22, "ImNodes_GetStyle");
			vt.Load(23, "ImNodes_StyleColorsDark");
			vt.Load(24, "ImNodes_StyleColorsClassic");
			vt.Load(25, "ImNodes_StyleColorsLight");
			vt.Load(26, "ImNodes_BeginNodeEditor");
			vt.Load(27, "ImNodes_EndNodeEditor");
			vt.Load(28, "ImNodes_MiniMap");
			vt.Load(29, "ImNodes_PushColorStyle");
			vt.Load(30, "ImNodes_PopColorStyle");
			vt.Load(31, "ImNodes_PushStyleVar_Float");
			vt.Load(32, "ImNodes_PushStyleVar_Vec2");
			vt.Load(33, "ImNodes_PopStyleVar");
			vt.Load(34, "ImNodes_BeginNode");
			vt.Load(35, "ImNodes_EndNode");
			vt.Load(36, "ImNodes_GetNodeDimensions");
			vt.Load(37, "ImNodes_BeginNodeTitleBar");
			vt.Load(38, "ImNodes_EndNodeTitleBar");
			vt.Load(39, "ImNodes_BeginInputAttribute");
			vt.Load(40, "ImNodes_EndInputAttribute");
			vt.Load(41, "ImNodes_BeginOutputAttribute");
			vt.Load(42, "ImNodes_EndOutputAttribute");
			vt.Load(43, "ImNodes_BeginStaticAttribute");
			vt.Load(44, "ImNodes_EndStaticAttribute");
			vt.Load(45, "ImNodes_PushAttributeFlag");
			vt.Load(46, "ImNodes_PopAttributeFlag");
			vt.Load(47, "ImNodes_Link");
			vt.Load(48, "ImNodes_SetNodeDraggable");
			vt.Load(49, "ImNodes_SetNodeScreenSpacePos");
			vt.Load(50, "ImNodes_SetNodeEditorSpacePos");
			vt.Load(51, "ImNodes_SetNodeGridSpacePos");
			vt.Load(52, "ImNodes_GetNodeScreenSpacePos");
			vt.Load(53, "ImNodes_GetNodeEditorSpacePos");
			vt.Load(54, "ImNodes_GetNodeGridSpacePos");
			vt.Load(55, "ImNodes_SnapNodeToGrid");
			vt.Load(56, "ImNodes_IsEditorHovered");
			vt.Load(57, "ImNodes_IsNodeHovered");
			vt.Load(58, "ImNodes_IsLinkHovered");
			vt.Load(59, "ImNodes_IsPinHovered");
			vt.Load(60, "ImNodes_NumSelectedNodes");
			vt.Load(61, "ImNodes_NumSelectedLinks");
			vt.Load(62, "ImNodes_GetSelectedNodes");
			vt.Load(63, "ImNodes_GetSelectedLinks");
			vt.Load(64, "ImNodes_ClearNodeSelection_Nil");
			vt.Load(65, "ImNodes_ClearLinkSelection_Nil");
			vt.Load(66, "ImNodes_SelectNode");
			vt.Load(67, "ImNodes_ClearNodeSelection_Int");
			vt.Load(68, "ImNodes_IsNodeSelected");
			vt.Load(69, "ImNodes_SelectLink");
			vt.Load(70, "ImNodes_ClearLinkSelection_Int");
			vt.Load(71, "ImNodes_IsLinkSelected");
			vt.Load(72, "ImNodes_IsAttributeActive");
			vt.Load(73, "ImNodes_IsAnyAttributeActive");
			vt.Load(74, "ImNodes_IsLinkStarted");
			vt.Load(75, "ImNodes_IsLinkDropped");
			vt.Load(76, "ImNodes_IsLinkCreated_BoolPtr");
			vt.Load(77, "ImNodes_IsLinkCreated_IntPtr");
			vt.Load(78, "ImNodes_IsLinkDestroyed");
			vt.Load(79, "ImNodes_SaveCurrentEditorStateToIniString");
			vt.Load(80, "ImNodes_SaveEditorStateToIniString");
			vt.Load(81, "ImNodes_LoadCurrentEditorStateFromIniString");
			vt.Load(82, "ImNodes_LoadEditorStateFromIniString");
			vt.Load(83, "ImNodes_SaveCurrentEditorStateToIniFile");
			vt.Load(84, "ImNodes_SaveEditorStateToIniFile");
			vt.Load(85, "ImNodes_LoadCurrentEditorStateFromIniFile");
			vt.Load(86, "ImNodes_LoadEditorStateFromIniFile");
			vt.Load(87, "getIOKeyCtrlPtr");
		}

		public static void FreeApi()
		{
			vt.Free();
		}
	}
}
