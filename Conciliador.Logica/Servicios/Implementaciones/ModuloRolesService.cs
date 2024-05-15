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
    public class ModuloRolesService : IModuloRolesService
    {
        private readonly IModuloRolesRepository _ModuloRolesRepository;

        public ModuloRolesService(IModuloRolesRepository ModuloRolesRepository)
        {
            this._ModuloRolesRepository = ModuloRolesRepository;
        }
        public async Task<bool> Add(ModuloRolesEntity entity)
        {
            _ModuloRolesRepository.Insert(entity);
            return true;
        }

        public async Task<bool> Delete(Int32 id)
        {
            _ModuloRolesRepository.Delete(id);
            return true;
        }



        public async Task<List<ModuloRolesEntity>> GetAll()
        {
            return _ModuloRolesRepository.GetAll().ToList();

        }

        public async Task<ModuloRolesEntity> GetById(Int32 id)
        {
            return _ModuloRolesRepository.GetById(id);
        }



        public async Task<List<ModuloRolesEntity>> GetByStatus(bool status)
        {
            var ModuloRolesList = _ModuloRolesRepository.FindBy(t => t.Id == 0 ).ToList();
            return ModuloRolesList;
        }

        public async Task<bool> Update(ModuloRolesEntity entity)
        {
            _ModuloRolesRepository.Update(entity);
            return true;
        }
    }
}
