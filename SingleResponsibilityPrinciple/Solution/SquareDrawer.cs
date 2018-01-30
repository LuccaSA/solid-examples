namespace SolidExamples.SingleResponsibilityPrinciple.Solution
{
	class SquareDrawer
	{
		private readonly Square _square;

		public SquareDrawer(Square square)
		{
			_square = square;
		}
		private void drawLine(int xa, int ya, int xb, int yb)
		{
			//Do something;
		}

		public void Draw()
		{
			drawLine(0, 0, _square.Size, 0);
			drawLine(0, 0, 0, _square.Size);
			drawLine(0, _square.Size, _square.Size, _square.Size);
			drawLine(_square.Size, 0, _square.Size, _square.Size);
		}
	}
}
