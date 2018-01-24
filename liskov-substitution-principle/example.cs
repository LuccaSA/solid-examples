namespace LiskovSubstitutionPrinciple
{
    class Rectangle
    {
        private int _width;
        private int _height;

        public virtual void setWidth(int width)
        {
            _width = width;
        }

        public virtual void setHeight(int height)
        {
            _height = height;
        }

        // only works for Rectangle
        public int Area()
        {
            return _width * _height;
        }
    }

    class Square : Rectangle
    {
        public override int setWidth(int width)
        {
            base.setWidth(width);
            base.setHeight(width);
        }

        public override int setHeight(int height)
        {
            base.setWidth(height);
            base.setHeight(height);
        }
    }
}
