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
using System.Runtime.InteropServices;
using HexaGen.Runtime;
using System.Numerics;

namespace Hexa.NET.ImGui
{
	/// <summary>
	/// To be documented.
	/// </summary>
	#if NET5_0_OR_GREATER
	[DebuggerDisplay("{DebuggerDisplay,nq}")]
	#endif
	public readonly partial struct ImFileHandle : IEquatable<ImFileHandle>
	{
		public ImFileHandle(nint handle) { Handle = handle; }
		public nint Handle { get; }
		public bool IsNull => Handle == 0;
		public static ImFileHandle Null => new ImFileHandle(0);
		public static implicit operator ImFileHandle(nint handle) => new ImFileHandle(handle);
		public static bool operator ==(ImFileHandle left, ImFileHandle right) => left.Handle == right.Handle;
		public static bool operator !=(ImFileHandle left, ImFileHandle right) => left.Handle != right.Handle;
		public static bool operator ==(ImFileHandle left, nint right) => left.Handle == right;
		public static bool operator !=(ImFileHandle left, nint right) => left.Handle != right;
		public bool Equals(ImFileHandle other) => Handle == other.Handle;
		/// <inheritdoc/>
		public override bool Equals(object obj) => obj is ImFileHandle handle && Equals(handle);
		/// <inheritdoc/>
		public override int GetHashCode() => Handle.GetHashCode();
		#if NET5_0_OR_GREATER
		private string DebuggerDisplay => string.Format("ImFileHandle [0x{0}]", Handle.ToString("X"));
		#endif
	}
}
