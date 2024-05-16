using Conciliador.Datos.Infraestructura.Entidades;

namespace Conciliador.Logica.Servicios.Interfaces
{
    public interface ICatalogoGeneralService
    {
        Task<Boolean>Add(CatalogoGeneralEntity entity);
        Task<Boolean>Update(CatalogoGeneralEntity entity);
        Task<Boolean>Delete(Int32 id);
        Task<List<CatalogoGeneralEntity>>GetAll();
        Task<CatalogoGeneralEntity>GetById(Int32 id);
        Task<List<CatalogoGeneralEntity>>GetByStatus(Boolean status);
    }
}
