namespace SolidExamples.OpenClosedPrinciple.Solution
{

    public class Program
    {
        public void Main()
        {
            var drawers = new IDrawer[]{
                new SquareDrawer(new Square(5)),
                new SquareDrawer(new Square(3)),
                new CircleDrawer(new Circle(1))
            };

            foreach(var drawer in drawers){
                drawer.Draw();
            }
        }
    }
}