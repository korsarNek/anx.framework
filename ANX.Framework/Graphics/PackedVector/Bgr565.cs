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
    public struct Bgr565 : IPackedVector<UInt16>, IEquatable<Bgr565>, IPackedVector
    {
        private UInt16 packedValue;

        public Bgr565(float x, float y, float z)
        {
            uint r = (uint)(MathHelper.Clamp(x, 0f, 1f) * 31.0f) << 11;
            uint g = (uint)(MathHelper.Clamp(y, 0f, 1f) * 63.0f) << 5;
            uint b = (uint)(MathHelper.Clamp(z, 0f, 1f) * 31.0f);

            this.packedValue = (ushort)((r | g) | b);
        }

        public Bgr565(Vector3 vector)
        {
            uint r = (uint)(MathHelper.Clamp(vector.X, 0f, 1f) * 31.0f) << 11;
            uint g = (uint)(MathHelper.Clamp(vector.Y, 0f, 1f) * 63.0f) << 5;
            uint b = (uint)(MathHelper.Clamp(vector.Z, 0f, 1f) * 31.0f);

            this.packedValue = (ushort)((r | g) | b);
        }

        public ushort PackedValue
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

        public Vector3 ToVector3()
        {
            return new Vector3( ((packedValue >> 11) & 31) / 31.0f,
                                ((packedValue >> 5) & 63) / 63.0f,
                                ((packedValue) & 31) / 31.0f);
        }

        void IPackedVector.PackFromVector4(Vector4 vector)
        {
            uint r = (uint)(MathHelper.Clamp(vector.X, 0f, 1f) * 31.0f) << 11;
            uint g = (uint)(MathHelper.Clamp(vector.Y, 0f, 1f) * 63.0f) << 5;
            uint b = (uint)(MathHelper.Clamp(vector.Z, 0f, 1f) * 31.0f);

            this.packedValue = (ushort)((r | g) | b);
        }

        Vector4 IPackedVector.ToVector4()
        {
            return new Vector4(this.ToVector3(), 1f);
        }

        public override bool Equals(object obj)
        {
            if (obj != null && obj.GetType() == this.GetType())
            {
                return this == (Bgr565)obj;
            }

            return false;
        }

        public bool Equals(Bgr565 other)
        {
            return this.packedValue == other.packedValue;
        }

        public override string ToString()
        {
            return this.packedValue.ToString("X4");
        }

        public override int GetHashCode()
        {
            return this.packedValue.GetHashCode();
        }

        public static bool operator ==(Bgr565 lhs, Bgr565 rhs)
        {
            return lhs.packedValue == rhs.packedValue;
        }

        public static bool operator !=(Bgr565 lhs, Bgr565 rhs)
        {
            return lhs.packedValue != rhs.packedValue;
        }
    }
}
