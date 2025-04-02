using System;
using SatisfactoryTools.FactoryPlanner.Data.Models;

namespace SatisfactoryTools.FactoryPlanner.Repositories
{
    public class FactoryPlannerPersistence : IFactoryPlannerPersistence
    {
        private readonly FactoryPlannerDatabaseContext dbContext;

        private IEnumValueRepository<NodePurity>? nodePurityRepository;
        private IEnumValueRepository<BuildingCategory>? buildingCategoryRepository;

        public FactoryPlannerPersistence(FactoryPlannerDatabaseContext dbContext)
        {
            this.dbContext = dbContext;
        }

        /// <inheritdoc />
        public IEnumValueRepository<NodePurity> NodePurityRepository
        {
            get
            {
                return nodePurityRepository ??= new NodePurityRepository(dbContext);
            }
        }

        /// <inheritdoc />
        public IEnumValueRepository<BuildingCategory> BuildingCatergoryRepository
        {
            get
            {
                return buildingCategoryRepository ??= new BuildingCategoryRepository(dbContext);
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