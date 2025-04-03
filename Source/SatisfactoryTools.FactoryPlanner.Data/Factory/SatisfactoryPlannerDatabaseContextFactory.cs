#region File Header
// ---------------------------------------------------------------------
// Filename: SatisfactoryPlannerDatabaseContextFactory.cs
// Description: Provides the functionality to create the Satisfactory Planner Database Context.
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

namespace SatisfactoryTools.FactoryPlanner.Data.Factory
{
    public class SatisfactoryPlannerDatabaseContextFactory : ISatisfactoryPlannerDatabaseContextFactory
    {
        private DbContextOptions options;

        public SatisfactoryPlannerDatabaseContextFactory(DbContextOptions options)
        {
            this.options = options;
        }

        /// <inheritdoc />
        public ISatisfactoryPlannerDatabaseContextFactory CreateDatabaseContext() => new SatisfactoryPlannerDatabaseContextFactory(options);
    }
}