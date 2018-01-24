using System;

namespace SolidExamples.LiskovSubstitutionPrinciple.Violation
{
    class Example
    {
        public void TestRectangleArea()
        {
            var rectangle = new Rectangle();

            AssertArea(rectangle);
        }

        public void TestSquareArea()
        {
            var square = new Square();

            AssertArea(square);
        }

        public void AssertArea(Rectangle rectangle)
        {
            rectangle.SetWidth(5);
            rectangle.SetHeight(4);

            if (rectangle.Area() != 20)
            {
                throw new Exception("Wrong area!");
            }
        }
    }
}
