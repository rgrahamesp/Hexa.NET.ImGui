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
	/// [Internal] For use by ImDrawListSplitter<br/>
	/// </summary>
	[StructLayout(LayoutKind.Sequential)]
	public partial struct ImDrawChannel
	{
		/// <summary>
		/// To be documented.
		/// </summary>
		public ImVector<ImDrawCmd> CmdBuffer;

		/// <summary>
		/// To be documented.
		/// </summary>
		public ImVector<ushort> IdxBuffer;


		/// <summary>
		/// To be documented.
		/// </summary>
		public unsafe ImDrawChannel(ImVector<ImDrawCmd> cmdBuffer = default, ImVector<ushort> idxBuffer = default)
		{
			CmdBuffer = cmdBuffer;
			IdxBuffer = idxBuffer;
		}


	}

	/// <summary>
	/// To be documented.
	/// </summary>
	#if NET5_0_OR_GREATER
	[DebuggerDisplay("{DebuggerDisplay,nq}")]
	#endif
	public unsafe struct ImDrawChannelPtr : IEquatable<ImDrawChannelPtr>
	{
		public ImDrawChannelPtr(ImDrawChannel* handle) { Handle = handle; }

		public ImDrawChannel* Handle;

		public bool IsNull => Handle == null;

		public static ImDrawChannelPtr Null => new ImDrawChannelPtr(null);

		public ImDrawChannel this[int index] { get => Handle[index]; set => Handle[index] = value; }

		public static implicit operator ImDrawChannelPtr(ImDrawChannel* handle) => new ImDrawChannelPtr(handle);

		public static implicit operator ImDrawChannel*(ImDrawChannelPtr handle) => handle.Handle;

		public static bool operator ==(ImDrawChannelPtr left, ImDrawChannelPtr right) => left.Handle == right.Handle;

		public static bool operator !=(ImDrawChannelPtr left, ImDrawChannelPtr right) => left.Handle != right.Handle;

		public static bool operator ==(ImDrawChannelPtr left, ImDrawChannel* right) => left.Handle == right;

		public static bool operator !=(ImDrawChannelPtr left, ImDrawChannel* right) => left.Handle != right;

		public bool Equals(ImDrawChannelPtr other) => Handle == other.Handle;

		/// <inheritdoc/>
		public override bool Equals(object obj) => obj is ImDrawChannelPtr handle && Equals(handle);

		/// <inheritdoc/>
		public override int GetHashCode() => ((nuint)Handle).GetHashCode();

		#if NET5_0_OR_GREATER
		private string DebuggerDisplay => string.Format("ImDrawChannelPtr [0x{0}]", ((nuint)Handle).ToString("X"));
		#endif
		/// <summary>
		/// To be documented.
		/// </summary>
		public ref ImVector<ImDrawCmd> CmdBuffer => ref Unsafe.AsRef<ImVector<ImDrawCmd>>(&Handle->CmdBuffer);
		/// <summary>
		/// To be documented.
		/// </summary>
		public ref ImVector<ushort> IdxBuffer => ref Unsafe.AsRef<ImVector<ushort>>(&Handle->IdxBuffer);
	}

}
