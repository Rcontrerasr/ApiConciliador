using Conciliador.Datos.Infraestructura.Entidades;

namespace Conciliador.Logica.Servicios.Interfaces
{
    public interface ICatalogoConversionService
    {
        Task<Boolean>Add(CatalogoConversionEntity entity);
        Task<Boolean>Update(CatalogoConversionEntity entity);
        Task<Boolean>Delete(Int32 id);
        Task<List<CatalogoConversionEntity>>GetAll();
        Task<CatalogoConversionEntity>GetById(Int32 id);
        Task<List<CatalogoConversionEntity>>GetByStatus(Boolean status);
    }
}
