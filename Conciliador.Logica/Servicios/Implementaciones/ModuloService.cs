using Conciliador.Datos.Infraestructura.Entidades;
using Conciliador.Datos.Infraestructura.IRespositorios;
using Conciliador.Logica.Servicios.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conciliador.Logica.Servicios.Implementaciones
{
    public class ModuloService : IModuloService
    {
        public Task<bool> Add(ModuloEntity entity)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<ModuloEntity>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<ModuloEntity> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<ModuloEntity>> GetByStatus(bool status)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Update(ModuloEntity entity)
        {
            throw new NotImplementedException();
        }
    }
}
