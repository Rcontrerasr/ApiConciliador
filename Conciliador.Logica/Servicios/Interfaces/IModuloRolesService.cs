using Conciliador.Datos.Infraestructura.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conciliador.Logica.Servicios.Interfaces
{
    public interface IModuloRolesService
    {
        Task<Boolean>Add(TodoEntity entity);
        Task<Boolean>Update(TodoEntity entity);
        Task<Boolean>Delete(Guid id);
        Task<List<TodoEntity>>GetAll();
        Task<TodoEntity>GetById(Guid id);
        Task<List<TodoEntity>>GetByStatus(Boolean status);
    }
}
