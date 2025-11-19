using NezSampler;

public class Program {

	[STAThread]
	static void Main(string[] args)
	{
		// SDL_GPU (Vulkan, Metal, D3D12)
		// D3D11
		// OpenGL
		Environment.SetEnvironmentVariable("FNA3D_FORCE_DRIVER", "D3D12");
		
		using (MyGame g = new MyGame())
		{
			g.Run();
		}
	}

}