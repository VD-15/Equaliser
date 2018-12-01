using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace Equaliser.Engine
{
	class Animation
	{
		public Rectangle[] frames { get; }
		public float interval { get; }
		public int currentFrame { get; private set; }
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

			int change = 0;

			while (time > interval)
			{
				change++;
				time -= interval;
			}

			currentFrame += change;

			if (currentFrame > frames.Length)
			{
				if (repeats)
				{
					currentFrame %= frames.Length;
				}
				else
				{
					currentFrame = frames.Length - 1;
				}
			}
		}
	}
}
