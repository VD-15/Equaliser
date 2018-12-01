using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace Equaliser.Engine
{
	enum AnimationState
	{
		Stopped,
		Paused,
		PlayingF
	}

	class Animation
	{
		public Texture2D spriteSheet { get; }
		public Rectangle[] frames { get; }
		public float interval { get; }
		private int currentFrame { get; }
		private float time;
		private bool repeats;
		private Sprite sprite;
		private AnimationState state;

		public Animation(Texture2D _sheet, Rectangle[] _frames, float _interval, bool _repeats)
		{
			spriteSheet = _sheet;
			frames = _frames;
			interval = _interval;
			repeats = _repeats;
		}

		public void Tick(float _time)
		{

		}
	}
}
