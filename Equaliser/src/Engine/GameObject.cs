using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace Equaliser.Engine
{
	interface IUpdatable<T>
	{
		void preUpdate();
		void Update(UpdateArgs e);
		void postUpdate();
	}

	interface IPhysical<T>
	{
		Transform getTransform();
	}

	interface IDrawable<T>
	{

	}

	interface IAnimatable<T>
	{

	}

	class GameObject
	{

	}
}
