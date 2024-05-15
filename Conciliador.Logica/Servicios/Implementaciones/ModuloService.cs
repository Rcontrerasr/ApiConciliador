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
            this._ModuloRepository = ModuloRepository;
        }
        public async Task<bool> Add(ModuloEntity entity)
        {
            _ModuloRepository.Insert(entity);
            return true;
        }

        public async Task<bool> Delete(Int32 id)
        {
            _ModuloRepository.Delete(id);
            return true;
        }



        public async Task<List<ModuloEntity>> GetAll()
        {
            return _ModuloRepository.GetAll().ToList();

        }

        public async Task<ModuloEntity> GetById(Int32 id)
        {
            return _ModuloRepository.GetById(id);
        }



        public async Task<List<ModuloEntity>> GetByStatus(bool status)
        {
            var ModuloList = _ModuloRepository.FindBy(t => t.Estado == "").ToList();
            return ModuloList;
        }

        public async Task<bool> Update(ModuloEntity entity)
        {
            _ModuloRepository.Update(entity);
            return true;
        }
    }
}
