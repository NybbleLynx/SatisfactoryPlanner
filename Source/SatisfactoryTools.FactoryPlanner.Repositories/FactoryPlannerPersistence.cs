using System;
using SatisfactoryTools.FactoryPlanner.Data.Models;

namespace SatisfactoryTools.FactoryPlanner.Repositories
{
    public class FactoryPlannerPersistence : IFactoryPlannerPersistence
    {
        private readonly FactoryPlannerDatabaseContext dbContext;

        private INodePurityRepository? nodePurityRepository;
        private IItemCategoryRepository? itemCategoryRepository;
        private IBuildingCatergoryRepository? buildingCategoryRepository;

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
        public IItemCategoryRepository ItemCategoryRepository
        {
            get
            {
                return itemCategoryRepository ??= new ItemCategoryRepository(dbContext);
            }
        }

        /// <inheritdoc />
        public IBuildingCatergoryRepository BuildingCatergoryRepository
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