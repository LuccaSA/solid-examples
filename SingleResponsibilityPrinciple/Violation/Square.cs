namespace SolidExamples.SingleResponsibilityPrinciple.Violation
{
	class Square
	{
		private readonly int _size;

		public Square(int size)
		{
			_size = size;
		}

		public void Draw()
		{
			// Doing some complicated stuff
		}
	}
}
