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

namespace Hexa.NET.ImGui.Backends.SDL3
{
	/// <summary>
	/// To be documented.
	/// </summary>
	[StructLayout(LayoutKind.Explicit)]
	public partial struct SDLEvent
	{


	}

	/// <summary>
	/// To be documented.
	/// </summary>
	#if NET5_0_OR_GREATER
	[DebuggerDisplay("{DebuggerDisplay,nq}")]
	#endif
	public unsafe struct SDLEventPtr : IEquatable<SDLEventPtr>
	{
		public SDLEventPtr(SDLEvent* handle) { Handle = handle; }

		public SDLEvent* Handle;

		public bool IsNull => Handle == null;

		public static SDLEventPtr Null => new SDLEventPtr(null);

		public SDLEvent this[int index] { get => Handle[index]; set => Handle[index] = value; }

		public static implicit operator SDLEventPtr(SDLEvent* handle) => new SDLEventPtr(handle);

		public static implicit operator SDLEvent*(SDLEventPtr handle) => handle.Handle;

		public static bool operator ==(SDLEventPtr left, SDLEventPtr right) => left.Handle == right.Handle;

		public static bool operator !=(SDLEventPtr left, SDLEventPtr right) => left.Handle != right.Handle;

		public static bool operator ==(SDLEventPtr left, SDLEvent* right) => left.Handle == right;

		public static bool operator !=(SDLEventPtr left, SDLEvent* right) => left.Handle != right;

		public bool Equals(SDLEventPtr other) => Handle == other.Handle;

		/// <inheritdoc/>
		public override bool Equals(object obj) => obj is SDLEventPtr handle && Equals(handle);

		/// <inheritdoc/>
		public override int GetHashCode() => ((nuint)Handle).GetHashCode();

		#if NET5_0_OR_GREATER
		private string DebuggerDisplay => string.Format("SDLEventPtr [0x{0}]", ((nuint)Handle).ToString("X"));
		#endif
	}

}
