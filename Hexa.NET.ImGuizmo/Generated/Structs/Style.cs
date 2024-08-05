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

namespace Hexa.NET.ImGuizmo
{
	/// <summary>
	/// To be documented.
	/// </summary>
	[StructLayout(LayoutKind.Sequential)]
	public partial struct Style
	{
		/// <summary>
		/// To be documented.
		/// </summary>
		public float TranslationLineThickness;

		/// <summary>
		/// To be documented.
		/// </summary>
		public float TranslationLineArrowSize;

		/// <summary>
		/// To be documented.
		/// </summary>
		public float RotationLineThickness;

		/// <summary>
		/// To be documented.
		/// </summary>
		public float RotationOuterLineThickness;

		/// <summary>
		/// To be documented.
		/// </summary>
		public float ScaleLineThickness;

		/// <summary>
		/// To be documented.
		/// </summary>
		public float ScaleLineCircleSize;

		/// <summary>
		/// To be documented.
		/// </summary>
		public float HatchedAxisLineThickness;

		/// <summary>
		/// To be documented.
		/// </summary>
		public float CenterCircleSize;

		/// <summary>
		/// To be documented.
		/// </summary>
		public Vector4 Colors_0;
		public Vector4 Colors_1;
		public Vector4 Colors_2;
		public Vector4 Colors_3;
		public Vector4 Colors_4;
		public Vector4 Colors_5;
		public Vector4 Colors_6;
		public Vector4 Colors_7;
		public Vector4 Colors_8;
		public Vector4 Colors_9;
		public Vector4 Colors_10;
		public Vector4 Colors_11;
		public Vector4 Colors_12;
		public Vector4 Colors_13;
		public Vector4 Colors_14;


		/// <summary>
		/// To be documented.
		/// </summary>
		public unsafe Style(float translationLineThickness = default, float translationLineArrowSize = default, float rotationLineThickness = default, float rotationOuterLineThickness = default, float scaleLineThickness = default, float scaleLineCircleSize = default, float hatchedAxisLineThickness = default, float centerCircleSize = default, Vector4* colors = default)
		{
			TranslationLineThickness = translationLineThickness;
			TranslationLineArrowSize = translationLineArrowSize;
			RotationLineThickness = rotationLineThickness;
			RotationOuterLineThickness = rotationOuterLineThickness;
			ScaleLineThickness = scaleLineThickness;
			ScaleLineCircleSize = scaleLineCircleSize;
			HatchedAxisLineThickness = hatchedAxisLineThickness;
			CenterCircleSize = centerCircleSize;
			if (colors != default(Vector4*))
			{
				Colors_0 = colors[0];
				Colors_1 = colors[1];
				Colors_2 = colors[2];
				Colors_3 = colors[3];
				Colors_4 = colors[4];
				Colors_5 = colors[5];
				Colors_6 = colors[6];
				Colors_7 = colors[7];
				Colors_8 = colors[8];
				Colors_9 = colors[9];
				Colors_10 = colors[10];
				Colors_11 = colors[11];
				Colors_12 = colors[12];
				Colors_13 = colors[13];
				Colors_14 = colors[14];
			}
		}

		/// <summary>
		/// To be documented.
		/// </summary>
		public unsafe Style(float translationLineThickness = default, float translationLineArrowSize = default, float rotationLineThickness = default, float rotationOuterLineThickness = default, float scaleLineThickness = default, float scaleLineCircleSize = default, float hatchedAxisLineThickness = default, float centerCircleSize = default, Span<Vector4> colors = default)
		{
			TranslationLineThickness = translationLineThickness;
			TranslationLineArrowSize = translationLineArrowSize;
			RotationLineThickness = rotationLineThickness;
			RotationOuterLineThickness = rotationOuterLineThickness;
			ScaleLineThickness = scaleLineThickness;
			ScaleLineCircleSize = scaleLineCircleSize;
			HatchedAxisLineThickness = hatchedAxisLineThickness;
			CenterCircleSize = centerCircleSize;
			if (colors != default(Span<Vector4>))
			{
				Colors_0 = colors[0];
				Colors_1 = colors[1];
				Colors_2 = colors[2];
				Colors_3 = colors[3];
				Colors_4 = colors[4];
				Colors_5 = colors[5];
				Colors_6 = colors[6];
				Colors_7 = colors[7];
				Colors_8 = colors[8];
				Colors_9 = colors[9];
				Colors_10 = colors[10];
				Colors_11 = colors[11];
				Colors_12 = colors[12];
				Colors_13 = colors[13];
				Colors_14 = colors[14];
			}
		}


		/// <summary>
		/// To be documented.
		/// </summary>
		public unsafe Span<Vector4> Colors
		
		{
			get
			{
				fixed (Vector4* p = &this.Colors_0)
				{
					return new Span<Vector4>(p, 15);
				}
			}
		}
		/// <summary>
		/// To be documented.
		/// </summary>
		public unsafe void Destroy()
		{
			fixed (Style* @this = &this)
			{
				ImGuizmo.DestroyNative(@this);
			}
		}

	}

	/// <summary>
	/// To be documented.
	/// </summary>
	#if NET5_0_OR_GREATER
	[DebuggerDisplay("{DebuggerDisplay,nq}")]
	#endif
	public unsafe struct StylePtr : IEquatable<StylePtr>
	{
		public StylePtr(Style* handle) { Handle = handle; }

		public Style* Handle;

		public bool IsNull => Handle == null;

		public static StylePtr Null => new StylePtr(null);

		public Style this[int index] { get => Handle[index]; set => Handle[index] = value; }

		public static implicit operator StylePtr(Style* handle) => new StylePtr(handle);

		public static implicit operator Style*(StylePtr handle) => handle.Handle;

		public static bool operator ==(StylePtr left, StylePtr right) => left.Handle == right.Handle;

		public static bool operator !=(StylePtr left, StylePtr right) => left.Handle != right.Handle;

		public static bool operator ==(StylePtr left, Style* right) => left.Handle == right;

		public static bool operator !=(StylePtr left, Style* right) => left.Handle != right;

		public bool Equals(StylePtr other) => Handle == other.Handle;

		/// <inheritdoc/>
		public override bool Equals(object obj) => obj is StylePtr handle && Equals(handle);

		/// <inheritdoc/>
		public override int GetHashCode() => ((nuint)Handle).GetHashCode();

		#if NET5_0_OR_GREATER
		private string DebuggerDisplay => string.Format("StylePtr [0x{0}]", ((nuint)Handle).ToString("X"));
		#endif
		/// <summary>
		/// To be documented.
		/// </summary>
		public ref float TranslationLineThickness => ref Unsafe.AsRef<float>(&Handle->TranslationLineThickness);
		/// <summary>
		/// To be documented.
		/// </summary>
		public ref float TranslationLineArrowSize => ref Unsafe.AsRef<float>(&Handle->TranslationLineArrowSize);
		/// <summary>
		/// To be documented.
		/// </summary>
		public ref float RotationLineThickness => ref Unsafe.AsRef<float>(&Handle->RotationLineThickness);
		/// <summary>
		/// To be documented.
		/// </summary>
		public ref float RotationOuterLineThickness => ref Unsafe.AsRef<float>(&Handle->RotationOuterLineThickness);
		/// <summary>
		/// To be documented.
		/// </summary>
		public ref float ScaleLineThickness => ref Unsafe.AsRef<float>(&Handle->ScaleLineThickness);
		/// <summary>
		/// To be documented.
		/// </summary>
		public ref float ScaleLineCircleSize => ref Unsafe.AsRef<float>(&Handle->ScaleLineCircleSize);
		/// <summary>
		/// To be documented.
		/// </summary>
		public ref float HatchedAxisLineThickness => ref Unsafe.AsRef<float>(&Handle->HatchedAxisLineThickness);
		/// <summary>
		/// To be documented.
		/// </summary>
		public ref float CenterCircleSize => ref Unsafe.AsRef<float>(&Handle->CenterCircleSize);
		/// <summary>
		/// To be documented.
		/// </summary>
		public unsafe Span<Vector4> Colors
		
		{
			get
			{
				return new Span<Vector4>(&Handle->Colors_0, 15);
			}
		}
		/// <summary>
		/// To be documented.
		/// </summary>
		public unsafe void Destroy()
		{
			ImGuizmo.DestroyNative(Handle);
		}

	}

}
