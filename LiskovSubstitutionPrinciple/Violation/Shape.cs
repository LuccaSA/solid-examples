namespace SolidExamples.LiskovSubstitutionPrinciple.Violation
{
	class Square : Rectangle
	{
		public override void SetWidth(int width)
		{
			base.SetWidth(width);
			base.SetHeight(width);
		}

		public override void SetHeight(int height)
		{
			base.SetWidth(height);
			base.SetHeight(height);
		}
	}
}
