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
        private readonly IModuloRepository _ModuloRepository;

        public ModuloService(IModuloRepository ModuloRepository)
        {
            _ModuloRepository = ModuloRepository;
        }

        public async Task<bool> Add(ModuloEntity entity)
        {
            _ModuloRepository.Insert(entity);
            return true;
        }

        public Task<bool> Add(TodoEntity entity)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> Delete(Guid id)
        {
            _ModuloRepository.Delete(id);
            return true;
        }

        public async Task<List<ModuloEntity>> GetAll()
        {
            return _ModuloRepository.GetAll().ToList();
        }

        public async Task<ModuloEntity> GetById(Guid id)
        {
            return _ModuloRepository.GetById(id);
        }

        public async Task<List<ModuloEntity>> GetByStatus(string status)
        {
            var Modulos = _ModuloRepository.FindBy(e => e.Estado == status).ToList();
            return Modulos;
        }

        public Task<List<TodoEntity>> GetByStatus(bool status)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> Update(ModuloEntity entity)
        {
            _ModuloRepository.Update(entity);
            return true;
        }

        public Task<bool> Update(TodoEntity entity)
        {
            throw new NotImplementedException();
        }

        Task<List<TodoEntity>> IModuloService.GetAll()
        {
            throw new NotImplementedException();
        }

        Task<TodoEntity> IModuloService.GetById(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}
