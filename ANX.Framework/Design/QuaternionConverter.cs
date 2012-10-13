using System;
using System.Collections;
using System.ComponentModel;
using System.Globalization;
using ANX.Framework.NonXNA.Development;

// This file is part of the ANX.Framework created by the
// "ANX.Framework developer group" and released under the Ms-PL license.
// For details see: http://anxframework.codeplex.com/license

namespace ANX.Framework.Design
{
#if !WINDOWSMETRO      //TODO: search replacement for Win8
    [Developer("GinieDP")]
    [TestState(TestStateAttribute.TestState.Tested)]
    public class QuaternionConverter : MathTypeConverter
    {
        public QuaternionConverter()
        {
            base.propertyDescriptions = MathTypeConverter.CreateFieldDescriptor<Quaternion>("X", "Y", "Z", "W");
        }

        public override object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value)
        {
            float[] values = MathTypeConverter.ConvertFromString<float>(context, culture, value as String);
            if (values != null && values.Length == 4)
            {
                return new Quaternion(values[0], values[1], values[2], values[3]);
            }
            return base.ConvertFrom(context, culture, value);
        }

        public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType)
        {
            if (destinationType == null)
                throw new ArgumentNullException("destinationType");

            if (value is Quaternion)
            {
                Quaternion instance = (Quaternion)value;

                if (destinationType == typeof(string))
                    return MathTypeConverter.ConvertToString<float>(context, culture,
						new float[] { instance.X, instance.Y, instance.Z, instance.W });

				if (IsTypeInstanceDescriptor(destinationType))
					return CreateInstanceDescriptor<Quaternion>(new object[] { instance.X, instance.Y, instance.Z, instance.W });
            }

            return base.ConvertTo(context, culture, value, destinationType);
        }

        public override object CreateInstance(ITypeDescriptorContext context, IDictionary propertyValues)
        {
            if (propertyValues == null)
                throw new ArgumentNullException("propertyValues");

            return new Quaternion((float)propertyValues["X"], (float)propertyValues["Y"], (float)propertyValues["Z"], (float)propertyValues["W"]);
        }
    }

#endif
}
