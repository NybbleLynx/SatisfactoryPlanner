#region File Header
// ---------------------------------------------------------------------
// Filename: ISatisfactoryPlannerDatabaseContextFactory.cs
// Description: 
// Author: NybbleLynx
// Created: 3rd April 2025
// ---------------------------------------------------------------------
// Project licence Information:
// 
// ---------------------------------------------------------------------
// Additional Info:
// ---------------------------------------------------------------------
#endregion

namespace SatisfactoryTools.FactoryPlanner.Data.Factory
{
    public interface ISatisfactoryPlannerDatabaseContextFactory
    {
        ISatisfactoryPlannerDatabaseContextFactory CreateDatabaseContext();
    }
}