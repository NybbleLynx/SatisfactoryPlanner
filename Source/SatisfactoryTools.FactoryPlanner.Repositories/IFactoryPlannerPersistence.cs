using System;

namespace SatisfactoryTools.FactoryPlanner.Repositories
{
    public interface IFactoryPlannerPersistence : IDisposable
    {
        INodePurityRepository NodePurityRepository { get; }

        public void SaveChanges();
    }
}