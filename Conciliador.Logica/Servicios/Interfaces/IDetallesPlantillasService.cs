using Conciliador.Datos.Infraestructura.Entidades;
using Conciliador.Modelos.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conciliador.Logica.Servicios.Interfaces
{
    public interface IDetallesPlantillasService
    {
        Task<Boolean>Add(DetallesPlantillaDto entity);
        Task<Boolean>Update(DetallesPlantillaDto entity);
        Task<Boolean>Delete(Int32 id);
        Task<List<DetallesPlantillaDto>>GetAll();
        Task<DetallesPlantillaDto> GetById(Int32 id);
        Task<List<DetallesPlantillaDto>>GetByStatus(Boolean status);
    }
}
