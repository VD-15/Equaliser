using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace Equaliser.Engine
{
	struct Transform
	{
		public Vector2 translation;
		public Vector2 scale;
		public float rotation;

		public Transform(Vector2 _translation, Vector2 _scale, float _rotation)
		{
			translation = _translation;
			scale = _scale;
			rotation = _rotation;
		}

		void Translate(Vector2 _translation)
		{
			translation += _translation;
		}

		void Scale(float _factor)
		{
			scale *= _factor;
		}

		void Scale(Vector2 _scale)
		{
			scale.X *= _scale.X;
			scale.Y *= _scale.Y;
		}

		void Rotate(float _rotation)
		{
			rotation += _rotation;
		}
	}
}
