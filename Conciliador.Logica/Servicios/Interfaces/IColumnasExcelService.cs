using Conciliador.Datos.Infraestructura.Entidades;
using Conciliador.Modelos.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conciliador.Logica.Servicios.Interfaces
{
    public interface IColumnasExcelService
    {
        Task<Boolean>Add(ColumnasExceloDto entity);
        Task<Boolean>Update(ColumnasExceloDto entity);
        Task<Boolean>Delete(Int32 id);
        Task<List<ColumnasExceloDto>>GetAll();
        Task<ColumnasExceloDto> GetById(Int32 id);
        Task<List<ColumnasExceloDto>>GetByStatus(Boolean status);
    }
}
