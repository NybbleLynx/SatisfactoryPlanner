using System.Linq;
using SatisfactoryTools.FactoryPlanner.Data.Models;

namespace SatisfactoryTools.FactoryPlanner.Repositories
{
    public class BuildingCategoryRepository : IEnumValueRepository<BuildingCategory>
    {
        private readonly FactoryPlannerDatabaseContext dbContext;

        public BuildingCategoryRepository(FactoryPlannerDatabaseContext dbContext)
        {
            this.dbContext = dbContext;
        }

        /// <inheritdoc />
        public BuildingCategory GetByName(string name)
        {
            return dbContext.BuildingCategories.Single(cat => cat.Name == name);
        }
    }
}