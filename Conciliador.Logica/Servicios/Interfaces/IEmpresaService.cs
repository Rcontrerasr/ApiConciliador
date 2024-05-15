using Conciliador.Datos.Infraestructura.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conciliador.Logica.Servicios.Interfaces
{
    public interface IEmpresaService
    {
        Task<Boolean>Add(EmpresaEntity entity);
        Task<Boolean>Update(EmpresaEntity entity);
        Task<Boolean>Delete(Int32 id);
        Task<List<EmpresaEntity>>GetAll();
        Task<EmpresaEntity>GetById(Int32 id);
        Task<List<EmpresaEntity>>GetByStatus(Boolean status);
    }
}
