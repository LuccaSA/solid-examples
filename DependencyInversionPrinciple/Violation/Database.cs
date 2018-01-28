using System.Collections.Generic;

namespace SolidExamples.DependencyInversionPrinciple.Violation
{
	class Database
	{
		public IEnumerable<T> GetAllData<T>()
		{
			throw new System.NotImplementedException();
		}
	}
}
