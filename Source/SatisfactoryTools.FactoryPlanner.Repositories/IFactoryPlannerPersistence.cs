using System;
using SatisfactoryTools.FactoryPlanner.Data.Models;

namespace SatisfactoryTools.FactoryPlanner.Repositories
{
    public interface IFactoryPlannerPersistence : IDisposable
    {
        IEnumValueRepository<NodePurity> NodePurityRepository { get; }
        IEnumValueRepository<BuildingCategory> BuildingCatergoryRepository { get; }

        public void SaveChanges();
    }
}