namespace SolidExamples.OpenClosedPrinciple.Violation
{
    public class Program
    {
        public void Main()
        {
            var shapes = new IShape[]{
                new Square(5), new Circle(1) /*, ...*/};

            foreach(var shape in shapes){
                if(shape is Square)
                {
                    var drawer = new SquareDrawer((Square)shape);
                    drawer.Draw();
                }
                //else if ...
            }
        }
    }
}