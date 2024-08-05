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

namespace Hexa.NET.ImNodes
{
	/// <summary>
	/// To be documented.
	/// </summary>
	[StructLayout(LayoutKind.Sequential)]
	public partial struct ImNodesEditorContext
	{


	}

	/// <summary>
	/// To be documented.
	/// </summary>
	#if NET5_0_OR_GREATER
	[DebuggerDisplay("{DebuggerDisplay,nq}")]
	#endif
	public unsafe struct ImNodesEditorContextPtr : IEquatable<ImNodesEditorContextPtr>
	{
		public ImNodesEditorContextPtr(ImNodesEditorContext* handle) { Handle = handle; }

		public ImNodesEditorContext* Handle;

		public bool IsNull => Handle == null;

		public static ImNodesEditorContextPtr Null => new ImNodesEditorContextPtr(null);

		public ImNodesEditorContext this[int index] { get => Handle[index]; set => Handle[index] = value; }

		public static implicit operator ImNodesEditorContextPtr(ImNodesEditorContext* handle) => new ImNodesEditorContextPtr(handle);

		public static implicit operator ImNodesEditorContext*(ImNodesEditorContextPtr handle) => handle.Handle;

		public static bool operator ==(ImNodesEditorContextPtr left, ImNodesEditorContextPtr right) => left.Handle == right.Handle;

		public static bool operator !=(ImNodesEditorContextPtr left, ImNodesEditorContextPtr right) => left.Handle != right.Handle;

		public static bool operator ==(ImNodesEditorContextPtr left, ImNodesEditorContext* right) => left.Handle == right;

		public static bool operator !=(ImNodesEditorContextPtr left, ImNodesEditorContext* right) => left.Handle != right;

		public bool Equals(ImNodesEditorContextPtr other) => Handle == other.Handle;

		/// <inheritdoc/>
		public override bool Equals(object obj) => obj is ImNodesEditorContextPtr handle && Equals(handle);

		/// <inheritdoc/>
		public override int GetHashCode() => ((nuint)Handle).GetHashCode();

		#if NET5_0_OR_GREATER
		private string DebuggerDisplay => string.Format("ImNodesEditorContextPtr [0x{0}]", ((nuint)Handle).ToString("X"));
		#endif
	}

}
