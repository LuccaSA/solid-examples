namespace LiskovSubstitutionPrinciple
{
    interface IShape
    {
        int Area();
    }

    class Rectangle : IShape
    {
        private int _width;
        private int _height;

        public void setWidth(int width)
        {
            _width = width;
        }

        public void setHeight(int height)
        {
            _height = height;
        }

        public int Area()
        {
            return _width * _height;
        }
    }

    class Square : IShape
    {
        private int _size;

        public void setSize(int size)
        {
            _size = size;
        }

        public int Area()
        {
            return _size * _size;
        }
    }
}
