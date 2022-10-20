namespace GenericApi.Interfaces;

public interface IRepository<TInstance>
{
    TInstance add(TInstance instance);

    TInstance getById(int id);
}