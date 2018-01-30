namespace SolidExamples.SingleResponsibilityPrinciple.Violation
{
	class Program
	{
		public void Main()
		{
			var square = new Square(5);

			square.Draw();
		}
	}
}
