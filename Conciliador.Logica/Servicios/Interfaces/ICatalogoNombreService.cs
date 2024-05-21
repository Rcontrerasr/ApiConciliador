using Conciliador.Datos.Infraestructura.Entidades;
using Conciliador.Modelos.DTOs;

namespace Conciliador.Logica.Servicios.Interfaces
{
    public interface ICatalogoNombreService
    {
        Task<Boolean>Add(CatalogoNombreDto entity);
        Task<Boolean>Update(CatalogoNombreDto entity);
        Task<Boolean>Delete(Int32 id);
        Task<List<CatalogoNombreDto>>GetAll();
        Task<CatalogoNombreDto>GetById(Int32 id);
        Task<List<CatalogoNombreDto>>GetByStatus(Boolean status);
    }
}
