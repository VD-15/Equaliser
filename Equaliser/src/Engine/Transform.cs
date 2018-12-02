using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace Equaliser.Engine
{
	struct Transform
	{
		public Vector2 location;
		public Vector2 scale;
		public float rotation;

		public Transform(Vector2 _location, Vector2 _scale, float _rotation)
		{
			location = _location;
			scale = _scale;
			rotation = _rotation;
		}

		public void Translate(Vector2 _location)
		{
			location += _location;
		}

		public void Scale(float _factor)
		{
			scale *= _factor;
		}

		public void Scale(Vector2 _scale)
		{
			scale.X *= _scale.X;
			scale.Y *= _scale.Y;
		}

		public void Rotate(float _rotation)
		{
			rotation += _rotation;
		}
	}
}
