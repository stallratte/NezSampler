using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;
using Nez;

namespace NezSampler;

public class MyGame : Core {

	protected override void Initialize() {
		base.Initialize();
		Scene = new Scene1();
		Scene.AddPostProcessor(new BloomPostProcessor(0));
	}

	protected override void Update(GameTime gameTime) {
		base.Update(gameTime);

		Scene nextScene = null;
		
		if (Input.IsKeyPressed(Keys.Space)) {
			if (Scene is Scene1) {
				nextScene = new Scene2(); }
			else {
				nextScene = new Scene1();
			}

		}
		
		if (nextScene != null) {
			nextScene.AddPostProcessor(new BloomPostProcessor(0));
			Scene = nextScene;
		}
		
	}

}