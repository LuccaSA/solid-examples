using SolidExamples.InterfaceSegregationPrinciple.Solution;
using System.Collections.Generic;

namespace SolidExamples.DependencyInversionPrinciple.Violation
{
	class ShapeRepository
	{
		private readonly Database _database;

		public ShapeRepository()
		{
			_database = new Database();
		}

		public IEnumerable<Square> GetAllSquares()
		{
			return _database.GetAllData<Square>();
		}
	}
}
