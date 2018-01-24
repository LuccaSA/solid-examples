namespace SolidExamples.LiskovSubstitutionPrinciple.Violation
{
	class Rectangle
    {
		private int _width;
		private int _height;

		public virtual void SetWidth(int width)
		{
			_width = width;
		}

		public virtual void SetHeight(int height)
		{
			_height = height;
		}

		public int Area()
		{
			return _width * _height;
		}
	}
}
