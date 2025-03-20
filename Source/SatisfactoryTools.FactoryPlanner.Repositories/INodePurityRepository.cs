using SatisfactoryTools.FactoryPlanner.Data.Models;

namespace SatisfactoryTools.FactoryPlanner.Repositories
{
    public interface INodePurityRepository
    {
        NodePurity GetByName(string name);
    }
}