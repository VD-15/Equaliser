using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;

namespace Equaliser.Engine
{
	class CircleCollider : Collider
	{
		public float Radius { get; protected set; }

		public CircleCollider(IPhysical<GameObject> _parent, float _radius)
		{
			this.Parent = _parent;
			this.Radius = _radius;
		}

		public override bool Intersects(Collider _other)
		{
			return base.Intersects(_other);
		}

		public override bool ContainsPoint(Vector2 _point)
		{
			return (Util.Square(this.Radius * Math.Min(this.Transform.scale.X, this.Transform.scale.Y)) > Vector2.DistanceSquared(_point, this.Transform.location));
		}
	}
}
