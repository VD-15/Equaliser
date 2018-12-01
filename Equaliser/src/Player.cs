using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Equaliser.Engine;

namespace Equaliser
{

    class Player : GameObject, IPhysical<Player>, IVisible<Player>, IAnimatable<Player>, IUpdatable<Player>
    {
        private Transform transform;
        private readonly float speed = 1f;
        private readonly Rectangle bounds = new Rectangle(0,0,1920,1080);


        private int health = 10;


        public Player(Vector2 position)
        {
            transform.translation = position;
        }

        public void Update(UpdateArgs e)
        {
            
        }

        public int GetHealth()
        {
            return health;
        }
        public void AddHealth()
        {
            health++;
        }


        private void move(Vector2 translation)
        {
            Vector2 nextPosition = translation;

            if (bounds.Contains(nextPosition))
            {
                if (nextPosition.X > transform.translation.X) {
                    //Right

                }
                else if (nextPosition.X < transform.translation.X)
                {
                    //Left

                }
                else if (nextPosition.Y > transform.translation.Y && (nextPosition.Y - transform.translation.Y) > (nextPosition.X - transform.translation.X))
                {
                    //Up

                }
                else if (nextPosition.Y < transform.translation.Y && (nextPosition.Y - transform.translation.Y) < (nextPosition.X - transform.translation.X))
                {
                    //Down

                }


                transform.translation = nextPosition;
            }
        }

        private void SetSprite(int index)
        {
            switch (index)
            {
                case 1:
                    break;
                case 2:
                    break;
                case 3:
                    break;
                case 4:
                    break;
                default: break;
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

		public void Animate(AnimateArgs e)
		{
			throw new System.NotImplementedException();
		}

		public Animator GetAnimator()
		{
			throw new System.NotImplementedException();
		}
	}
}
