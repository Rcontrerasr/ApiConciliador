using Conciliador.Datos.Infraestructura.Entidades;
using Conciliador.Modelos.DTOs;

namespace Conciliador.Logica.Servicios.Interfaces
{
    public interface IRolesService
    {
        Task<Boolean> Add(RolesDto entity);
        Task<Boolean> Update(RolesDto entity);
        Task<Boolean> Delete(Int32 id);
        Task<List<RolesDto>> GetAll();
        Task<RolesDto> GetById(Int32 id);
    }
}
