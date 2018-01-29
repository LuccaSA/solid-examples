namespace SolidExamples.OpenClosedPrinciple.Solution
{

    public class Square : IShape
    {
        public int SideLength { get { return _sideLength; } }
        public readonly int _sideLength;
        public Square(int sideLength){
            _sideLength = sideLength;
        }
    }
}
