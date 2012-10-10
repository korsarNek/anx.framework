using System;
using ANX.Framework.NonXNA.Development;

// This file is part of the ANX.Framework created by the
// "ANX.Framework developer group" and released under the Ms-PL license.
// For details see: http://anxframework.codeplex.com/license

namespace ANX.Framework.Graphics
{
    [PercentageComplete(100)]
    [Developer("Glatzemann")]
    [TestState(TestStateAttribute.TestState.Untested)]
    public sealed class DeviceNotResetException : Exception
	{
		public DeviceNotResetException()
			: base()
		{
		}

		public DeviceNotResetException(string message)
			: base(message)
		{
		}

		public DeviceNotResetException(string message, Exception innerException)
			: base(message, innerException)
		{
		}
	}
}
