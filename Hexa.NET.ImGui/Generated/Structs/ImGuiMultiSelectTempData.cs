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
	/// To be documented.
	/// </summary>
	[StructLayout(LayoutKind.Sequential)]
	public partial struct ImGuiMultiSelectTempData
	{
		/// <summary>
		/// To be documented.
		/// </summary>
		public ImGuiMultiSelectIO IO;

		/// <summary>
		/// To be documented.
		/// </summary>
		public unsafe ImGuiMultiSelectState* Storage;

		/// <summary>
		/// To be documented.
		/// </summary>
		public uint FocusScopeId;

		/// <summary>
		/// To be documented.
		/// </summary>
		public ImGuiMultiSelectFlags Flags;

		/// <summary>
		/// To be documented.
		/// </summary>
		public Vector2 ScopeRectMin;

		/// <summary>
		/// To be documented.
		/// </summary>
		public Vector2 BackupCursorMaxPos;

		/// <summary>
		/// To be documented.
		/// </summary>
		public long LastSubmittedItem;

		/// <summary>
		/// To be documented.
		/// </summary>
		public uint BoxSelectId;

		/// <summary>
		/// To be documented.
		/// </summary>
		public int KeyMods;

		/// <summary>
		/// To be documented.
		/// </summary>
		public byte LoopRequestSetAll;

		/// <summary>
		/// To be documented.
		/// </summary>
		public byte IsEndIO;

		/// <summary>
		/// To be documented.
		/// </summary>
		public byte IsFocused;

		/// <summary>
		/// To be documented.
		/// </summary>
		public byte IsKeyboardSetRange;

		/// <summary>
		/// To be documented.
		/// </summary>
		public byte NavIdPassedBy;

		/// <summary>
		/// To be documented.
		/// </summary>
		public byte RangeSrcPassedBy;

		/// <summary>
		/// To be documented.
		/// </summary>
		public byte RangeDstPassedBy;


		/// <summary>
		/// To be documented.
		/// </summary>
		public unsafe ImGuiMultiSelectTempData(ImGuiMultiSelectIO io = default, ImGuiMultiSelectState* storage = default, uint focusScopeId = default, ImGuiMultiSelectFlags flags = default, Vector2 scopeRectMin = default, Vector2 backupCursorMaxPos = default, long lastSubmittedItem = default, uint boxSelectId = default, int keyMods = default, byte loopRequestSetAll = default, bool isEndIo = default, bool isFocused = default, bool isKeyboardSetRange = default, bool navIdPassedBy = default, bool rangeSrcPassedBy = default, bool rangeDstPassedBy = default)
		{
			IO = io;
			Storage = storage;
			FocusScopeId = focusScopeId;
			Flags = flags;
			ScopeRectMin = scopeRectMin;
			BackupCursorMaxPos = backupCursorMaxPos;
			LastSubmittedItem = lastSubmittedItem;
			BoxSelectId = boxSelectId;
			KeyMods = keyMods;
			LoopRequestSetAll = loopRequestSetAll;
			IsEndIO = isEndIo ? (byte)1 : (byte)0;
			IsFocused = isFocused ? (byte)1 : (byte)0;
			IsKeyboardSetRange = isKeyboardSetRange ? (byte)1 : (byte)0;
			NavIdPassedBy = navIdPassedBy ? (byte)1 : (byte)0;
			RangeSrcPassedBy = rangeSrcPassedBy ? (byte)1 : (byte)0;
			RangeDstPassedBy = rangeDstPassedBy ? (byte)1 : (byte)0;
		}


	}

	/// <summary>
	/// To be documented.
	/// </summary>
	#if NET5_0_OR_GREATER
	[DebuggerDisplay("{DebuggerDisplay,nq}")]
	#endif
	public unsafe struct ImGuiMultiSelectTempDataPtr : IEquatable<ImGuiMultiSelectTempDataPtr>
	{
		public ImGuiMultiSelectTempDataPtr(ImGuiMultiSelectTempData* handle) { Handle = handle; }

		public ImGuiMultiSelectTempData* Handle;

		public bool IsNull => Handle == null;

		public static ImGuiMultiSelectTempDataPtr Null => new ImGuiMultiSelectTempDataPtr(null);

		public ImGuiMultiSelectTempData this[int index] { get => Handle[index]; set => Handle[index] = value; }

		public static implicit operator ImGuiMultiSelectTempDataPtr(ImGuiMultiSelectTempData* handle) => new ImGuiMultiSelectTempDataPtr(handle);

		public static implicit operator ImGuiMultiSelectTempData*(ImGuiMultiSelectTempDataPtr handle) => handle.Handle;

		public static bool operator ==(ImGuiMultiSelectTempDataPtr left, ImGuiMultiSelectTempDataPtr right) => left.Handle == right.Handle;

		public static bool operator !=(ImGuiMultiSelectTempDataPtr left, ImGuiMultiSelectTempDataPtr right) => left.Handle != right.Handle;

		public static bool operator ==(ImGuiMultiSelectTempDataPtr left, ImGuiMultiSelectTempData* right) => left.Handle == right;

		public static bool operator !=(ImGuiMultiSelectTempDataPtr left, ImGuiMultiSelectTempData* right) => left.Handle != right;

		public bool Equals(ImGuiMultiSelectTempDataPtr other) => Handle == other.Handle;

		/// <inheritdoc/>
		public override bool Equals(object obj) => obj is ImGuiMultiSelectTempDataPtr handle && Equals(handle);

		/// <inheritdoc/>
		public override int GetHashCode() => ((nuint)Handle).GetHashCode();

		#if NET5_0_OR_GREATER
		private string DebuggerDisplay => string.Format("ImGuiMultiSelectTempDataPtr [0x{0}]", ((nuint)Handle).ToString("X"));
		#endif
		/// <summary>
		/// To be documented.
		/// </summary>
		public ref ImGuiMultiSelectIO IO => ref Unsafe.AsRef<ImGuiMultiSelectIO>(&Handle->IO);
		/// <summary>
		/// To be documented.
		/// </summary>
		public ref ImGuiMultiSelectStatePtr Storage => ref Unsafe.AsRef<ImGuiMultiSelectStatePtr>(&Handle->Storage);
		/// <summary>
		/// To be documented.
		/// </summary>
		public ref uint FocusScopeId => ref Unsafe.AsRef<uint>(&Handle->FocusScopeId);
		/// <summary>
		/// To be documented.
		/// </summary>
		public ref ImGuiMultiSelectFlags Flags => ref Unsafe.AsRef<ImGuiMultiSelectFlags>(&Handle->Flags);
		/// <summary>
		/// To be documented.
		/// </summary>
		public ref Vector2 ScopeRectMin => ref Unsafe.AsRef<Vector2>(&Handle->ScopeRectMin);
		/// <summary>
		/// To be documented.
		/// </summary>
		public ref Vector2 BackupCursorMaxPos => ref Unsafe.AsRef<Vector2>(&Handle->BackupCursorMaxPos);
		/// <summary>
		/// To be documented.
		/// </summary>
		public ref long LastSubmittedItem => ref Unsafe.AsRef<long>(&Handle->LastSubmittedItem);
		/// <summary>
		/// To be documented.
		/// </summary>
		public ref uint BoxSelectId => ref Unsafe.AsRef<uint>(&Handle->BoxSelectId);
		/// <summary>
		/// To be documented.
		/// </summary>
		public ref int KeyMods => ref Unsafe.AsRef<int>(&Handle->KeyMods);
		/// <summary>
		/// To be documented.
		/// </summary>
		public ref byte LoopRequestSetAll => ref Unsafe.AsRef<byte>(&Handle->LoopRequestSetAll);
		/// <summary>
		/// To be documented.
		/// </summary>
		public ref bool IsEndIO => ref Unsafe.AsRef<bool>(&Handle->IsEndIO);
		/// <summary>
		/// To be documented.
		/// </summary>
		public ref bool IsFocused => ref Unsafe.AsRef<bool>(&Handle->IsFocused);
		/// <summary>
		/// To be documented.
		/// </summary>
		public ref bool IsKeyboardSetRange => ref Unsafe.AsRef<bool>(&Handle->IsKeyboardSetRange);
		/// <summary>
		/// To be documented.
		/// </summary>
		public ref bool NavIdPassedBy => ref Unsafe.AsRef<bool>(&Handle->NavIdPassedBy);
		/// <summary>
		/// To be documented.
		/// </summary>
		public ref bool RangeSrcPassedBy => ref Unsafe.AsRef<bool>(&Handle->RangeSrcPassedBy);
		/// <summary>
		/// To be documented.
		/// </summary>
		public ref bool RangeDstPassedBy => ref Unsafe.AsRef<bool>(&Handle->RangeDstPassedBy);
	}

}
