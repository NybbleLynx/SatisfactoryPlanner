using System.Linq;
using SatisfactoryTools.FactoryPlanner.Data.Models;

namespace SatisfactoryTools.FactoryPlanner.Repositories
{
    public class ItemCategoryRepository : IItemCategoryRepository
    {
        private readonly FactoryPlannerDatabaseContext dbContext;

        public ItemCategoryRepository(FactoryPlannerDatabaseContext dbContext)
        {
            this.dbContext = dbContext;
        }

        /// <inheritdoc />
        public ItemCategory GetByName(string name)
        {
            return dbContext.ItemCategories.Single(cat => cat.Name == name);
        }
    }
}