namespace SolidExamples.SingleResponsibilityPrinciple.Violation
{

    class Square
    {
        private readonly int _sideLength;
        public Square(int sideLength)
        {
            _sideLength = sideLength;
        }

        public string Draw()
        {
            string printedSquare = "";
            for(var i = 0; i < _sideLength; i++)
            {
                printedSquare = printedSquare + "*";
            }
            for (var i = 0; i < _sideLength - 2; i++)
            {
                for (var j = 0; j < _sideLength; j++)
                {
                    if(j == 0 || j == _sideLength - 1)
                    {
                        printedSquare = printedSquare + "*";
                    }
                    else
                    {
                        printedSquare = printedSquare + " ";
                    }
                }
            }
            for (var i = 0; i < _sideLength; i++)
            {
                printedSquare = printedSquare + "*";
            }
            return printedSquare;
        }
    }

}
