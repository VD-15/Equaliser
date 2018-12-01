using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

using Equaliser.Engine;

namespace Equaliser
{
    class GameWindow : Game
    {
        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;

		//Keyboard state and previous state, use these to detect input
		KeyboardState KS, PKS;

		//Mouse state and previous mouse state
		MouseState MS, PMS;
        
        public GameWindow()
        {
			//Initialise instance variables here.
			//All variables should be set to initialised after this,
			//but do not need to have anything in them
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";

			KS = Keyboard.GetState();
			PKS = KS;

			MS = Mouse.GetState();
			PMS = MS;
        }

        protected override void Initialize()
        {
			//Initialise the game in here as oppose to the constructor.
            base.Initialize();
        }
	
        protected override void LoadContent()
        {
			//Load any content in here
            spriteBatch = new SpriteBatch(GraphicsDevice);
        }
		
        protected override void UnloadContent()
        {
			//Won't need this for anything yet.
        }
		
        protected override void Update(GameTime gameTime)
        {
			KS = Keyboard.GetState();
			MS = Mouse.GetState();
			// Write Updating code below here.

            base.Update(gameTime);

			GameObject.OnUpdate(new UpdateArgs(KS, PKS, MS, PMS, gameTime.ElapsedGameTime.Milliseconds / 1000f));
			GameObject.OnPostupdate();

			//Don't write anything below here.
			PKS = KS;
			PMS = MS;
        }
		
        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.Black);

			spriteBatch.Begin(SpriteSortMode.FrontToBack, BlendState.AlphaBlend, SamplerState.PointClamp);

			GameObject.OnDraw(new DrawArgs(spriteBatch));

			spriteBatch.End();

            base.Draw(gameTime);
        }
    }
}
