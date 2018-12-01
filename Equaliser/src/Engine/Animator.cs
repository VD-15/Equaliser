using System.Collections.Generic;

namespace Equaliser.Engine
{
	class Animator
	{
		public Dictionary<string, Animation> animations;
		public string currentAnimation { get; private set; }

		public Animator()
		{
			animations = new Dictionary<string, Animation>();
			currentAnimation = "";
		}

		public void SetAnimation(string a)
		{
			currentAnimation = a;

			Animation anim = null;

			if (animations.TryGetValue(a, out anim))
			{
				anim.Reset();
			}
		}

		public void AddAnimation(string _name, Animation _animation)
		{
			if (!animations.ContainsKey(_name))
			{
				animations.Add(_name, _animation);
			}
			else
			{
				animations[_name] = _animation;
			}
		}

		public void Animate(AnimateArgs e)
		{
			animations[currentAnimation].Tick(e.gameTime);
		}
	}
}