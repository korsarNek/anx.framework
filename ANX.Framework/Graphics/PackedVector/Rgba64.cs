﻿#region Using Statements
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

namespace ANX.Framework.Graphics.PackedVector
{
    public struct Rgba64 : IPackedVector<ulong>, IEquatable<Rgba64>, IPackedVector
    {
        private ulong packedValue;

        public Rgba64(float x, float y, float z, float w)
        {
            ulong r = (ulong)(MathHelper.Clamp(x, 0f, 1f) * 65535f) << 0;
            ulong g = (ulong)(MathHelper.Clamp(y, 0f, 1f) * 65535f) << 16;
            ulong b = (ulong)(MathHelper.Clamp(z, 0f, 1f) * 65535f) << 32;
            ulong a = (ulong)(MathHelper.Clamp(w, 0f, 1f) * 65535f) << 48;

            this.packedValue = (ulong)(r | g | b | a);
        }

        public Rgba64(Vector4 vector)
        {
            ulong r = (ulong)(MathHelper.Clamp(vector.X, 0f, 1f) * 65535f) << 0;
            ulong g = (ulong)(MathHelper.Clamp(vector.Y, 0f, 1f) * 65535f) << 16;
            ulong b = (ulong)(MathHelper.Clamp(vector.Z, 0f, 1f) * 65535f) << 32;
            ulong a = (ulong)(MathHelper.Clamp(vector.W, 0f, 1f) * 65535f) << 48;

            this.packedValue = (ulong)(r | g | b | a);
        }

        public ulong PackedValue
        {
            get
            {
                return this.packedValue;
            }
            set
            {
                this.packedValue = value;
            }
        }

        public Vector4 ToVector4()
        {
            return new Vector4(((packedValue >>  0) & 65535) / 65535f,
                               ((packedValue >> 16) & 65535) / 65535f,
                               ((packedValue >> 32) & 65535) / 65535f,
                               ((packedValue >> 48) & 65535) / 65535f);
        }

        void IPackedVector.PackFromVector4(Vector4 vector)
        {
            ulong r = (ulong)(MathHelper.Clamp(vector.X, 0f, 1f) * 65535f) << 0;
            ulong g = (ulong)(MathHelper.Clamp(vector.Y, 0f, 1f) * 65535f) << 16;
            ulong b = (ulong)(MathHelper.Clamp(vector.Z, 0f, 1f) * 65535f) << 32;
            ulong a = (ulong)(MathHelper.Clamp(vector.W, 0f, 1f) * 65535f) << 48;

            this.packedValue = (ulong)(r | g | b | a);
        }

        public override bool Equals(object obj)
        {
            if (obj != null && obj.GetType() == this.GetType())
            {
                return this == (Rgba64)obj;
            }

            return false;
        }

        public bool Equals(Rgba64 other)
        {
            return this.packedValue == other.packedValue;
        }

        public override string ToString()
        {
            return this.ToVector4().ToString();
        }

        public override int GetHashCode()
        {
            return this.packedValue.GetHashCode();
        }

        public static bool operator ==(Rgba64 lhs, Rgba64 rhs)
        {
            return lhs.packedValue == rhs.packedValue;
        }

        public static bool operator !=(Rgba64 lhs, Rgba64 rhs)
        {
            return lhs.packedValue != rhs.packedValue;
        }
    }
}
