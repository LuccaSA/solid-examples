using System.Collections.Generic;

namespace SolidExamples.DependencyInversionPrinciple.Solution
{
	class Database : IDatabase
	{
		public IEnumerable<T> GetAllData<T>()
		{
			throw new System.NotImplementedException();
		}
	}
}
