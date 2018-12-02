using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;

namespace Equaliser.Engine
{
	class PointCollider : Collider
	{
		public Vector2 Offset { get; protected set; }

		public PointCollider(IPhysical<GameObject> _parent)
		{
			this.Parent = _parent;
			this.Offset = Vector2.Zero;
			this.Type = ColliderType.Point;
		}

		public PointCollider(IPhysical<GameObject> _parent, Vector2 _offset)
		{
			this.Parent = _parent;
			this.Offset = _offset;
			this.Type = ColliderType.Point;
		}

		public override bool Intersects(Collider _other)
		{
			switch (_other.Type)
			{
				case ColliderType.Null:
				case ColliderType.Point:
				case ColliderType.Ray:
					return false;
				case ColliderType.Rectangle:
				case ColliderType.Circle:
				case ColliderType.Box:
					return _other.ContainsPoint(this.Transform.location + (this.Offset * this.Transform.scale));
				default:
					return false;
			}
		}

		public override bool ContainsPoint(Vector2 _point)
		{
			return false;
		}
	}
}
