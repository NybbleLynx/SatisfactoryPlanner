#region File Header
// ---------------------------------------------------------------------
// Filename: IEnumValueRepository.cs
// Description: Provides behaviour for enum value repositories used to grab enum data from the database.
// Author: NybbleLynx
// Created: 3rd April 2025
// ---------------------------------------------------------------------
// Project licence Information:
// 
// ---------------------------------------------------------------------
// Additional Info:
// ---------------------------------------------------------------------
#endregion

namespace SatisfactoryTools.FactoryPlanner.Repositories.Enumeration
{
    public interface IEnumValueRepository<out TEntity>
    {
        TEntity GetByName(string name);
    }
}