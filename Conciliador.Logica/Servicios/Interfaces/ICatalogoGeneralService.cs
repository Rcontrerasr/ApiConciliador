using Conciliador.Datos.Infraestructura.Entidades;
using Conciliador.Modelos.DTOs;

namespace Conciliador.Logica.Servicios.Interfaces
{
    public interface ICatalogoGeneralService
    {
        Task<Boolean>Add(CatalogoGeneralDto entity);
        Task<Boolean>Update(CatalogoGeneralDto entity);
        Task<Boolean>Delete(Int32 id);
        Task<List<CatalogoGeneralDto>>GetAll();
        Task<CatalogoGeneralDto>GetById(Int32 id);
        Task<List<CatalogoGeneralDto>>GetByStatus(Boolean status);
    }
}
