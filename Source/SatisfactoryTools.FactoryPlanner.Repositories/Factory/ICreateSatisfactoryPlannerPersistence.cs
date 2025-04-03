#region File Header
// ---------------------------------------------------------------------
// Filename: ICreateSatisfactoryPlannerPersistence.cs
// Description: Defines behaviour for creating Satisfactory planner persistence.
// Author: NybbleLynx
// Created: 3rd April 2025
// ---------------------------------------------------------------------
// Project licence Information:
// 
// ---------------------------------------------------------------------
// Additional Info:
// ---------------------------------------------------------------------
#endregion

namespace SatisfactoryTools.FactoryPlanner.Repositories.Factory
{
    public interface ICreateSatisfactoryPlannerPersistence
    {
        ISatisfactoryPlannerPersistence CreatePersistence();
    }
}