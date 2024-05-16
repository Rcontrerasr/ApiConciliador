using Conciliador.Datos.Infraestructura.Entidades;

namespace Conciliador.Logica.Servicios.Interfaces
{
    public interface IRolesService
    {
        Task<Boolean> Add(RolesEntity entity);
        Task<Boolean> Update(RolesEntity entity);
        Task<Boolean> Delete(Int32 id);
        Task<List<RolesEntity>> GetAll();
        Task<RolesEntity> GetById(Int32 id);
        Task<List<RolesEntity>> GetByStatus(Boolean status);
    }
}
