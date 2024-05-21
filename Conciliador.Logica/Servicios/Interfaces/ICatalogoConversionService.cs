using Conciliador.Modelos.DTOs;

namespace Conciliador.Logica.Servicios.Interfaces
{
    public interface ICatalogoConversionService
    {
        Task<Boolean>Add(CatalogoConversionDto entity);
        Task<Boolean>Update(CatalogoConversionDto entity);
        Task<Boolean>Delete(Int32 id);
        Task<List<CatalogoConversionDto>>GetAll();
        Task<CatalogoConversionDto>GetById(Int32 id);
        Task<List<CatalogoConversionDto>>GetByStatus(Boolean status);
    }
}
