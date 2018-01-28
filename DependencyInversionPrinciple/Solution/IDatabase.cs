using System.Collections.Generic;

namespace SolidExamples.DependencyInversionPrinciple.Solution
{
	interface IDatabase
    {
		IEnumerable<T> GetAllData<T>();
	}
}
