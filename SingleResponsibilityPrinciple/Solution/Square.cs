namespace SolidExamples.SingleResponsibilityPrinciple.Solution
{

    public class Square
    {
        public int SideLength { get { return _sideLength; } }
        private readonly int _sideLength;
        public Square(int sideLength){
            _sideLength = sideLength;
        }
    }
}
