using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System.Collections.Generic;

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
		Transform GetTransform();
	}

	interface IDrawable<T>
	{

	}

	interface IAnimatable<T>
	{

	}

	//GameObjects will inherit certain behavior based on the interfaces defined above.
	class GameObject
	{
		private static List<GameObject> GAMEOBJECTS = new List<GameObject>();
		private static List<GameObject> TO_ADD = new List<GameObject>();
		private static List<GameObject> TO_REMOVE = new List<GameObject>();

		static void Instantiate(GameObject g)
		{
			TO_ADD.Add(g);
		}

		static void Delete(GameObject g)
		{
			TO_REMOVE.Add(g);
		}

		static void OnPreUpdate()
		{

		}

		static void OnUpdate(UpdateArgs e)
		{

		}

		static void OnPostupdate()
		{

		}
	}
}
