namespace SolidExamples.SingleResponsibilityPrinciple.Solution
{
	class Square
	{
		public int Size { get { return _size; } }

		private readonly int _size;

		public Square(int size)
		{
			_size = size;
		}
	}
}
