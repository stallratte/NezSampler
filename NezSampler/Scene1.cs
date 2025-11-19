using Microsoft.Xna.Framework;
using Nez;
using Nez.Sprites;

namespace NezSampler;

public class Scene1 : Scene {

	public override void Initialize() {
		var texture = Content.LoadTexture("Content/scene1.png");
		
		var entity = CreateEntity("textureEntity", new Vector2(Screen.Width / 2, Screen.Height / 2));
		entity.AddComponent(new SpriteRenderer(texture));
	}

}