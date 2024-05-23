using Conciliador.Modelos.DTOs;


namespace Conciliador.Logica.Servicios.Interfaces
{
    public interface IMenuService
    {
        Task<Boolean>Add(MenuDto entity);
        Task<Boolean>Update(MenuDto entity);
        Task<Boolean>Delete(Int32 id);
        Task<List<MenuDto>>GetAll();
        Task<MenuDto>GetById(Int32 id);
        Task<List<MenuDto>>GetByStatus(Boolean status);
    }
}
