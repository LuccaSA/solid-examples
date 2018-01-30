using System;

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
			throw new NotImplementedException();
		}
	}
}
