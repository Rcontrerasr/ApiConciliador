using Conciliador.Datos.Infraestructura.Entidades;
using Conciliador.Modelos.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conciliador.Logica.Servicios.Interfaces
{
    public interface IRegistroCabeceraPlantillaService
    {
        Task<Boolean>Add(RegistroCabeceraPlantillaDto entity);
        Task<Boolean>Update(RegistroCabeceraPlantillaDto entity);
        Task<Boolean>Delete(Int32 id);
        Task<List<RegistroCabeceraPlantillaDto>>GetAll();
        Task<RegistroCabeceraPlantillaDto>GetById(Int32 id);
        Task<List<RegistroCabeceraPlantillaDto>>GetByStatus(Boolean status);
    }
}
