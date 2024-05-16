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
    public class RolesService : IRolesService
    {
        private readonly IRolesRepository _RolesRepository;

        public RolesService(IRolesRepository RolesRepository)
        {
            this._RolesRepository = RolesRepository;
        }
        public async Task<bool> Add(RolesEntity entity)
        {
            _RolesRepository.Insert(entity);
            return true;
        }

        public async Task<bool> Delete(Int32 id)
        {
            _RolesRepository.Delete(id);
            return true;
        }

        public async Task<List<RolesEntity>> GetAll()
        {
            return _RolesRepository.GetAll().ToList();

        }

        public async Task<RolesEntity> GetById(Int32 id)
        {
            return _RolesRepository.GetById(id);
        }

        public async Task<List<RolesEntity>> GetByStatus(bool status)
        {
            var RolesList = _RolesRepository.FindBy(t => t.Estado == status).ToList();
            return RolesList;
        }

        public async Task<bool> Update(RolesEntity entity)
        {
            _RolesRepository.Update(entity);
            return true;
        }
    }
}
