using SolidExamples.InterfaceSegregationPrinciple.Solution;
using System.Collections.Generic;

namespace SolidExamples.DependencyInversionPrinciple.Solution.DependencyInjection
{
	class ShapeRepository
	{
		private readonly IDatabase _database;

		public ShapeRepository(IDatabase database)
		{
			_database = database;
		}

		public IEnumerable<Square> GetAllSquares()
		{
			return _database.GetAllData<Square>();
		}
	}
}
