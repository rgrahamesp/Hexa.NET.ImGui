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

namespace Hexa.NET.ImGuiNodeEditor
{
	/// <summary>
	/// ------------------------------------------------------------------------------<br/>
	/// </summary>
	[NativeName(NativeNameType.StructOrClass, "EditorContext")]
	[StructLayout(LayoutKind.Sequential)]
	public partial struct EditorContext
	{


	}

	/// <summary>
	/// ------------------------------------------------------------------------------<br/>
	/// </summary>
	[NativeName(NativeNameType.Typedef, "EditorContext")]
	#if NET5_0_OR_GREATER
	[DebuggerDisplay("{DebuggerDisplay,nq}")]
	#endif
	public unsafe struct EditorContextPtr : IEquatable<EditorContextPtr>
	{
		public EditorContextPtr(EditorContext* handle) { Handle = handle; }

		public EditorContext* Handle;

		public bool IsNull => Handle == null;

		public static EditorContextPtr Null => new EditorContextPtr(null);

		public EditorContext this[int index] { get => Handle[index]; set => Handle[index] = value; }

		public static implicit operator EditorContextPtr(EditorContext* handle) => new EditorContextPtr(handle);

		public static implicit operator EditorContext*(EditorContextPtr handle) => handle.Handle;

		public static bool operator ==(EditorContextPtr left, EditorContextPtr right) => left.Handle == right.Handle;

		public static bool operator !=(EditorContextPtr left, EditorContextPtr right) => left.Handle != right.Handle;

		public static bool operator ==(EditorContextPtr left, EditorContext* right) => left.Handle == right;

		public static bool operator !=(EditorContextPtr left, EditorContext* right) => left.Handle != right;

		public bool Equals(EditorContextPtr other) => Handle == other.Handle;

		/// <inheritdoc/>
		public override bool Equals(object obj) => obj is EditorContextPtr handle && Equals(handle);

		/// <inheritdoc/>
		public override int GetHashCode() => ((nuint)Handle).GetHashCode();

		#if NET5_0_OR_GREATER
		private string DebuggerDisplay => string.Format("EditorContextPtr [0x{0}]", ((nuint)Handle).ToString("X"));
		#endif
	}

}
