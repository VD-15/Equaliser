using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace Equaliser.Engine
{
	public struct DrawArgs
	{
		public SpriteBatch SB { get; }

		public DrawArgs(SpriteBatch _SB)
		{
			SB = _SB;
		}
	}
}