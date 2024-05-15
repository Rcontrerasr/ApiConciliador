using Conciliador.Datos.Infraestructura.Entidades;
using Conciliador.Datos.Infraestructura.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conciliador.Logica.Servicios.Interfaces
{
    public interface IConversionCentrosCostoService
    {
        Task<Boolean>Add(ConversionCentrosCostoEntity entity);
        Task<Boolean>Update(ConversionCentrosCostoEntity entity);
        Task<Boolean>Delete(Int32 id);
        Task<List<ConversionCentrosCostoEntity>>GetAll();
        Task<ConversionCentrosCostoEntity>GetById(Int32 id);
        Task<List<ConversionCentrosCostoEntity>>GetByStatus(Boolean status);
    }
}
