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
            _ModuloRolesRepository = ModuloRolesRepository;
        }

        public async Task<bool> Add(ModuloRolesEntity entity)
        {
            _ModuloRolesRepository.Insert(entity);
            return true;
        }

        public Task<bool> Add(TodoEntity entity)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> Delete(Guid id)
        {
            _ModuloRolesRepository.Delete(id);
            return true;
        }

        public async Task<List<ModuloRolesEntity>> GetAll()
        {
            return _ModuloRolesRepository.GetAll().ToList();
        }

        public async Task<ModuloRolesEntity> GetById(Guid id)
        {
            return _ModuloRolesRepository.GetById(id);
        }

        public async Task<List<ModuloRolesEntity>> GetByStatus(string status)
        {
            var ModuloRoless = _ModuloRolesRepository.FindBy(e => e.Estado == status).ToList();
            return ModuloRoless;
        }

        public Task<List<TodoEntity>> GetByStatus(bool status)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> Update(ModuloRolesEntity entity)
        {
            _ModuloRolesRepository.Update(entity);
            return true;
        }

        public Task<bool> Update(TodoEntity entity)
        {
            throw new NotImplementedException();
        }

        Task<List<TodoEntity>> IModuloRolesService.GetAll()
        {
            throw new NotImplementedException();
        }

        Task<TodoEntity> IModuloRolesService.GetById(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}
