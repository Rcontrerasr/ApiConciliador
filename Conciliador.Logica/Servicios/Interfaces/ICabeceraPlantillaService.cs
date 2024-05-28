using Conciliador.Datos.Infraestructura.Entidades;
using Conciliador.Modelos.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conciliador.Logica.Servicios.Interfaces
{
    public interface ICabeceraPlantillaService
    {
        Task<Boolean>Add(CabeceraPlantillaDto entity);
        Task<Boolean>Update(CabeceraPlantillaDto entity);
        Task<Boolean>Delete(Int32 id);
        Task<List<CabeceraPlantillaDto>>GetAll();
        Task<CabeceraPlantillaDto>GetById(Int32 id);
        Task<List<CabeceraPlantillaDto>>GetByStatus(Boolean status);
    }
}
