using SatisfactoryTools.FactoryPlanner.Data.Models;

namespace SatisfactoryTools.FactoryPlanner.Repositories
{
    public interface IItemCategoryRepository
    {
        ItemCategory GetByName(string name);
    }
}