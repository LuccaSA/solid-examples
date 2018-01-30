namespace SolidExamples.OpenClosedPrinciple.Violation
{
	class Square : IShape
	{
		public int Size { get { return _size; } }

		public readonly int _size;

		public Square(int size)
		{
			_size = size;
		}
	}
}
