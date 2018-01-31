namespace SolidExamples.OpenClosedPrinciple.Solution
{
	class SquareDrawer : IDrawer
	{
		private readonly Square _square;

		public SquareDrawer(Square square)
		{
			_square = square;
		}

		public void Draw()
		{
			// Doing some complicated stuff
		}
	}
}
