namespace SolidExamples.OpenClosedPrinciple.Violation
{
	class SquareDrawer
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
