namespace SolidExamples.SingleResponsibilityPrinciple.Violation
{

    class Square
    {
        private readonly int _sideLength;

        public Square(int sideLength)
        {
            _sideLength = sideLength;
        }

        private void drawLine(int xa, int ya, int xb, int yb)
        {
            //Do something;
        }

        public void Draw()
        {
            drawLine(0, 0, _sideLength, 0);
            drawLine(0, 0, 0, _sideLength);
            drawLine(0, _sideLength, _sideLength, _sideLength);
            drawLine(_sideLength, 0, _sideLength, _sideLength);
        }
    }

}
