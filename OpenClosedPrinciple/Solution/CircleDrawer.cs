using System;

namespace SolidExamples.OpenClosedPrinciple.Solution
{
	class CircleDrawer : IDrawer
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
