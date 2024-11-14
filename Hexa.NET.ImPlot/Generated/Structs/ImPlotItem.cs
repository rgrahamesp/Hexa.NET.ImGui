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

namespace Hexa.NET.ImPlot
{
	/// <summary>
	/// To be documented.
	/// </summary>
	[StructLayout(LayoutKind.Sequential)]
	public partial struct ImPlotItem
	{
		/// <summary>
		/// To be documented.
		/// </summary>
		public int ID;

		/// <summary>
		/// To be documented.
		/// </summary>
		public uint Color;

		/// <summary>
		/// To be documented.
		/// </summary>
		public ImRect LegendHoverRect;

		/// <summary>
		/// To be documented.
		/// </summary>
		public int NameOffset;

		/// <summary>
		/// To be documented.
		/// </summary>
		public byte Show;

		/// <summary>
		/// To be documented.
		/// </summary>
		public byte LegendHovered;

		/// <summary>
		/// To be documented.
		/// </summary>
		public byte SeenThisFrame;


		/// <summary>
		/// To be documented.
		/// </summary>
		public unsafe ImPlotItem(int id = default, uint color = default, ImRect legendHoverRect = default, int nameOffset = default, bool show = default, bool legendHovered = default, bool seenThisFrame = default)
		{
			ID = id;
			Color = color;
			LegendHoverRect = legendHoverRect;
			NameOffset = nameOffset;
			Show = show ? (byte)1 : (byte)0;
			LegendHovered = legendHovered ? (byte)1 : (byte)0;
			SeenThisFrame = seenThisFrame ? (byte)1 : (byte)0;
		}


		/// <summary>
		/// To be documented.
		/// </summary>
		public unsafe void Destroy()
		{
			fixed (ImPlotItem* @this = &this)
			{
				ImPlot.DestroyNative(@this);
			}
		}

	}

	/// <summary>
	/// To be documented.
	/// </summary>
	#if NET5_0_OR_GREATER
	[DebuggerDisplay("{DebuggerDisplay,nq}")]
	#endif
	public unsafe struct ImPlotItemPtr : IEquatable<ImPlotItemPtr>
	{
		public ImPlotItemPtr(ImPlotItem* handle) { Handle = handle; }

		public ImPlotItem* Handle;

		public bool IsNull => Handle == null;

		public static ImPlotItemPtr Null => new ImPlotItemPtr(null);

		public ImPlotItem this[int index] { get => Handle[index]; set => Handle[index] = value; }

		public static implicit operator ImPlotItemPtr(ImPlotItem* handle) => new ImPlotItemPtr(handle);

		public static implicit operator ImPlotItem*(ImPlotItemPtr handle) => handle.Handle;

		public static bool operator ==(ImPlotItemPtr left, ImPlotItemPtr right) => left.Handle == right.Handle;

		public static bool operator !=(ImPlotItemPtr left, ImPlotItemPtr right) => left.Handle != right.Handle;

		public static bool operator ==(ImPlotItemPtr left, ImPlotItem* right) => left.Handle == right;

		public static bool operator !=(ImPlotItemPtr left, ImPlotItem* right) => left.Handle != right;

		public bool Equals(ImPlotItemPtr other) => Handle == other.Handle;

		/// <inheritdoc/>
		public override bool Equals(object obj) => obj is ImPlotItemPtr handle && Equals(handle);

		/// <inheritdoc/>
		public override int GetHashCode() => ((nuint)Handle).GetHashCode();

		#if NET5_0_OR_GREATER
		private string DebuggerDisplay => string.Format("ImPlotItemPtr [0x{0}]", ((nuint)Handle).ToString("X"));
		#endif
		/// <summary>
		/// To be documented.
		/// </summary>
		public ref int ID => ref Unsafe.AsRef<int>(&Handle->ID);
		/// <summary>
		/// To be documented.
		/// </summary>
		public ref uint Color => ref Unsafe.AsRef<uint>(&Handle->Color);
		/// <summary>
		/// To be documented.
		/// </summary>
		public ref ImRect LegendHoverRect => ref Unsafe.AsRef<ImRect>(&Handle->LegendHoverRect);
		/// <summary>
		/// To be documented.
		/// </summary>
		public ref int NameOffset => ref Unsafe.AsRef<int>(&Handle->NameOffset);
		/// <summary>
		/// To be documented.
		/// </summary>
		public ref bool Show => ref Unsafe.AsRef<bool>(&Handle->Show);
		/// <summary>
		/// To be documented.
		/// </summary>
		public ref bool LegendHovered => ref Unsafe.AsRef<bool>(&Handle->LegendHovered);
		/// <summary>
		/// To be documented.
		/// </summary>
		public ref bool SeenThisFrame => ref Unsafe.AsRef<bool>(&Handle->SeenThisFrame);
		/// <summary>
		/// To be documented.
		/// </summary>
		public unsafe void Destroy()
		{
			ImPlot.DestroyNative(Handle);
		}

	}

}
