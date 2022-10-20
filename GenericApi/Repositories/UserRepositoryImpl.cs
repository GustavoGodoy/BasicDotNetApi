using GenericApi.Interfaces;
using GenericApi.Models;

namespace GenericApi.Repositories;

public class UserRepositoryImpl: RepositoryImpl<User>, IUserRepository
{
    public override User getById(int id)
    {
        return new User(id,"Usuario generico com ID informado");
    }
}