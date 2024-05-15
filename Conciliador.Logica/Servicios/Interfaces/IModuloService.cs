using Conciliador.Datos.Infraestructura.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conciliador.Logica.Servicios.Interfaces
{
    public interface IModuloService
    {
        Task<Boolean>Add(ModuloEntity entity);
        Task<Boolean>Update(ModuloEntity entity);
        Task<Boolean>Delete(Int32 id);
        Task<List<ModuloEntity>>GetAll();
        Task<ModuloEntity>GetById(Int32 id);
        Task<List<ModuloEntity>>GetByStatus(Boolean status);
    }
}
