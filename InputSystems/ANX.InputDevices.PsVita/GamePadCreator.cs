using System;
using ANX.Framework.NonXNA;
using ANX.Framework.NonXNA.InputSystem;

// This file is part of the ANX.Framework created by the
// "ANX.Framework developer group" and released under the Ms-PL license.
// For details see: http://anxframework.codeplex.com/license

namespace ANX.InputDevices.PsVita
{
	public class GamePadCreator : IGamePadCreator
	{
		public string Name
		{
			get
			{
				return "PsVita.GamePad";
			}
		}

		public void RegisterCreator(InputDeviceFactory factory)
		{
			factory.AddCreator(typeof(GamePadCreator), this);
		}

		public int Priority
		{
			get
			{
				return 10;
			}
		}

		public IGamePad CreateGamePadInstance()
		{
			return new GamePad();
		}
	}
}
