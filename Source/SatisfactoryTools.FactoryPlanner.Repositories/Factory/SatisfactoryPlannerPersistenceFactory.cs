#region File Header
// ---------------------------------------------------------------------
// Filename: SatisfactoryPlannerPersistenceFactory.cs
// Description: Provides functionality to create the satisfactory planner persistence.
// Author: NybbleLynx
// Created: 3rd April 2025
// ---------------------------------------------------------------------
// Project licence Information:
// 
// ---------------------------------------------------------------------
// Additional Info:
// ---------------------------------------------------------------------
#endregion

using Microsoft.EntityFrameworkCore;
using SatisfactoryTools.FactoryPlanner.Data.Models;

namespace SatisfactoryTools.FactoryPlanner.Repositories.Factory
{
    public class SatisfactoryPlannerPersistenceFactory : ICreateSatisfactoryPlannerPersistence
    {
        private readonly IDbContextFactory<SatisfactoryPlannerDatabaseContext> dbContextFactory;

        public SatisfactoryPlannerPersistenceFactory(IDbContextFactory<SatisfactoryPlannerDatabaseContext> dbContextFactory)
        {
            this.dbContextFactory = dbContextFactory;
        }

        /// <inheritdoc />
        public ISatisfactoryPlannerPersistence CreatePersistence() => new SatisfactoryPlannerPersistence(dbContextFactory.CreateDbContext());
    }
}