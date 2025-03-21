namespace SatisfactoryTools.FactoryPlanner.Repositories
{
    public interface IEnumValueRepository<TData> where TData : class
    {
        TData GetByName(string name);
    }
}