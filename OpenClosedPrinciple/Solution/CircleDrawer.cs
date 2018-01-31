namespace SolidExamples.OpenClosedPrinciple.Solution
{
	class CircleDrawer : IDrawer
	{
		private readonly Circle _circle;

		public CircleDrawer(Circle circle)
		{
			_circle = circle;
		}

		public void Draw()
		{
			// Doing some complicated stuff
		}
	}
}
