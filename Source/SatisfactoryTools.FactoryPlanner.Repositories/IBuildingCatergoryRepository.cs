using SatisfactoryTools.FactoryPlanner.Data.Models;

namespace SatisfactoryTools.FactoryPlanner.Repositories
{
    public interface IBuildingCatergoryRepository
    {
        BuildingCategory GetByName(string name);
    }
}