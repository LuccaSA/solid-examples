namespace SolidExamples.SingleResponsibilityPrinciple.Violation
{
    class Square
    {
        private readonly int _size;

        public Square(int size)
        {
            _size = size;
        }

        private void drawLine(int xa, int ya, int xb, int yb)
        {
            //Do something;
        }

        public void Draw()
        {
            drawLine(0, 0, _size, 0);
            drawLine(0, 0, 0, _size);
            drawLine(0, _size, _size, _size);
            drawLine(_size, 0, _size, _size);
        }
    }
}
