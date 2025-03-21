using System.Linq;
using SatisfactoryTools.FactoryPlanner.Data.Models;

namespace SatisfactoryTools.FactoryPlanner.Repositories
{
    public class NodePurityRepository : IEnumValueRepository<NodePurity>
    {
        private readonly FactoryPlannerDatabaseContext dbContext;

        public NodePurityRepository(FactoryPlannerDatabaseContext dbContext)
        {
            this.dbContext = dbContext;
        }

        /// <inheritdoc />
        public NodePurity GetByName(string name)
        {
            return dbContext.NodePurities.Single(np => np.Name == name);
        }
    }
}