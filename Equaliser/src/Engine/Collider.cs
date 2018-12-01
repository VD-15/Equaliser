﻿
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace Equaliser.Engine
{
	class Collider
	{
		private Vector2 size;
		private Transform transform;

		public bool Intersects(Collider collider)
		{
			if (this.transform.translation.X + (this.size.X / 2) >= collider.transform.translation.X - (collider.size.X / 2))
			{
				//
			}

            if (System.Math.Abs(this.transform.translation.X - collider.transform.translation.X) < (this.size.X / 2) + (collider.size.X / 2)
                && System.Math.Abs(this.transform.translation.Y - collider.transform.translation.Y) < (this.size.Y / 2) + (collider.size.Y / 2))
            {
                return true;
            }

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
