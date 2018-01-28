namespace SolidExamples.InterfaceSegregationPrinciple.Violation
{
	class Cube : IShape
	{
		private int _size;

		public void SetSize(int size)
		{
			_size = size;
		}

		public int Area()
		{
			return 6 * _size * _size;
		}

		public int Volume()
		{
			return _size * _size * _size;
		}
	}
}
