#region Using Statements
using System;
#endregion // Using Statements

#region License
//
// This file is part of the ANX.Framework created by the "ANX.Framework developer group".
//
// This file is released under the Ms-PL license.
//
//
//
// Microsoft Public License (Ms-PL)
//
// This license governs use of the accompanying software. If you use the software, you accept this license. 
// If you do not accept the license, do not use the software.
//
// 1.Definitions
//   The terms "reproduce," "reproduction," "derivative works," and "distribution" have the same meaning 
//   here as under U.S. copyright law.
//   A "contribution" is the original software, or any additions or changes to the software.
//   A "contributor" is any person that distributes its contribution under this license.
//   "Licensed patents" are a contributor's patent claims that read directly on its contribution.
//
// 2.Grant of Rights
//   (A) Copyright Grant- Subject to the terms of this license, including the license conditions and limitations 
//       in section 3, each contributor grants you a non-exclusive, worldwide, royalty-free copyright license to 
//       reproduce its contribution, prepare derivative works of its contribution, and distribute its contribution
//       or any derivative works that you create.
//   (B) Patent Grant- Subject to the terms of this license, including the license conditions and limitations in 
//       section 3, each contributor grants you a non-exclusive, worldwide, royalty-free license under its licensed
//       patents to make, have made, use, sell, offer for sale, import, and/or otherwise dispose of its contribution 
//       in the software or derivative works of the contribution in the software.
//
// 3.Conditions and Limitations
//   (A) No Trademark License- This license does not grant you rights to use any contributors' name, logo, or trademarks.
//   (B) If you bring a patent claim against any contributor over patents that you claim are infringed by the software, your 
//       patent license from such contributor to the software ends automatically.
//   (C) If you distribute any portion of the software, you must retain all copyright, patent, trademark, and attribution 
//       notices that are present in the software.
//   (D) If you distribute any portion of the software in source code form, you may do so only under this license by including
//       a complete copy of this license with your distribution. If you distribute any portion of the software in compiled or 
//       object code form, you may only do so under a license that complies with this license.
//   (E) The software is licensed "as-is." You bear the risk of using it. The contributors give no express warranties, guarantees,
//       or conditions. You may have additional consumer rights under your local laws which this license cannot change. To the
//       extent permitted under your local laws, the contributors exclude the implied warranties of merchantability, fitness for a 
//       particular purpose and non-infringement.
#endregion // License

namespace ANX.Framework.Windows.GL3
{
	internal static class ShaderByteCode
	{
		#region SpriteBatchShader
		internal static byte[] SpriteBatchByteCode = new byte[]
		{
			047, 
			047, 013, 010, 047, 047, 032, 084, 104, 105, 115, 032, 102, 105, 108, 101, 032, 105, 115, 032, 112, 
			097, 114, 116, 032, 111, 102, 032, 116, 104, 101, 032, 065, 078, 088, 046, 070, 114, 097, 109, 101, 
			119, 111, 114, 107, 032, 099, 114, 101, 097, 116, 101, 100, 032, 098, 121, 032, 116, 104, 101, 032, 
			034, 065, 078, 088, 046, 070, 114, 097, 109, 101, 119, 111, 114, 107, 032, 100, 101, 118, 101, 108, 
			111, 112, 101, 114, 032, 103, 114, 111, 117, 112, 034, 046, 013, 010, 047, 047, 013, 010, 047, 047, 
			032, 084, 104, 105, 115, 032, 102, 105, 108, 101, 032, 105, 115, 032, 114, 101, 108, 101, 097, 115, 
			101, 100, 032, 117, 110, 100, 101, 114, 032, 116, 104, 101, 032, 077, 115, 045, 080, 076, 032, 108, 
			105, 099, 101, 110, 115, 101, 046, 013, 010, 047, 047, 013, 010, 047, 047, 013, 010, 047, 047, 013, 
			010, 047, 047, 032, 077, 105, 099, 114, 111, 115, 111, 102, 116, 032, 080, 117, 098, 108, 105, 099, 
			032, 076, 105, 099, 101, 110, 115, 101, 032, 040, 077, 115, 045, 080, 076, 041, 013, 010, 047, 047, 
			013, 010, 047, 047, 032, 084, 104, 105, 115, 032, 108, 105, 099, 101, 110, 115, 101, 032, 103, 111, 
			118, 101, 114, 110, 115, 032, 117, 115, 101, 032, 111, 102, 032, 116, 104, 101, 032, 097, 099, 099, 
			111, 109, 112, 097, 110, 121, 105, 110, 103, 032, 115, 111, 102, 116, 119, 097, 114, 101, 046, 032, 
			073, 102, 032, 121, 111, 117, 032, 117, 115, 101, 032, 116, 104, 101, 032, 115, 111, 102, 116, 119, 
			097, 114, 101, 044, 032, 121, 111, 117, 032, 097, 099, 099, 101, 112, 116, 032, 116, 104, 105, 115, 
			032, 108, 105, 099, 101, 110, 115, 101, 046, 032, 013, 010, 047, 047, 032, 073, 102, 032, 121, 111, 
			117, 032, 100, 111, 032, 110, 111, 116, 032, 097, 099, 099, 101, 112, 116, 032, 116, 104, 101, 032, 
			108, 105, 099, 101, 110, 115, 101, 044, 032, 100, 111, 032, 110, 111, 116, 032, 117, 115, 101, 032, 
			116, 104, 101, 032, 115, 111, 102, 116, 119, 097, 114, 101, 046, 013, 010, 047, 047, 013, 010, 047, 
			047, 032, 049, 046, 068, 101, 102, 105, 110, 105, 116, 105, 111, 110, 115, 013, 010, 047, 047, 032, 
			032, 032, 084, 104, 101, 032, 116, 101, 114, 109, 115, 032, 034, 114, 101, 112, 114, 111, 100, 117, 
			099, 101, 044, 034, 032, 034, 114, 101, 112, 114, 111, 100, 117, 099, 116, 105, 111, 110, 044, 034, 
			032, 034, 100, 101, 114, 105, 118, 097, 116, 105, 118, 101, 032, 119, 111, 114, 107, 115, 044, 034, 
			032, 097, 110, 100, 032, 034, 100, 105, 115, 116, 114, 105, 098, 117, 116, 105, 111, 110, 034, 032, 
			104, 097, 118, 101, 032, 116, 104, 101, 032, 115, 097, 109, 101, 032, 109, 101, 097, 110, 105, 110, 
			103, 032, 013, 010, 047, 047, 032, 032, 032, 104, 101, 114, 101, 032, 097, 115, 032, 117, 110, 100, 
			101, 114, 032, 085, 046, 083, 046, 032, 099, 111, 112, 121, 114, 105, 103, 104, 116, 032, 108, 097, 
			119, 046, 013, 010, 047, 047, 032, 032, 032, 065, 032, 034, 099, 111, 110, 116, 114, 105, 098, 117, 
			116, 105, 111, 110, 034, 032, 105, 115, 032, 116, 104, 101, 032, 111, 114, 105, 103, 105, 110, 097, 
			108, 032, 115, 111, 102, 116, 119, 097, 114, 101, 044, 032, 111, 114, 032, 097, 110, 121, 032, 097, 
			100, 100, 105, 116, 105, 111, 110, 115, 032, 111, 114, 032, 099, 104, 097, 110, 103, 101, 115, 032, 
			116, 111, 032, 116, 104, 101, 032, 115, 111, 102, 116, 119, 097, 114, 101, 046, 013, 010, 047, 047, 
			032, 032, 032, 065, 032, 034, 099, 111, 110, 116, 114, 105, 098, 117, 116, 111, 114, 034, 032, 105, 
			115, 032, 097, 110, 121, 032, 112, 101, 114, 115, 111, 110, 032, 116, 104, 097, 116, 032, 100, 105, 
			115, 116, 114, 105, 098, 117, 116, 101, 115, 032, 105, 116, 115, 032, 099, 111, 110, 116, 114, 105, 
			098, 117, 116, 105, 111, 110, 032, 117, 110, 100, 101, 114, 032, 116, 104, 105, 115, 032, 108, 105, 
			099, 101, 110, 115, 101, 046, 013, 010, 047, 047, 032, 032, 032, 034, 076, 105, 099, 101, 110, 115, 
			101, 100, 032, 112, 097, 116, 101, 110, 116, 115, 034, 032, 097, 114, 101, 032, 097, 032, 099, 111, 
			110, 116, 114, 105, 098, 117, 116, 111, 114, 039, 115, 032, 112, 097, 116, 101, 110, 116, 032, 099, 
			108, 097, 105, 109, 115, 032, 116, 104, 097, 116, 032, 114, 101, 097, 100, 032, 100, 105, 114, 101, 
			099, 116, 108, 121, 032, 111, 110, 032, 105, 116, 115, 032, 099, 111, 110, 116, 114, 105, 098, 117, 
			116, 105, 111, 110, 046, 013, 010, 047, 047, 013, 010, 047, 047, 032, 050, 046, 071, 114, 097, 110, 
			116, 032, 111, 102, 032, 082, 105, 103, 104, 116, 115, 013, 010, 047, 047, 032, 032, 032, 040, 065, 
			041, 032, 067, 111, 112, 121, 114, 105, 103, 104, 116, 032, 071, 114, 097, 110, 116, 045, 032, 083, 
			117, 098, 106, 101, 099, 116, 032, 116, 111, 032, 116, 104, 101, 032, 116, 101, 114, 109, 115, 032, 
			111, 102, 032, 116, 104, 105, 115, 032, 108, 105, 099, 101, 110, 115, 101, 044, 032, 105, 110, 099, 
			108, 117, 100, 105, 110, 103, 032, 116, 104, 101, 032, 108, 105, 099, 101, 110, 115, 101, 032, 099, 
			111, 110, 100, 105, 116, 105, 111, 110, 115, 032, 097, 110, 100, 032, 108, 105, 109, 105, 116, 097, 
			116, 105, 111, 110, 115, 032, 013, 010, 047, 047, 032, 032, 032, 032, 032, 032, 032, 105, 110, 032, 
			115, 101, 099, 116, 105, 111, 110, 032, 051, 044, 032, 101, 097, 099, 104, 032, 099, 111, 110, 116, 
			114, 105, 098, 117, 116, 111, 114, 032, 103, 114, 097, 110, 116, 115, 032, 121, 111, 117, 032, 097, 
			032, 110, 111, 110, 045, 101, 120, 099, 108, 117, 115, 105, 118, 101, 044, 032, 119, 111, 114, 108, 
			100, 119, 105, 100, 101, 044, 032, 114, 111, 121, 097, 108, 116, 121, 045, 102, 114, 101, 101, 032, 
			099, 111, 112, 121, 114, 105, 103, 104, 116, 032, 108, 105, 099, 101, 110, 115, 101, 032, 116, 111, 
			032, 013, 010, 047, 047, 032, 032, 032, 032, 032, 032, 032, 114, 101, 112, 114, 111, 100, 117, 099, 
			101, 032, 105, 116, 115, 032, 099, 111, 110, 116, 114, 105, 098, 117, 116, 105, 111, 110, 044, 032, 
			112, 114, 101, 112, 097, 114, 101, 032, 100, 101, 114, 105, 118, 097, 116, 105, 118, 101, 032, 119, 
			111, 114, 107, 115, 032, 111, 102, 032, 105, 116, 115, 032, 099, 111, 110, 116, 114, 105, 098, 117, 
			116, 105, 111, 110, 044, 032, 097, 110, 100, 032, 100, 105, 115, 116, 114, 105, 098, 117, 116, 101, 
			032, 105, 116, 115, 032, 099, 111, 110, 116, 114, 105, 098, 117, 116, 105, 111, 110, 013, 010, 047, 
			047, 032, 032, 032, 032, 032, 032, 032, 111, 114, 032, 097, 110, 121, 032, 100, 101, 114, 105, 118, 
			097, 116, 105, 118, 101, 032, 119, 111, 114, 107, 115, 032, 116, 104, 097, 116, 032, 121, 111, 117, 
			032, 099, 114, 101, 097, 116, 101, 046, 013, 010, 047, 047, 032, 032, 032, 040, 066, 041, 032, 080, 
			097, 116, 101, 110, 116, 032, 071, 114, 097, 110, 116, 045, 032, 083, 117, 098, 106, 101, 099, 116, 
			032, 116, 111, 032, 116, 104, 101, 032, 116, 101, 114, 109, 115, 032, 111, 102, 032, 116, 104, 105, 
			115, 032, 108, 105, 099, 101, 110, 115, 101, 044, 032, 105, 110, 099, 108, 117, 100, 105, 110, 103, 
			032, 116, 104, 101, 032, 108, 105, 099, 101, 110, 115, 101, 032, 099, 111, 110, 100, 105, 116, 105, 
			111, 110, 115, 032, 097, 110, 100, 032, 108, 105, 109, 105, 116, 097, 116, 105, 111, 110, 115, 032, 
			105, 110, 032, 013, 010, 047, 047, 032, 032, 032, 032, 032, 032, 032, 115, 101, 099, 116, 105, 111, 
			110, 032, 051, 044, 032, 101, 097, 099, 104, 032, 099, 111, 110, 116, 114, 105, 098, 117, 116, 111, 
			114, 032, 103, 114, 097, 110, 116, 115, 032, 121, 111, 117, 032, 097, 032, 110, 111, 110, 045, 101, 
			120, 099, 108, 117, 115, 105, 118, 101, 044, 032, 119, 111, 114, 108, 100, 119, 105, 100, 101, 044, 
			032, 114, 111, 121, 097, 108, 116, 121, 045, 102, 114, 101, 101, 032, 108, 105, 099, 101, 110, 115, 
			101, 032, 117, 110, 100, 101, 114, 032, 105, 116, 115, 032, 108, 105, 099, 101, 110, 115, 101, 100, 
			013, 010, 047, 047, 032, 032, 032, 032, 032, 032, 032, 112, 097, 116, 101, 110, 116, 115, 032, 116, 
			111, 032, 109, 097, 107, 101, 044, 032, 104, 097, 118, 101, 032, 109, 097, 100, 101, 044, 032, 117, 
			115, 101, 044, 032, 115, 101, 108, 108, 044, 032, 111, 102, 102, 101, 114, 032, 102, 111, 114, 032, 
			115, 097, 108, 101, 044, 032, 105, 109, 112, 111, 114, 116, 044, 032, 097, 110, 100, 047, 111, 114, 
			032, 111, 116, 104, 101, 114, 119, 105, 115, 101, 032, 100, 105, 115, 112, 111, 115, 101, 032, 111, 
			102, 032, 105, 116, 115, 032, 099, 111, 110, 116, 114, 105, 098, 117, 116, 105, 111, 110, 032, 013, 
			010, 047, 047, 032, 032, 032, 032, 032, 032, 032, 105, 110, 032, 116, 104, 101, 032, 115, 111, 102, 
			116, 119, 097, 114, 101, 032, 111, 114, 032, 100, 101, 114, 105, 118, 097, 116, 105, 118, 101, 032, 
			119, 111, 114, 107, 115, 032, 111, 102, 032, 116, 104, 101, 032, 099, 111, 110, 116, 114, 105, 098, 
			117, 116, 105, 111, 110, 032, 105, 110, 032, 116, 104, 101, 032, 115, 111, 102, 116, 119, 097, 114, 
			101, 046, 013, 010, 047, 047, 013, 010, 047, 047, 032, 051, 046, 067, 111, 110, 100, 105, 116, 105, 
			111, 110, 115, 032, 097, 110, 100, 032, 076, 105, 109, 105, 116, 097, 116, 105, 111, 110, 115, 013, 
			010, 047, 047, 032, 032, 032, 040, 065, 041, 032, 078, 111, 032, 084, 114, 097, 100, 101, 109, 097, 
			114, 107, 032, 076, 105, 099, 101, 110, 115, 101, 045, 032, 084, 104, 105, 115, 032, 108, 105, 099, 
			101, 110, 115, 101, 032, 100, 111, 101, 115, 032, 110, 111, 116, 032, 103, 114, 097, 110, 116, 032, 
			121, 111, 117, 032, 114, 105, 103, 104, 116, 115, 032, 116, 111, 032, 117, 115, 101, 032, 097, 110, 
			121, 032, 099, 111, 110, 116, 114, 105, 098, 117, 116, 111, 114, 115, 039, 032, 110, 097, 109, 101, 
			044, 032, 108, 111, 103, 111, 044, 032, 111, 114, 032, 116, 114, 097, 100, 101, 109, 097, 114, 107, 
			115, 046, 013, 010, 047, 047, 032, 032, 032, 040, 066, 041, 032, 073, 102, 032, 121, 111, 117, 032, 
			098, 114, 105, 110, 103, 032, 097, 032, 112, 097, 116, 101, 110, 116, 032, 099, 108, 097, 105, 109, 
			032, 097, 103, 097, 105, 110, 115, 116, 032, 097, 110, 121, 032, 099, 111, 110, 116, 114, 105, 098, 
			117, 116, 111, 114, 032, 111, 118, 101, 114, 032, 112, 097, 116, 101, 110, 116, 115, 032, 116, 104, 
			097, 116, 032, 121, 111, 117, 032, 099, 108, 097, 105, 109, 032, 097, 114, 101, 032, 105, 110, 102, 
			114, 105, 110, 103, 101, 100, 032, 098, 121, 032, 116, 104, 101, 032, 115, 111, 102, 116, 119, 097, 
			114, 101, 044, 032, 121, 111, 117, 114, 032, 013, 010, 047, 047, 032, 032, 032, 032, 032, 032, 032, 
			112, 097, 116, 101, 110, 116, 032, 108, 105, 099, 101, 110, 115, 101, 032, 102, 114, 111, 109, 032, 
			115, 117, 099, 104, 032, 099, 111, 110, 116, 114, 105, 098, 117, 116, 111, 114, 032, 116, 111, 032, 
			116, 104, 101, 032, 115, 111, 102, 116, 119, 097, 114, 101, 032, 101, 110, 100, 115, 032, 097, 117, 
			116, 111, 109, 097, 116, 105, 099, 097, 108, 108, 121, 046, 013, 010, 047, 047, 032, 032, 032, 040, 
			067, 041, 032, 073, 102, 032, 121, 111, 117, 032, 100, 105, 115, 116, 114, 105, 098, 117, 116, 101, 
			032, 097, 110, 121, 032, 112, 111, 114, 116, 105, 111, 110, 032, 111, 102, 032, 116, 104, 101, 032, 
			115, 111, 102, 116, 119, 097, 114, 101, 044, 032, 121, 111, 117, 032, 109, 117, 115, 116, 032, 114, 
			101, 116, 097, 105, 110, 032, 097, 108, 108, 032, 099, 111, 112, 121, 114, 105, 103, 104, 116, 044, 
			032, 112, 097, 116, 101, 110, 116, 044, 032, 116, 114, 097, 100, 101, 109, 097, 114, 107, 044, 032, 
			097, 110, 100, 032, 097, 116, 116, 114, 105, 098, 117, 116, 105, 111, 110, 032, 013, 010, 047, 047, 
			032, 032, 032, 032, 032, 032, 032, 110, 111, 116, 105, 099, 101, 115, 032, 116, 104, 097, 116, 032, 
			097, 114, 101, 032, 112, 114, 101, 115, 101, 110, 116, 032, 105, 110, 032, 116, 104, 101, 032, 115, 
			111, 102, 116, 119, 097, 114, 101, 046, 013, 010, 047, 047, 032, 032, 032, 040, 068, 041, 032, 073, 
			102, 032, 121, 111, 117, 032, 100, 105, 115, 116, 114, 105, 098, 117, 116, 101, 032, 097, 110, 121, 
			032, 112, 111, 114, 116, 105, 111, 110, 032, 111, 102, 032, 116, 104, 101, 032, 115, 111, 102, 116, 
			119, 097, 114, 101, 032, 105, 110, 032, 115, 111, 117, 114, 099, 101, 032, 099, 111, 100, 101, 032, 
			102, 111, 114, 109, 044, 032, 121, 111, 117, 032, 109, 097, 121, 032, 100, 111, 032, 115, 111, 032, 
			111, 110, 108, 121, 032, 117, 110, 100, 101, 114, 032, 116, 104, 105, 115, 032, 108, 105, 099, 101, 
			110, 115, 101, 032, 098, 121, 032, 105, 110, 099, 108, 117, 100, 105, 110, 103, 013, 010, 047, 047, 
			032, 032, 032, 032, 032, 032, 032, 097, 032, 099, 111, 109, 112, 108, 101, 116, 101, 032, 099, 111, 
			112, 121, 032, 111, 102, 032, 116, 104, 105, 115, 032, 108, 105, 099, 101, 110, 115, 101, 032, 119, 
			105, 116, 104, 032, 121, 111, 117, 114, 032, 100, 105, 115, 116, 114, 105, 098, 117, 116, 105, 111, 
			110, 046, 032, 073, 102, 032, 121, 111, 117, 032, 100, 105, 115, 116, 114, 105, 098, 117, 116, 101, 
			032, 097, 110, 121, 032, 112, 111, 114, 116, 105, 111, 110, 032, 111, 102, 032, 116, 104, 101, 032, 
			115, 111, 102, 116, 119, 097, 114, 101, 032, 105, 110, 032, 099, 111, 109, 112, 105, 108, 101, 100, 
			032, 111, 114, 032, 013, 010, 047, 047, 032, 032, 032, 032, 032, 032, 032, 111, 098, 106, 101, 099, 
			116, 032, 099, 111, 100, 101, 032, 102, 111, 114, 109, 044, 032, 121, 111, 117, 032, 109, 097, 121, 
			032, 111, 110, 108, 121, 032, 100, 111, 032, 115, 111, 032, 117, 110, 100, 101, 114, 032, 097, 032, 
			108, 105, 099, 101, 110, 115, 101, 032, 116, 104, 097, 116, 032, 099, 111, 109, 112, 108, 105, 101, 
			115, 032, 119, 105, 116, 104, 032, 116, 104, 105, 115, 032, 108, 105, 099, 101, 110, 115, 101, 046, 
			013, 010, 047, 047, 032, 032, 032, 040, 069, 041, 032, 084, 104, 101, 032, 115, 111, 102, 116, 119, 
			097, 114, 101, 032, 105, 115, 032, 108, 105, 099, 101, 110, 115, 101, 100, 032, 034, 097, 115, 045, 
			105, 115, 046, 034, 032, 089, 111, 117, 032, 098, 101, 097, 114, 032, 116, 104, 101, 032, 114, 105, 
			115, 107, 032, 111, 102, 032, 117, 115, 105, 110, 103, 032, 105, 116, 046, 032, 084, 104, 101, 032, 
			099, 111, 110, 116, 114, 105, 098, 117, 116, 111, 114, 115, 032, 103, 105, 118, 101, 032, 110, 111, 
			032, 101, 120, 112, 114, 101, 115, 115, 032, 119, 097, 114, 114, 097, 110, 116, 105, 101, 115, 044, 
			032, 103, 117, 097, 114, 097, 110, 116, 101, 101, 115, 044, 013, 010, 047, 047, 032, 032, 032, 032, 
			032, 032, 032, 111, 114, 032, 099, 111, 110, 100, 105, 116, 105, 111, 110, 115, 046, 032, 089, 111, 
			117, 032, 109, 097, 121, 032, 104, 097, 118, 101, 032, 097, 100, 100, 105, 116, 105, 111, 110, 097, 
			108, 032, 099, 111, 110, 115, 117, 109, 101, 114, 032, 114, 105, 103, 104, 116, 115, 032, 117, 110, 
			100, 101, 114, 032, 121, 111, 117, 114, 032, 108, 111, 099, 097, 108, 032, 108, 097, 119, 115, 032, 
			119, 104, 105, 099, 104, 032, 116, 104, 105, 115, 032, 108, 105, 099, 101, 110, 115, 101, 032, 099, 
			097, 110, 110, 111, 116, 032, 099, 104, 097, 110, 103, 101, 046, 032, 084, 111, 032, 116, 104, 101, 
			013, 010, 047, 047, 032, 032, 032, 032, 032, 032, 032, 101, 120, 116, 101, 110, 116, 032, 112, 101, 
			114, 109, 105, 116, 116, 101, 100, 032, 117, 110, 100, 101, 114, 032, 121, 111, 117, 114, 032, 108, 
			111, 099, 097, 108, 032, 108, 097, 119, 115, 044, 032, 116, 104, 101, 032, 099, 111, 110, 116, 114, 
			105, 098, 117, 116, 111, 114, 115, 032, 101, 120, 099, 108, 117, 100, 101, 032, 116, 104, 101, 032, 
			105, 109, 112, 108, 105, 101, 100, 032, 119, 097, 114, 114, 097, 110, 116, 105, 101, 115, 032, 111, 
			102, 032, 109, 101, 114, 099, 104, 097, 110, 116, 097, 098, 105, 108, 105, 116, 121, 044, 032, 102, 
			105, 116, 110, 101, 115, 115, 032, 102, 111, 114, 032, 097, 032, 013, 010, 047, 047, 032, 032, 032, 
			032, 032, 032, 032, 112, 097, 114, 116, 105, 099, 117, 108, 097, 114, 032, 112, 117, 114, 112, 111, 
			115, 101, 032, 097, 110, 100, 032, 110, 111, 110, 045, 105, 110, 102, 114, 105, 110, 103, 101, 109, 
			101, 110, 116, 046, 013, 010, 013, 010, 117, 110, 105, 102, 111, 114, 109, 032, 109, 097, 116, 052, 
			032, 077, 097, 116, 114, 105, 120, 084, 114, 097, 110, 115, 102, 111, 114, 109, 059, 013, 010, 013, 
			010, 047, 047, 013, 010, 047, 047, 032, 086, 101, 114, 116, 101, 120, 032, 083, 104, 097, 100, 101, 
			114, 013, 010, 047, 047, 013, 010, 013, 010, 118, 111, 105, 100, 032, 109, 097, 105, 110, 040, 118, 
			111, 105, 100, 041, 013, 010, 123, 013, 010, 009, 103, 108, 095, 080, 111, 115, 105, 116, 105, 111, 
			110, 032, 061, 032, 103, 108, 095, 077, 111, 100, 101, 108, 086, 105, 101, 119, 080, 114, 111, 106, 
			101, 099, 116, 105, 111, 110, 077, 097, 116, 114, 105, 120, 032, 042, 032, 103, 108, 095, 086, 101, 
			114, 116, 101, 120, 059, 013, 010, 125, 013, 010, 013, 010, 035, 035, 033, 102, 114, 097, 103, 109, 
			101, 110, 116, 033, 035, 035, 013, 010, 013, 010, 047, 047, 013, 010, 047, 047, 032, 070, 114, 097, 
			103, 109, 101, 110, 116, 032, 083, 104, 097, 100, 101, 114, 013, 010, 047, 047, 013, 010, 013, 010, 
			118, 111, 105, 100, 032, 109, 097, 105, 110, 040, 118, 111, 105, 100, 041, 013, 010, 123, 013, 010, 
			009, 103, 108, 095, 070, 114, 097, 103, 067, 111, 108, 111, 114, 032, 061, 032, 118, 101, 099, 052, 
			040, 049, 046, 048, 044, 032, 049, 046, 048, 044, 032, 049, 046, 048, 044, 032, 049, 046, 048, 041, 
			059, 013, 010, 125, 013, 010, 013, 010, 047, 042, 013, 010, 084, 101, 120, 116, 117, 114, 101, 050, 
			068, 060, 102, 108, 111, 097, 116, 052, 062, 032, 084, 101, 120, 116, 117, 114, 101, 032, 058, 032, 
			114, 101, 103, 105, 115, 116, 101, 114, 040, 116, 048, 041, 059, 013, 010, 032, 032, 032, 115, 097, 
			109, 112, 108, 101, 114, 032, 084, 101, 120, 116, 117, 114, 101, 083, 097, 109, 112, 108, 101, 114, 
			032, 058, 032, 114, 101, 103, 105, 115, 116, 101, 114, 040, 115, 048, 041, 059, 013, 010, 013, 010, 
			115, 116, 114, 117, 099, 116, 032, 086, 101, 114, 116, 101, 120, 083, 104, 097, 100, 101, 114, 073, 
			110, 112, 117, 116, 013, 010, 123, 013, 010, 009, 102, 108, 111, 097, 116, 052, 032, 112, 111, 115, 
			032, 058, 032, 080, 079, 083, 073, 084, 073, 079, 078, 059, 013, 010, 009, 102, 108, 111, 097, 116, 
			052, 032, 099, 111, 108, 032, 058, 032, 067, 079, 076, 079, 082, 059, 013, 010, 009, 102, 108, 111, 
			097, 116, 050, 032, 116, 101, 120, 032, 058, 032, 084, 069, 088, 067, 079, 079, 082, 068, 048, 059, 
			013, 010, 125, 059, 013, 010, 013, 010, 115, 116, 114, 117, 099, 116, 032, 080, 105, 120, 101, 108, 
			083, 104, 097, 100, 101, 114, 073, 110, 112, 117, 116, 013, 010, 123, 013, 010, 009, 102, 108, 111, 
			097, 116, 052, 032, 112, 111, 115, 032, 058, 032, 083, 086, 095, 080, 079, 083, 073, 084, 073, 079, 
			078, 059, 013, 010, 009, 102, 108, 111, 097, 116, 052, 032, 099, 111, 108, 032, 058, 032, 067, 079, 
			076, 079, 082, 059, 013, 010, 009, 102, 108, 111, 097, 116, 050, 032, 116, 101, 120, 032, 058, 032, 
			084, 069, 088, 067, 079, 079, 082, 068, 048, 059, 013, 010, 125, 059, 013, 010, 013, 010, 080, 105, 
			120, 101, 108, 083, 104, 097, 100, 101, 114, 073, 110, 112, 117, 116, 032, 083, 112, 114, 105, 116, 
			101, 086, 101, 114, 116, 101, 120, 083, 104, 097, 100, 101, 114, 040, 032, 086, 101, 114, 116, 101, 
			120, 083, 104, 097, 100, 101, 114, 073, 110, 112, 117, 116, 032, 105, 110, 112, 117, 116, 032, 041, 
			013, 010, 123, 013, 010, 009, 080, 105, 120, 101, 108, 083, 104, 097, 100, 101, 114, 073, 110, 112, 
			117, 116, 032, 111, 117, 116, 112, 117, 116, 032, 061, 032, 040, 080, 105, 120, 101, 108, 083, 104, 
			097, 100, 101, 114, 073, 110, 112, 117, 116, 041, 048, 059, 013, 010, 009, 013, 010, 009, 111, 117, 
			116, 112, 117, 116, 046, 112, 111, 115, 032, 061, 032, 109, 117, 108, 040, 105, 110, 112, 117, 116, 
			046, 112, 111, 115, 044, 032, 077, 097, 116, 114, 105, 120, 084, 114, 097, 110, 115, 102, 111, 114, 
			109, 041, 059, 013, 010, 009, 111, 117, 116, 112, 117, 116, 046, 099, 111, 108, 032, 061, 032, 105, 
			110, 112, 117, 116, 046, 099, 111, 108, 059, 013, 010, 009, 111, 117, 116, 112, 117, 116, 046, 116, 
			101, 120, 032, 061, 032, 105, 110, 112, 117, 116, 046, 116, 101, 120, 059, 013, 010, 013, 010, 009, 
			114, 101, 116, 117, 114, 110, 032, 111, 117, 116, 112, 117, 116, 059, 013, 010, 125, 013, 010, 013, 
			010, 102, 108, 111, 097, 116, 052, 032, 083, 112, 114, 105, 116, 101, 080, 105, 120, 101, 108, 083, 
			104, 097, 100, 101, 114, 040, 032, 080, 105, 120, 101, 108, 083, 104, 097, 100, 101, 114, 073, 110, 
			112, 117, 116, 032, 105, 110, 112, 117, 116, 032, 041, 032, 058, 032, 083, 086, 095, 084, 097, 114, 
			103, 101, 116, 013, 010, 123, 013, 010, 009, 114, 101, 116, 117, 114, 110, 032, 084, 101, 120, 116, 
			117, 114, 101, 046, 083, 097, 109, 112, 108, 101, 040, 084, 101, 120, 116, 117, 114, 101, 083, 097, 
			109, 112, 108, 101, 114, 044, 032, 105, 110, 112, 117, 116, 046, 116, 101, 120, 041, 032, 042, 032, 
			105, 110, 112, 117, 116, 046, 099, 111, 108, 059, 013, 010, 125, 013, 010, 013, 010, 116, 101, 099, 
			104, 110, 105, 113, 117, 101, 049, 048, 032, 083, 112, 114, 105, 116, 101, 084, 101, 099, 104, 110, 
			105, 113, 117, 101, 013, 010, 123, 013, 010, 009, 112, 097, 115, 115, 032, 083, 112, 114, 105, 116, 
			101, 067, 111, 108, 111, 114, 080, 097, 115, 115, 013, 010, 009, 123, 013, 010, 009, 009, 083, 101, 
			116, 071, 101, 111, 109, 101, 116, 114, 121, 083, 104, 097, 100, 101, 114, 040, 032, 048, 032, 041, 
			059, 013, 010, 009, 009, 083, 101, 116, 086, 101, 114, 116, 101, 120, 083, 104, 097, 100, 101, 114, 
			040, 032, 067, 111, 109, 112, 105, 108, 101, 083, 104, 097, 100, 101, 114, 040, 032, 118, 115, 095, 
			052, 095, 048, 044, 032, 083, 112, 114, 105, 116, 101, 086, 101, 114, 116, 101, 120, 083, 104, 097, 
			100, 101, 114, 040, 041, 032, 041, 032, 041, 059, 013, 010, 009, 009, 083, 101, 116, 080, 105, 120, 
			101, 108, 083, 104, 097, 100, 101, 114, 040, 032, 067, 111, 109, 112, 105, 108, 101, 083, 104, 097, 
			100, 101, 114, 040, 032, 112, 115, 095, 052, 095, 048, 044, 032, 083, 112, 114, 105, 116, 101, 080, 
			105, 120, 101, 108, 083, 104, 097, 100, 101, 114, 040, 041, 032, 041, 032, 041, 059, 013, 010, 009, 
			125, 013, 010, 125, 013, 010, 042, 047
		};
		#endregion //SpriteBatchShader

	}
}
