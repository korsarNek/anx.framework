﻿#region Using Statements
using System;
using System.Collections;
using System.Collections.Generic;
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
    public sealed class ModelMesh
    {
        private BoundingSphere boundingSphere;
         
        public BoundingSphere BoundingSphere
        {
            get { return boundingSphere; }
        }

        private ModelEffectCollection effects;

        public ModelEffectCollection Effects
        {
            get { return effects; }
        }

        private ModelMeshPartCollection meshParts;

        public ModelMeshPartCollection MeshParts
        {
            get { return meshParts; }
        }

        private string name;

        public string Name
        {
            get { return name; }
        }

        private ModelBone parentBone;

        public ModelBone ParentBone
        {
            get { return parentBone; }
        }

        private Object tag;

        public Object Tag
        {
            get { return tag; }
            set { this.tag = value; }
        }

        public ModelMesh(string name, ModelBone bone, BoundingSphere sphere, ModelMeshPart[] meshParts, Object tag)
        {
            this.name = name;
            this.parentBone = bone;
            this.boundingSphere = sphere;
            this.tag = tag;
            this.meshParts = new ModelMeshPartCollection(meshParts);
            this.effects = new ModelEffectCollection();

            foreach (var item in this.meshParts)
            {
                item.parentMesh = this;
                if (item.Effect != null && !this.effects.Contains(item.Effect))
                {
                    this.effects.Add(item.Effect);
                }
            }
        }

        internal void EffectChangedOnMeshPart(ModelMeshPart part, Effect oldEffect, Effect newEffect)
        {
            bool oldEffectIsInUse = false;
            bool newEffectIsKnown = false;

            foreach (var item in meshParts)
            {
                if (object.ReferenceEquals(item, part))
                {
                    continue;
                }

                if (object.ReferenceEquals(item.Effect, oldEffect))
                {
                    oldEffectIsInUse = true;
                }

                if (object.ReferenceEquals(item.Effect, newEffect))
                {
                    newEffectIsKnown = true;
                }
            }

            if (oldEffect != null && !oldEffectIsInUse)
            {
                effects.Remove(oldEffect);
            }

            if (newEffect != null && !newEffectIsKnown)
            {
                effects.Add(oldEffect);
            }
        }

        public void Draw()
        {
            foreach (var part in meshParts)
            {
                foreach (var pass in part.Effect.CurrentTechnique.Passes)
                {
                    pass.Apply();

                    GraphicsDevice graphics = part.VertexBuffer.GraphicsDevice;
                    graphics.SetVertexBuffer(part.VertexBuffer, part.VertexOffset);
                    graphics.Indices = part.IndexBuffer;
                    graphics.DrawIndexedPrimitives(PrimitiveType.TriangleList, 0, 0, part.NumVertices, part.StartIndex, part.PrimitiveCount);
                }
            }
        }
    }
}
