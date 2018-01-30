using System;

namespace SolidExamples.OpenClosedPrinciple.Violation
{
	class CircleDrawer
	{
		private readonly Circle _circle;

		public CircleDrawer(Circle circle)
		{
			_circle = circle;
		}

		public void Draw()
		{
			throw new NotImplementedException();
		}
	}
}
