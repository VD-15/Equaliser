using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace Equaliser.Engine
{
	class Animation
	{
		public Rectangle[] frames { get; }
		public float interval { get; }
		private int currentFrame { get; }
		private float time;
		private bool repeats;

		public Animation(Rectangle[] _frames, float _interval, bool _repeats)
		{
			frames = _frames;
			interval = _interval;
			repeats = _repeats;
		}

		public void Tick(float _time)
		{
			time += _time;
		}
	}
}
