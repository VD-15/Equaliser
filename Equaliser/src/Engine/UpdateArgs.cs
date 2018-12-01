using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace Equaliser.Engine
{
	struct UpdateArgs
	{
		public KeyboardState KS { get; }
		public KeyboardState PKS { get; }
		public MouseState MS { get; }
		public MouseState PMS { get; }
		public float gameTime { get; }

		public UpdateArgs(KeyboardState _KS, KeyboardState _PKS, MouseState _MS, MouseState _PMS, float _gameTime)
		{
			KS = _KS;
			PKS = _PKS;
			MS = _MS;
			PMS = _MS;
			gameTime = _gameTime
		}
	}
}
