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
	public partial struct ImPoolImPlotAlignmentData
	{
		/// <summary>
		/// To be documented.
		/// </summary>
		public ImVector<ImPlotAlignmentData> Buf;

		/// <summary>
		/// To be documented.
		/// </summary>
		public ImGuiStorage Map;

		/// <summary>
		/// To be documented.
		/// </summary>
		public int FreeIdx;

		/// <summary>
		/// To be documented.
		/// </summary>
		public int AliveCount;


		/// <summary>
		/// To be documented.
		/// </summary>
		public unsafe ImPoolImPlotAlignmentData(ImVector<ImPlotAlignmentData> buf = default, ImGuiStorage map = default, int freeIdx = default, int aliveCount = default)
		{
			Buf = buf;
			Map = map;
			FreeIdx = freeIdx;
			AliveCount = aliveCount;
		}


	}

}
