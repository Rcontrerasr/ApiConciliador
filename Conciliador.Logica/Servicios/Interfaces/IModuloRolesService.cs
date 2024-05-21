using Conciliador.Modelos.DTOs;

namespace Conciliador.Logica.Servicios.Interfaces
{
    public interface IModuloRolesService
    {
        Task<Boolean>Add(ModuloRolesDto entity);
        Task<Boolean>Update(ModuloRolesDto entity);
        Task<Boolean>Delete(Int32 id);
        Task<List<ModuloRolesDto>>GetAll();
        Task<ModuloRolesDto>GetById(Int32 id);
        Task<List<ModuloRolesDto>>GetByStatus(Boolean status);
    }
}
