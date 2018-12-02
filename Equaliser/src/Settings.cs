using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace Equaliser
{
	public class Settings
	{
		public static readonly Keys MOVE_UP = Keys.W;
		public static readonly Keys MOVE_DOWN = Keys.S;
		public static readonly Keys MOVE_LEFT = Keys.A;
		public static readonly Keys MOVE_RIGHT = Keys.D;
        public static readonly Keys ATTACK = Keys.Space;
	}

	//This is the global to-do list, put TODO's here if they don't have anywhere else to go in the code
	//TODO: Rectangle Colliders
	//TODO: Box Colliders (Rectangle colliders but with rotation)
	//TODO: Circle Colliders
	//TODO: Ray Colliders
	//TODO: Acceleration-based player movement
}
