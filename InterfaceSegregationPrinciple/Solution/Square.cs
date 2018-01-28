namespace SolidExamples.InterfaceSegregationPrinciple.Solution
{
	class Square : IAreaCalculable
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
	}
}
