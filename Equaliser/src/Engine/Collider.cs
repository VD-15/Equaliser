
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace Equaliser.Engine
{
	enum ColliderType
	{
		Null,
		Point,
		Rectangle,
		Circle,
		Ray,
		Box
	}

	class Collider
	{
		//Store a reference to the GameObject to which this collider is attached
		//This makes it so the 
		public IPhysical<GameObject> Parent { get; protected set; }
		public Transform Transform { get { return this.Parent.GetTransform(); } }
		public ColliderType Type { get; protected set; }

		//Don't use this, it's just here because C# moans otherwise -V
		protected Collider()
		{
			this.Parent = null;
			this.Type = ColliderType.Null;
		}

		public Collider(IPhysical<GameObject> _parent)
		{
			this.Parent = _parent;
			this.Type = ColliderType.Null;
		}

		public virtual bool Intersects(Collider _other)
		{
			return false;
			/*
			//TODO: Move this to rectangle collider
			//TODO: take transform scale into account
			return (System.Math.Abs(this.Transform.location.X - _other.Transform.location.X) < (this.Size.X / 2) + (_other.Size.X / 2)
				&& System.Math.Abs(this.Transform.location.Y - _other.Transform.location.Y) < (this.Size.Y / 2) + (_other.Size.Y / 2));
				*/
		}

		public virtual bool ContainsPoint(Vector2 _point)
		{
			return false;
		}

	}
}
