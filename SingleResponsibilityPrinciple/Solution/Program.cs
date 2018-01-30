namespace SolidExamples.SingleResponsibilityPrinciple.Solution
{
    class Program
    {
        public void Main()
        {
            var square = new Square(5);

            var drawer = new SquareDrawer(square);

            drawer.Draw();
        }
    }
}