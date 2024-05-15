using Conciliador.Datos.Infraestructura.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conciliador.Logica.Servicios.Interfaces
{
    public interface IBancosService
    {
        Task<Boolean>Add(BancosEntity entity);
        Task<Boolean>Update(BancosEntity entity);
        Task<Boolean>Delete(Int32 id);
        Task<List<BancosEntity>>GetAll();
        Task<BancosEntity>GetById(Int32 id);
        Task<List<BancosEntity>>GetByStatus(Boolean status);
    }
}
