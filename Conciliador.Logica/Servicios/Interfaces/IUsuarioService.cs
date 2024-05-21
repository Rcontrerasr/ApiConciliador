using Conciliador.Datos.Infraestructura.Entidades;
using Conciliador.Modelos.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conciliador.Logica.Servicios.Interfaces
{
    public interface IUsuarioService
    {
        Task<Boolean>Add(UsuarioDto entity);
        Task<Boolean>Update(UsuarioDto entity);
        Task<Boolean>Delete(Int32 id);
        Task<List<UsuarioDto>>GetAll();
        Task<UsuarioDto>GetById(Int32 id);
        Task<List<UsuarioDto>>GetByStatus(Boolean status);
    }
}
