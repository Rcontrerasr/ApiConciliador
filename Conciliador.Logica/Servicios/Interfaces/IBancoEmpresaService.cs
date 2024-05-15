using Conciliador.Datos.Infraestructura.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conciliador.Logica.Servicios.Interfaces
{
    public interface IBancoEmpresaService
    {
        Task<Boolean>Add(BancoEmpresaEntity entity);
        Task<Boolean>Update(BancoEmpresaEntity entity);
        Task<Boolean>Delete(Int32 id);
        Task<List<BancoEmpresaEntity>>GetAll();
        Task<BancoEmpresaEntity>GetById(Int32 id);
        Task<List<BancoEmpresaEntity>>GetByStatus(Boolean status);
    }
}
