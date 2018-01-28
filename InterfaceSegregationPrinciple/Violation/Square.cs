namespace SolidExamples.InterfaceSegregationPrinciple.Violation
{
	class Square : IShape
	{
		private int _size;

		public void SetSize(int size)
		{
			_size = size;
		}

		public int Area()
		{
			return _size * _size;
		}

		public int Volume()
		{
			throw new System.NotImplementedException();
		}
	}
}
