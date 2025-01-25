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
	[Flags]
	public enum ImGuiDataType : int
	{
		/// <summary>
		/// signed char  char (with sensible compilers)<br/>
		/// </summary>
		S8 = unchecked(0),

		/// <summary>
		/// unsigned char<br/>
		/// </summary>
		U8 = unchecked(1),

		/// <summary>
		/// short<br/>
		/// </summary>
		S16 = unchecked(2),

		/// <summary>
		/// unsigned short<br/>
		/// </summary>
		U16 = unchecked(3),

		/// <summary>
		/// int<br/>
		/// </summary>
		S32 = unchecked(4),

		/// <summary>
		/// unsigned int<br/>
		/// </summary>
		U32 = unchecked(5),

		/// <summary>
		/// long long  __int64<br/>
		/// </summary>
		S64 = unchecked(6),

		/// <summary>
		/// unsigned long long  unsigned __int64<br/>
		/// </summary>
		U64 = unchecked(7),

		/// <summary>
		/// float<br/>
		/// </summary>
		Float = unchecked(8),

		/// <summary>
		/// double<br/>
		/// </summary>
		Double = unchecked(9),

		/// <summary>
		/// bool (provided for user convenience, not supported by scalar widgets)<br/>
		/// </summary>
		Bool = unchecked(10),

		/// <summary>
		/// char* (provided for user convenience, not supported by scalar widgets)<br/>
		/// </summary>
		String = unchecked(11),

		/// <summary>
		/// To be documented.
		/// </summary>
		Count = unchecked(12),
	}
}
