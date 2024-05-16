using Conciliador.Datos.Infraestructura.Entidades;

namespace Conciliador.Logica.Servicios.Interfaces
{
    public interface ICatalogoNombreService
    {
        Task<Boolean>Add(CatalogoNombreEntity entity);
        Task<Boolean>Update(CatalogoNombreEntity entity);
        Task<Boolean>Delete(Int32 id);
        Task<List<CatalogoNombreEntity>>GetAll();
        Task<CatalogoNombreEntity>GetById(Int32 id);
        Task<List<CatalogoNombreEntity>>GetByStatus(Boolean status);
    }
}
