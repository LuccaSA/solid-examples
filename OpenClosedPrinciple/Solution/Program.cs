namespace SolidExamples.OpenClosedPrinciple.Solution
{
	class Program
	{
		public void Main()
		{
			var drawers = new IDrawer[]{
				new SquareDrawer(new Square(5)),
				new SquareDrawer(new Square(3)),
				new CircleDrawer(new Circle(1))
			};

			foreach (IDrawer drawer in drawers)
			{
				drawer.Draw();
			}
		}
	}
}
