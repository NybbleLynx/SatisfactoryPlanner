using System;

namespace SatisfactoryTools.FactoryPlanner.Repositories
{
    public interface IFactoryPlannerPersistence : IDisposable
    {
        INodePurityRepository NodePurityRepository { get; }
        IItemCategoryRepository ItemCategoryRepository { get; }
        IBuildingCatergoryRepository BuildingCatergoryRepository { get; }

        public void SaveChanges();
    }
}