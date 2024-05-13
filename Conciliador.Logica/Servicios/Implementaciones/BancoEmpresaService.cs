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
    public class BancoEmpresaService : IBancoEmpresaService
    {
        private readonly IBancoEmpresaRepository _BancoEmpresaRepository;

        public BancoEmpresaService(IBancoEmpresaRepository BancoEmpresaRepository)
        {
            this._BancoEmpresaRepository = BancoEmpresaRepository;
        }
        public async Task<bool> Add(BancoEmpresaEntity entity)
        {
            _BancoEmpresaRepository.Insert(entity);
            return true;
        }

        public async Task<bool> Delete(Guid id)
        {
            _BancoEmpresaRepository.Delete(id);
            return true;
        }

        public async Task<List<BancoEmpresaEntity>> GetAll()
        {
            return _BancoEmpresaRepository.GetAll().ToList();

        }

        public async Task<BancoEmpresaEntity> GetById(Guid id)
        {
            return _BancoEmpresaRepository.GetById(id);
        }

        public async Task<List<BancoEmpresaEntity>> GetByStatus(bool status)
        {
           var BancoEmpresaList=_BancoEmpresaRepository.FindBy(t=>t.Status == status).ToList();
            return BancoEmpresaList;
        }

        public async Task<bool> Update(BancoEmpresaEntity entity)
        {
            _BancoEmpresaRepository.Update(entity);
            return true;
        }
    }
}
