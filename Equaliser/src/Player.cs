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
			transform = new Transform(position, Vector2.One, 0f);
			sprite = new Sprite("player0", new Rectangle(0, 0, 32, 32), Color.White);
        }

        public void Update(UpdateArgs e)
        {
            if (e.KS.IsKeyDown(Settings.MOVE_RIGHT)) //right
            {
                transform.translation.X += 100f * e.gameTime;
            }
            else if (e.KS.IsKeyDown(Settings.MOVE_LEFT)) //left
            {
				transform.translation.X -= 100f * e.gameTime;
            }

            if (e.KS.IsKeyDown(Settings.MOVE_UP)) //up
            {
				transform.translation.Y -= 100f * e.gameTime;
            }
            else if (e.KS.IsKeyDown(Settings.MOVE_DOWN)) //down
            {
				transform.translation.Y += 100f * e.gameTime;
            }
            if (e.KS.IsKeyDown(Settings.ATTACK))
            {
				Attack();
            }
        }

        private void Attack()
        {
            
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
			e.SB.Draw(sprite.GetTexture(), (this as IPhysical<GameObject>).GetCenteredRectangle(new Vector2(32f, 32f)), sprite.crop, sprite.color);
        }

		public Sprite GetSprite()
		{
			return sprite;
		}
	}
}
