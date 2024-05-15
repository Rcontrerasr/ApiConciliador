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
        Task<Boolean>Add(ModuloRolesEntity entity);
        Task<Boolean>Update(ModuloRolesEntity entity);
        Task<Boolean>Delete(Int32 id);
        Task<List<ModuloRolesEntity>>GetAll();
        Task<ModuloRolesEntity>GetById(Int32 id);
        Task<List<ModuloRolesEntity>>GetByStatus(Boolean status);
    }
}
