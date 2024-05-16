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
    public class CatalogoGeneralService : ICatalogoGeneralService
    {
        private readonly ICatalogoGeneralRepository _CatalogoGeneralRepository;

        public CatalogoGeneralService(ICatalogoGeneralRepository CatalogoGeneralRepository)
        {
            this._CatalogoGeneralRepository = CatalogoGeneralRepository;
        }
        public async Task<bool> Add(CatalogoGeneralEntity entity)
        {
            _CatalogoGeneralRepository.Insert(entity);
            return true;
        }

        public async Task<bool> Delete(Int32 id)
        {
            _CatalogoGeneralRepository.Delete(id);
            return true;
        }

      

        public async Task<List<CatalogoGeneralEntity>> GetAll()
        {
            return _CatalogoGeneralRepository.GetAll().ToList();

        }

        public async Task<CatalogoGeneralEntity> GetById(Int32 id)
        {
            return _CatalogoGeneralRepository.GetById(id);
        }

       

        public async Task<List<CatalogoGeneralEntity>> GetByStatus(bool status)
        {
            var CatalogoGeneralList = _CatalogoGeneralRepository.FindBy(t => t.Orden == 0).ToList();
            return CatalogoGeneralList;
        }

        public async Task<bool> Update(CatalogoGeneralEntity entity)
        {
            _CatalogoGeneralRepository.Update(entity);
            return true;
        }
    }
}
