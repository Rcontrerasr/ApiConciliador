using Conciliador.Datos.Infraestructura.Entidades;
using Conciliador.Modelos.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conciliador.Logica.Servicios.Interfaces
{
    public interface ITipoCatalogoService
    {
        Task<Boolean>Add(TipoCatalogoDto entity);
        Task<Boolean>Update(TipoCatalogoDto entity);
        Task<Boolean>Delete(Int32 id);
        Task<List<TipoCatalogoDto>>GetAll();
        Task<TipoCatalogoDto>GetById(Int32 id);
        Task<List<TipoCatalogoDto>>GetByStatus(Boolean status);
    }
}
