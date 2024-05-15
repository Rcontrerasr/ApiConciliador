using Conciliador.Datos.Infraestructura.Entidades;

namespace Conciliador.Logica.Servicios.Interfaces
{
    public interface ITodoService
    {
        Task<Boolean>Add(TodoEntity entity);
        Task<Boolean>Update(TodoEntity entity);
        Task<Boolean>Delete(Int32 id);
        Task<List<TodoEntity>>GetAll();
        Task<TodoEntity>GetById(Int32 id);
        Task<List<TodoEntity>>GetByStatus(Boolean status);
    }
}
