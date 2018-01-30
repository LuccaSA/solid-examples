using System;

namespace SolidExamples.LiskovSubstitutionPrinciple.Solution
{
	class Example
	{
		public void TestRectangleArea()
		{
			var rectangle = new Rectangle();
			rectangle.SetWidth(5);
			rectangle.SetHeight(4);
			AssertArea(20, rectangle);
		}

		public void TestSquareArea()
		{
			var square = new Square();
			square.SetSize(5);
			AssertArea(25, square);
		}

		private void AssertArea(int expected, IShape actualShape)
		{
			if (actualShape.Area() != expected) throw new Exception("Wrong area!");
		}
	}
}
