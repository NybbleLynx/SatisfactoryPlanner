using System;
using SatisfactoryTools.FactoryPlanner.Data.Models;

namespace SatisfactoryTools.FactoryPlanner.Repositories
{
    public class FactoryPlannerPersistence : IFactoryPlannerPersistence
    {
        private readonly FactoryPlannerDatabaseContext dbContext;

        private INodePurityRepository? nodePurityRepository;

        public FactoryPlannerPersistence(FactoryPlannerDatabaseContext dbContext)
        {
            this.dbContext = dbContext;
        }

        /// <inheritdoc />
        public INodePurityRepository NodePurityRepository
        {
            get
            {
                return nodePurityRepository ??= new NodePurityRepository(dbContext);
            }
        }

        /// <inheritdoc />
        public void SaveChanges()
        {
            dbContext.SaveChanges();
        }

        #region IDisposable Implementation

        /// <inheritdoc />
        public void Dispose()
        {
            dbContext.Dispose();
            GC.SuppressFinalize(this);
        }

        #endregion
    }
}