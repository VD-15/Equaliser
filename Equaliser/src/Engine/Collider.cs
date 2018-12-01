using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace Equaliser.Engine
{
	class Collider
	{
		private Vector2 size;
		private Transform transform;

		public bool Intersects(Collider collider) {
			return false;
		}

		public bool Intersects(Collider[] colliders)
		{
			foreach(Collider c in colliders)
				if(Intersects(c))
					return true;
			return false;
		}

	}
}
