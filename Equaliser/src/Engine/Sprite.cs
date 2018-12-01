using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System.Collections.Generic;

namespace Equaliser.Engine
{
	class Sprite
	{
		public static Dictionary<string, Texture2D> LOADED_TEXTURES = new Dictionary<string, Texture2D>();
		
		public Rectangle crop;
		public Color color;
		public string textureName { get; private set; }

		public Sprite(string _texName, Rectangle _crop, Color _col)
		{
			textureName = _texName;

			crop = _crop;
			color = _col;
		}

		public Texture2D GetTexture()
		{
			Texture2D texture = null;

			if (!LOADED_TEXTURES.TryGetValue(textureName, out texture))
			{
				throw new System.Exception("IMMA BITCH AND IMMA THROW A BITCH FIT!");
			}

			return texture;
		}
	}
}
