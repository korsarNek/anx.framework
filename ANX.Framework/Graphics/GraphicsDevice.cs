﻿#region Using Statements
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ANX.Framework.NonXNA;
using ANX.Framework.Graphics;

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

namespace ANX.Framework.Graphics
{
    public class GraphicsDevice : IDisposable
    {
        private INativeGraphicsDevice nativeDevice;
        private IndexBuffer indexBuffer;
        private SamplerStateCollection samplerStateCollection;
        private Viewport viewport;
        private BlendState blendState;
        private RasterizerState rasterizerState;
        private DepthStencilState depthStencilState;

        public GraphicsDevice(PresentationParameters presentationParameters)
        {
            this.viewport = new Viewport(0, 0, presentationParameters.BackBufferWidth, presentationParameters.BackBufferHeight);

            nativeDevice = AddInSystemFactory.Instance.GetCurrentCreator<IRenderSystemCreator>().CreateGraphicsDevice(presentationParameters);

            this.samplerStateCollection = new SamplerStateCollection(this, 8);    //TODO: get maximum number of sampler states from capabilities
        }

        public void Clear(Color color)
        {
            nativeDevice.Clear(ref color);
        }

        public void Present()
        {
            nativeDevice.Present();
        }

        public void DrawIndexedPrimitives(PrimitiveType primitiveType, int baseVertex, int minVertexIndex, int numVertices, int startIndex, int primitiveCount)
        {
            nativeDevice.DrawIndexedPrimitives(primitiveType, baseVertex, minVertexIndex, numVertices, startIndex, primitiveCount);
        }

        public void DrawInstancedPrimitives(PrimitiveType primitiveType, int baseVertex, int minVertexIndex, int numVertices, int startIndex, int primitiveCount, int instanceCount)
        {
            throw new NotImplementedException();
        }

        public void DrawPrimitives(PrimitiveType primitiveType, int startVertex, int primitiveCount)
        {
            nativeDevice.DrawPrimitives(primitiveType, startVertex, primitiveCount);
        }

        public void DrawUserIndexedPrimitives<T>(PrimitiveType primitiveType, T[] vertexData, int vertexOffset, int numVertices, short[] indexData, int indexOffset, int primitiveCount) where T : struct, IVertexType
        {
            throw new NotImplementedException();
        }

        public void DrawUserIndexedPrimitives<T>(PrimitiveType primitiveType, T[] vertexData, int vertexOffset, int numVertices, short[] indexData, int indexOffset, int primitiveCount, VertexDeclaration vertexDeclaration) where T : struct, IVertexType
        {
            throw new NotImplementedException();
        }

        public void DrawUserIndexedPrimitives<T>(PrimitiveType primitiveType, T[] vertexData, int vertexOffset, int numVertices, int[] indexData, int indexOffset, int primitiveCount) where T : struct, IVertexType
        {
            throw new NotImplementedException();
        }

        public void DrawUserIndexedPrimitives<T>(PrimitiveType primitiveType, T[] vertexData, int vertexOffset, int numVertices, int[] indexData, int indexOffset, int primitiveCount, VertexDeclaration vertexDeclaration) where T : struct, IVertexType
        {
            throw new NotImplementedException();
        }

        public void DrawUserPrimitive<T>(PrimitiveType primitiveType, T[] vertexData, int vertexOffset, int primitiveCount) where T : struct, IVertexType
        {
            throw new NotImplementedException();
            //TODO: nativeDevice.DrawUserPrimitive(primitiveCount, vertexOffset);
        }

        public void DrawUserPrimitive<T>(PrimitiveType primitiveType, T[] vertexData, int vertexOffset, int primitiveCount, VertexDeclaration vertexDeclaration) where T : struct, IVertexType
        {
            throw new NotImplementedException();
            //TODO: nativeDevice.DrawUserPrimitive(primitiveCount, vertexOffset);
        }

        public void SetVertexBuffer(VertexBuffer vertexBuffer)
        {
            nativeDevice.SetVertexBuffer(vertexBuffer);
        }

        public void SetVertexBuffer(VertexBuffer vertexBuffer, int vertexOffset)
        {
            nativeDevice.SetVertexBuffer(vertexBuffer, vertexOffset);
        }

        public void SetVertexBuffers(Graphics.VertexBufferBinding[] vertexBuffers)
        {
            nativeDevice.SetVertexBuffers(vertexBuffers);
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public INativeGraphicsDevice NativeDevice
        {
            get
            {
                return this.nativeDevice;
            }
        }

        public IndexBuffer Indices
        {
            get
            {
                return this.indexBuffer;
            }
            set
            {
                if (this.indexBuffer != value)
                {
                    this.indexBuffer = value;
                    NativeDevice.SetIndexBuffer(this.indexBuffer);
                }
            }
        }

        public Viewport Viewport
        {
            get
            {
                return this.viewport;
            }
            set
            {
                this.Viewport = value;
            }
        }

        public BlendState BlendState
        {
            get
            {
                return this.blendState;
            }
            set
            {
                if (this.blendState != value)
                {
                    if (this.blendState != null)
                    {
                        this.blendState.NativeBlendState.Release();
                    }

                    this.blendState = value;

                    this.blendState.NativeBlendState.Apply(this);
                }
            }
        }

        public DepthStencilState DepthStencilState
        {
            get
            {
                return this.depthStencilState;
            }
            set
            {
                if (this.depthStencilState != value)
                {
                    if (this.depthStencilState != null)
                    {
                        this.depthStencilState.NativeDepthStencilState.Release();
                    }

                    this.depthStencilState = value;

                    this.depthStencilState.NativeDepthStencilState.Apply(this);
                }
            }
        }

        public RasterizerState RasterizerState
        {
            get
            {
                return this.rasterizerState;
            }
            set
            {
                if (this.rasterizerState != value)
                {
                    if (this.rasterizerState != null)
                    {
                        this.rasterizerState.NativeRasterizerState.Release();
                    }

                    this.rasterizerState = value;

                    this.rasterizerState.NativeRasterizerState.Apply(this);
                }
            }
        }

        public SamplerStateCollection SamplerStates
        {
            get
            {
                return this.samplerStateCollection;
            }
        }
    }
}
