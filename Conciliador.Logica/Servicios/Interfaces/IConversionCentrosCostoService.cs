using Conciliador.Datos.Infraestructura.Entidades;
using Conciliador.Datos.Infraestructura.Entidades;
using Conciliador.Modelos.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conciliador.Logica.Servicios.Interfaces
{
    public interface IConversionCentrosCostoService
    {
        Task<Boolean>Add(ConversionCentrosCostoDto entity);
        Task<Boolean>Update(ConversionCentrosCostoDto entity);
        Task<Boolean>Delete(Int32 id);
        Task<List<ConversionCentrosCostoDto>>GetAll();
        Task<ConversionCentrosCostoDto>GetById(Int32 id);
        Task<List<ConversionCentrosCostoDto>>GetByStatus(Boolean status);
    }
}
