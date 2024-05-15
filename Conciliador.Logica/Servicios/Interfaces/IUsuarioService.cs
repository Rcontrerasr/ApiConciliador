using Conciliador.Datos.Infraestructura.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conciliador.Logica.Servicios.Interfaces
{
    public interface IUsuarioService
    {
        Task<Boolean>Add(UsuarioEntity entity);
        Task<Boolean>Update(UsuarioEntity entity);
        Task<Boolean>Delete(Int32 id);
        Task<List<UsuarioEntity>>GetAll();
        Task<UsuarioEntity>GetById(Int32 id);
        Task<List<UsuarioEntity>>GetByStatus(Boolean status);
    }
}
