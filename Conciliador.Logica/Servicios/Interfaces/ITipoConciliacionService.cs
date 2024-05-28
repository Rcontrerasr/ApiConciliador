using Conciliador.Datos.Infraestructura.Entidades;
using Conciliador.Modelos.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conciliador.Logica.Servicios.Interfaces
{
    public interface ITipoConciliacionService
    {
        Task<Boolean>Add(TipoConciliacionDto entity);
        Task<Boolean>Update(TipoConciliacionDto entity);
        Task<Boolean>Delete(Int32 id);
        Task<List<TipoConciliacionDto>>GetAll();
        Task<TipoConciliacionDto>GetById(Int32 id);
        Task<List<TipoConciliacionDto>>GetByStatus(Boolean status);
    }
}
