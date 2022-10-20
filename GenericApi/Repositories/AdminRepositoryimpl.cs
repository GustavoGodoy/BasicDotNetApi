using GenericApi.Interfaces;
using GenericApi.Models;

namespace GenericApi.Repositories;

public class AdminRepositoryimpl: RepositoryImpl<Admin>, IAdminRepository
{
    public override Admin getById(int id)
    {
        return new Admin( id, "Administrador Generico com id informado");
    }
}