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
    public class BancosService : IBancosService
    {
        private readonly IBancosRepository _BancosRepository;

        public BancosService(IBancosRepository BancosRepository)
        {
            this._BancosRepository = BancosRepository;
        }
        public async Task<bool> Add(BancosEntity entity)
        {
            _BancosRepository.Insert(entity);
            return true;
        }

        public async Task<bool> Delete(Guid id)
        {
            _BancosRepository.Delete(id);
            return true;
        }

        public async Task<List<BancosEntity>> GetAll()
        {
            return _BancosRepository.GetAll().ToList();
        }

        public async Task<BancosEntity> GetById(Guid id)
        {
            return _BancosRepository.GetById(id);
        }

        public async Task<List<BancosEntity>> GetByStatus(bool isActive)
        {
            var BancosList = _BancosRepository.FindBy(t => t.Estado == (isActive ? "ACTIVO" : "INACTIVO")).ToList();
            return BancosList;
        }


        public async Task<bool> Update(BancosEntity entity)
        {
            _BancosRepository.Update(entity);
            return true;
        }
    }
}
