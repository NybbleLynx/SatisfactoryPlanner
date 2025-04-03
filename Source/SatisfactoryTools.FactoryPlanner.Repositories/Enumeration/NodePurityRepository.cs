#region File Header
// ---------------------------------------------------------------------
// Filename: NodePurityRepository.cs
// Description: Add description here
// Author: NybbleLynx
// Created: 3rd April 2025
// ---------------------------------------------------------------------
// Project licence Information:
// 
// ---------------------------------------------------------------------
// Additional Info:
// ---------------------------------------------------------------------
#endregion

using System.Linq;
using SatisfactoryTools.FactoryPlanner.Data.Models;

namespace SatisfactoryTools.FactoryPlanner.Repositories.Enumeration
{
    public class NodePurityRepository : IEnumValueRepository<NodePurity>
    {
        private readonly SatisfactoryPlannerDatabaseContext dbContext;

        public NodePurityRepository(SatisfactoryPlannerDatabaseContext dbContext)
        {
            this.dbContext = dbContext;
        }

        /// <inheritdoc />
        public NodePurity GetByName(string name) => dbContext.NodePurities.Single(np => np.Name == name);
    }
}