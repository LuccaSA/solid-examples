using System;

namespace SolidExamples.SingleResponsibilityPrinciple.Solution
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
