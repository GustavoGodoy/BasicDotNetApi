using GenericApi.Interfaces;

namespace GenericApi.Repositories;

public abstract class RepositoryImpl<TInstance>: IRepository<TInstance> where TInstance: class, new()
{
    public TInstance add(TInstance instance)
    {
        return instance;
    }

    public virtual TInstance getById(int id)
    {
        return new TInstance();
    }
}