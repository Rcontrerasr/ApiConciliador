using Conciliador.Datos.Infraestructura.Entidades;
using Conciliador.Modelos.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conciliador.Logica.Servicios.Interfaces
{
    public interface IModuloService
    {
        Task<Boolean>Add(ModuloDto entity);
        Task<Boolean>Update(ModuloDto entity);
        Task<Boolean>Delete(Int32 id);
        Task<List<ModuloDto>>GetAll();
        Task<ModuloDto>GetById(Int32 id);
        Task<List<ModuloDto>>GetByStatus(Boolean status);
    }
}
