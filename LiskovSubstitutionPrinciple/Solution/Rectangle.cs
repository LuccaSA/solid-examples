namespace SolidExamples.LiskovSubstitutionPrinciple.Solution
{
	class Rectangle : IShape
	{
		private int _width;
		private int _height;

		public void SetWidth(int width)
		{
			_width = width;
		}

		public void SetHeight(int height)
		{
			_height = height;
		}

		public int Area()
		{
			return _width * _height;
		}
	}
}
