using NezSampler;

public class Program {

	[STAThread]
	static void Main(string[] args)
	{
		using (MyGame g = new MyGame())
		{
			g.Run();
		}
	}

}