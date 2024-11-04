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

namespace Hexa.NET.ImGui.Backends.SDL2
{
	/// <summary>
	/// To be documented.
	/// </summary>
	[StructLayout(LayoutKind.Sequential)]
	public partial struct MTLRenderCommandEncoder
	{


	}

	/// <summary>
	/// To be documented.
	/// </summary>
	#if NET5_0_OR_GREATER
	[DebuggerDisplay("{DebuggerDisplay,nq}")]
	#endif
	public unsafe struct MTLRenderCommandEncoderPtr : IEquatable<MTLRenderCommandEncoderPtr>
	{
		public MTLRenderCommandEncoderPtr(MTLRenderCommandEncoder* handle) { Handle = handle; }

		public MTLRenderCommandEncoder* Handle;

		public bool IsNull => Handle == null;

		public static MTLRenderCommandEncoderPtr Null => new MTLRenderCommandEncoderPtr(null);

		public MTLRenderCommandEncoder this[int index] { get => Handle[index]; set => Handle[index] = value; }

		public static implicit operator MTLRenderCommandEncoderPtr(MTLRenderCommandEncoder* handle) => new MTLRenderCommandEncoderPtr(handle);

		public static implicit operator MTLRenderCommandEncoder*(MTLRenderCommandEncoderPtr handle) => handle.Handle;

		public static bool operator ==(MTLRenderCommandEncoderPtr left, MTLRenderCommandEncoderPtr right) => left.Handle == right.Handle;

		public static bool operator !=(MTLRenderCommandEncoderPtr left, MTLRenderCommandEncoderPtr right) => left.Handle != right.Handle;

		public static bool operator ==(MTLRenderCommandEncoderPtr left, MTLRenderCommandEncoder* right) => left.Handle == right;

		public static bool operator !=(MTLRenderCommandEncoderPtr left, MTLRenderCommandEncoder* right) => left.Handle != right;

		public bool Equals(MTLRenderCommandEncoderPtr other) => Handle == other.Handle;

		/// <inheritdoc/>
		public override bool Equals(object obj) => obj is MTLRenderCommandEncoderPtr handle && Equals(handle);

		/// <inheritdoc/>
		public override int GetHashCode() => ((nuint)Handle).GetHashCode();

		#if NET5_0_OR_GREATER
		private string DebuggerDisplay => string.Format("MTLRenderCommandEncoderPtr [0x{0}]", ((nuint)Handle).ToString("X"));
		#endif
	}

}
