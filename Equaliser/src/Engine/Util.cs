using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace Equaliser.Engine
{
	static class Util
	{
		public static Rectangle GetCenteredRectangle(Vector2 location, Vector2 size)
		{
			return new Rectangle(
				(int)(location.X - (size.X * 0.5f)),
				(int)(location.Y - (size.Y * 0.5f)),
				(int)(size.X),
				(int)(size.Y)
			);
		}

		public static Vector2 WorldToScreen(Vector2 location, GraphicsDevice device)
		{
			return new Vector2(
				((device.Viewport.Width / 2f) + location.X),
				((device.Viewport.Height / 2f) - location.Y)
				);
		}

		public static float Square(float _f)
		{
			return _f * _f;
		}
	}
}
