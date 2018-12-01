using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Equaliser.Engine;

namespace Equaliser
{

    class Player : GameObject, IPhysical<Player>, IVisible<Player>, IAnimatable<Player>, IUpdatable<Player>
    {
        private Transform transform;
        private readonly Rectangle bounds = new Rectangle(-960, -540, 960, 540);


        public int health
        {
            get { return health; }
            set { health = value; }
        }


        public Player(Vector2 position)
        {
            transform.translation = position;
        }

        public void Update(UpdateArgs e)
        {
            Vector2 translation = new Vector2();


            if (e.KS.IsKeyDown(Settings.MOVE_RIGHT)) //right
            {
                translation.X += 1 * e.gameTime;
            }
            else if (e.KS.IsKeyDown(Settings.MOVE_LEFT)) //left
            {
                translation.X -= 1 * e.gameTime;
            }

            if (e.KS.IsKeyDown(Settings.MOVE_UP)) //up
            {
                translation.Y += 1 * e.gameTime;
            }
            else if (e.KS.IsKeyDown(Settings.MOVE_DOWN)) //down
            {
                translation.Y -= 1 * e.gameTime;
            }

            move(translation);

			if (e.KS.IsKeyDown(Settings.ATTACK))
			{
				Attack();
			}
		}

        private void Attack()
        {
            
        }

        private void move(Vector2 translation)
        {
            Vector2 nextPosition = translation;

            if (bounds.Contains(nextPosition))
            {
                transform.translation = nextPosition;
            }
        }
        

        public Transform GetTransform()
        {
            return transform;
        }

        public void PostUpdate()
        {
        }

        public void Draw(DrawArgs e)
        {
			
        }
    }
}
