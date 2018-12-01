using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace Equaliser.Engine
{
	struct DrawArgs
	{
		public SpriteBatch SB { get; }
		public GraphicsDevice device { get; }

		public DrawArgs(SpriteBatch _SB, GraphicsDevice _device)
		{
			SB = _SB;
			device = _device;
		}
	}
}