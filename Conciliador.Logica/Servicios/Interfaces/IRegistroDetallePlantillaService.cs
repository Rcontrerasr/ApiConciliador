using Conciliador.Datos.Infraestructura.Entidades;
using Conciliador.Modelos.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conciliador.Logica.Servicios.Interfaces
{
    public interface IRegistroDetallePlantillaService
    {
        Task<Boolean>Add(RegistroDetallePlantillaDto entity);
        Task<Boolean>Update(RegistroDetallePlantillaDto entity);
        Task<Boolean>Delete(Int32 id);
        Task<List<RegistroDetallePlantillaDto>>GetAll();
        Task<RegistroDetallePlantillaDto>GetById(Int32 id);
        Task<List<RegistroDetallePlantillaDto>>GetByStatus(Boolean status);
    }
}
