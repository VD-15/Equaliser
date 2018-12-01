using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Equaliser.Engine;

namespace Equaliser
{
    class Player : GameObject, IPhysical<GameObject>, IVisible<GameObject>, IUpdatable<GameObject>
    {
        private Transform transform;
        private readonly Rectangle bounds = new Rectangle(-960, -540, 960, 540);
		private Sprite sprite;
		
        public int health
        {
            get { return health; }
            set { health = value; }
        }
		
        public Player(Vector2 position)
        {
            transform.translation = position;
			
			sprite = new Sprite(GameWindow.LOADED_SPRITES[@"player0.png"], new Rectangle(0, 0, 32, 32), Color.White);
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
            if (e.KS.IsKeyDown(Settings.ATTACK))
            {
				Attack();
            }

            move(translation);


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
			e.SB.Draw(sprite.texture, sprite.crop, (this as IPhysical<GameObject>).GetCenteredRectangle(new Vector2(16f, 16f)), sprite.color);
        }

		public Sprite GetSprite()
		{
			return sprite;
		}
	}
}
