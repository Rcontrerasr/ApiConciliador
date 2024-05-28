using Conciliador.Datos.Infraestructura.Entidades;
using Conciliador.Modelos.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conciliador.Logica.Servicios.Interfaces
{
    public interface IPlantillasService
    {
        Task<Boolean>Add(PlantillaDto entity);
        Task<Boolean>Update(PlantillaDto entity);
        Task<Boolean>Delete(Int32 id);
        Task<List<PlantillaDto>>GetAll();
        Task<PlantillaDto> GetById(Int32 id);
        Task<List<PlantillaDto>>GetByStatus(Boolean status);
    }
}
