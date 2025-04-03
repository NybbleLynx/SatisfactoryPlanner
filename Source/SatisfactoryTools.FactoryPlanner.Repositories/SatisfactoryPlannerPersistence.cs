#region File Header
// ---------------------------------------------------------------------
// Filename: SatisfactoryPlannerPersistence.cs
// Description: Provides the functionality to query, create, update and delete data from the satisfactory planner database.
// Author: NybbleLynx
// Created: 3rd April 2025
// ---------------------------------------------------------------------
// Project licence Information:
// 
// ---------------------------------------------------------------------
// Additional Info:
// ---------------------------------------------------------------------
#endregion

using System;
using SatisfactoryTools.FactoryPlanner.Data.Models;

namespace SatisfactoryTools.FactoryPlanner.Repositories
{
    public class SatisfactoryPlannerPersistence : ISatisfactoryPlannerPersistence
    {
        private readonly SatisfactoryPlannerDatabaseContext dbContext;

        public SatisfactoryPlannerPersistence(SatisfactoryPlannerDatabaseContext dbContext)
        {
            this.dbContext = dbContext;
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