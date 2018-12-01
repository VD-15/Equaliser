using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace Equaliser.Engine
{
	class Sprite
	{

		public Texture2D texture;
		public Rectangle crop;
		public Color color;

		public Sprite(Texture2D _tex, Rectangle _crop, Color _col)
		{
			texture = _tex;
			crop = _crop;
			color = _col;
		}
	}
}
