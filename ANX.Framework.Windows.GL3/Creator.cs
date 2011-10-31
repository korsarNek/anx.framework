﻿#region Using Statements
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ANX.Framework;
using ANX.Framework.NonXNA;
using ANX.Framework.Graphics;
using System.IO;

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
	public class Creator : IRenderSystemCreator
	{
		#region Public
		/// <summary>
		/// Name of the Creator implementation.
		/// </summary>
		public string Name
		{
			get
			{
				return "OpenGL3";
			}
		}
		#endregion

		#region RegisterRenderSystemCreator
		public void RegisterCreator(AddInSystemFactory factory)
		{
			factory.AddCreator(this);
		}
		#endregion

		#region CreateGameHost
		public GameHost CreateGameHost(Game game)
		{
			return new WindowsGameHost(game);
		}
		#endregion

		#region CreateEffect
		public INativeEffect CreateEffect(GraphicsDevice graphics, Stream byteCode)
		{
			return new EffectGL3(graphics, byteCode);
		}

		public INativeEffect CreateEffect(GraphicsDevice graphics,
			Stream vertexShaderByteCode, Stream pixelShaderByteCode)
		{
			return new EffectGL3(graphics, vertexShaderByteCode, pixelShaderByteCode);
		}
		#endregion

		#region CreateGraphicsDevice
		INativeGraphicsDevice IRenderSystemCreator.CreateGraphicsDevice(
			PresentationParameters presentationParameters)
		{
			return new GraphicsDeviceWindowsGL3(presentationParameters);
		}
		#endregion

		#region CreateTexture
		/// <summary>
		/// Create a new native texture.
		/// </summary>
		/// <param name="graphics">Graphics device.</param>
		/// <param name="surfaceFormat">The format of the texture.</param>
		/// <param name="width">The width of the texture.</param>
		/// <param name="height">The height of the texture.</param>
		/// <param name="mipCount">The number of mipmaps in the texture.</param>
		/// <param name="mipMaps">The mipmaps as a single byte array.</param>
		/// <returns></returns>
		public Texture2D CreateTexture(GraphicsDevice graphics,
			SurfaceFormat surfaceFormat, int width, int height, int mipCount,
			byte[] mipMaps)
		{
			return new Texture2DGL3(graphics, surfaceFormat, width,
				height, mipCount, mipMaps);
		}
		#endregion

		public INativeBuffer CreateIndexBuffer(GraphicsDevice graphics,
			IndexElementSize size, int indexCount, BufferUsage usage)
		{
			throw new NotImplementedException();
		}

		public INativeBuffer CreateVertexBuffer(GraphicsDevice graphics,
			VertexDeclaration vertexDeclaration, int vertexCount, BufferUsage usage)
		{
			throw new NotImplementedException();
		}

		#region CreateBlendState
		/// <summary>
		/// Create a new native blend state.
		/// </summary>
		/// <returns>Native Blend State.</returns>
		public INativeBlendState CreateBlendState()
		{
			return new BlendStateGL3();
		}
		#endregion

		#region CreateBlendState
		/// <summary>
		/// Create a new native rasterizer state.
		/// </summary>
		/// <returns>Native Rasterizer State.</returns>
		public INativeRasterizerState CreateRasterizerState()
		{
			return new RasterizerStateGL3();
		}
		#endregion

		#region CreateDepthStencilState
		/// <summary>
		/// Create a new native Depth Stencil State.
		/// </summary>
		/// <returns>Native Depth Stencil State.</returns>
		public INativeDepthStencilState CreateDepthStencilState()
		{
			return new DepthStencilStateGL3();
		}
		#endregion

		#region CreateSamplerState
		/// <summary>
		/// Create a new native sampler state.
		/// </summary>
		/// <returns>Native Sampler State.</returns>
		public INativeSamplerState CreateSamplerState()
		{
			return new SamplerStateGL3();
		}
		#endregion

		public byte[] GetShaderByteCode(PreDefinedShader type)
		{
			switch (type)
			{
				//case PreDefinedShader.SpriteBatch:
				//  return new byte[0];

				default:
					throw new NotSupportedException("The predefined shader '" + type +
						"' isn't supported yet!");
			}
		}
	}
}
