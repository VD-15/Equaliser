﻿using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System.Collections.Generic;

namespace Equaliser.Engine
{
	interface IUpdatable<T>
	{
		void Update(UpdateArgs e);
		void PostUpdate();
	}

	interface IPhysical<T>
	{
		Transform GetTransform();
	}

	interface IVisible<T>
	{
		void Draw(DrawArgs e);
		Sprite GetSprite();
	}

	interface IAnimatable<T>
	{
		void Animate(AnimateArgs e);
		Animator GetAnimator();
	}

	static class InterfaceMethods
	{
		public static Rectangle GetCenteredRectangle(this IPhysical<GameObject> updatable, Vector2 size)
		{
			Transform t = updatable.GetTransform();
			return new Rectangle(
				(int)(t.translation.X - (size.X * t.scale.X)), 
				(int)(t.translation.Y - (size.Y * t.scale.Y)), 
				(int)(size.X * t.scale.Y), 
				(int)(size.Y * t.scale.Y)
			);
		}
	}

	//GameObjects will inherit certain behavior based on the interfaces defined above.
	class GameObject
	{
		private static List<GameObject> GAMEOBJECTS = new List<GameObject>();
		private static List<GameObject> TO_ADD = new List<GameObject>();
		private static List<GameObject> TO_REMOVE = new List<GameObject>();

		public static void Instantiate(GameObject g)
		{
			TO_ADD.Add(g);
		}

		public static void Delete(GameObject g)
		{
			TO_REMOVE.Add(g);
		}

		public static void OnUpdate(UpdateArgs e)
		{
			foreach (IUpdatable<GameObject> u in GAMEOBJECTS)
			{
				u.Update(e);
			}
		}

		public static void OnPostupdate()
		{
			foreach (GameObject g in TO_REMOVE)
			{
				GAMEOBJECTS.Remove(g);
			}

			TO_REMOVE.Clear();

			foreach (GameObject g in TO_ADD)
			{
				GAMEOBJECTS.Add(g);
			}

			TO_ADD.Clear();

			foreach (IUpdatable<GameObject> g in GAMEOBJECTS)
			{
				g.PostUpdate();
			}
		}

		public static void OnDraw(DrawArgs e)
		{
			foreach (IVisible<GameObject> d in GAMEOBJECTS)
			{
				d.Draw(e);
			}
		}
	}
}
