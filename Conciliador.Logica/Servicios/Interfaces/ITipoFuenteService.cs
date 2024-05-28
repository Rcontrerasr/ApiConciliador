using Conciliador.Datos.Infraestructura.Entidades;
using Conciliador.Modelos.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conciliador.Logica.Servicios.Interfaces
{
    public interface ITipoFuenteService
    {
        Task<Boolean>Add(TipoFuenteDto entity);
        Task<Boolean>Update(TipoFuenteDto entity);
        Task<Boolean>Delete(Int32 id);
        Task<List<TipoFuenteDto>>GetAll();
        Task<TipoFuenteDto>GetById(Int32 id);
        Task<List<TipoFuenteDto>>GetByStatus(Boolean status);
    }
}
