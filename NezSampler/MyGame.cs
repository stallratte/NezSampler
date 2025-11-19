using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;
using Nez;

namespace NezSampler;

public class MyGame : Core {

	protected override void Initialize() {
		base.Initialize();
		Scene = new Scene1();
	}

	protected override void Update(GameTime gameTime) {
		base.Update(gameTime);

		if (Keyboard.GetState().IsKeyDown(Keys.Space)) {
			if (Scene is Scene1) {
				Scene = new Scene2();
			}
			else {
				Scene = new Scene1();
			}
			
			
		}
		
	}

}