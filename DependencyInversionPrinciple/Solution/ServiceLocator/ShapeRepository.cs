using SolidExamples.InterfaceSegregationPrinciple.Solution;
using System.Collections.Generic;

namespace SolidExamples.DependencyInversionPrinciple.Solution.ServiceLocator
{
	class ShapeRepository
	{
		private readonly IDatabase _database;

		public ShapeRepository()
		{
			_database = ServiceLocator.Resolve<IDatabase>();
		}

		public IEnumerable<Square> GetAllSquares()
		{
			return _database.GetAllData<Square>();
		}
	}
}
