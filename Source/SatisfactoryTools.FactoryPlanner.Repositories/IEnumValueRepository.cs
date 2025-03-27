namespace SatisfactoryTools.FactoryPlanner.Repositories
{
    public interface IEnumValueRepository<out TData> where TData : class
    {
        TData GetByName(string name);
    }
}