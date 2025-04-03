#region File Header
// ---------------------------------------------------------------------
// Filename: ISatisfactoryPlannerPersistence.cs
// Description: Defines behaviour for persistence data from satisfactory planner database.
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

namespace SatisfactoryTools.FactoryPlanner.Repositories
{
    public interface ISatisfactoryPlannerPersistence : IDisposable
    {
        void SaveChanges();
    }
}