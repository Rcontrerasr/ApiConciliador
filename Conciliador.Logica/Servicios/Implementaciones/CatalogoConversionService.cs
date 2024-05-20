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
    public class CatalogoConversionService : ICatalogoConversionService
    {
        private readonly ICatalogoConversionRepository _CatalogoConversionRepository;

        public CatalogoConversionService(ICatalogoConversionRepository CatalogoConversionRepository)
        {
            this._CatalogoConversionRepository = CatalogoConversionRepository;
        }
        public async Task<bool> Add(CatalogoConversionEntity entity)
        {
            _CatalogoConversionRepository.Insert(entity);
            return true;
        }

        public async Task<bool> Delete(Int32 id)
        {
            _CatalogoConversionRepository.Delete(id);
            return true;
        }

      

        public async Task<List<CatalogoConversionEntity>> GetAll()
        {
            return _CatalogoConversionRepository.GetAll().ToList();

        }

        public async Task<CatalogoConversionEntity> GetById(Int32 id)
        {
            return _CatalogoConversionRepository.GetById(id);
        }

       

        public async Task<List<CatalogoConversionEntity>> GetByStatus(bool status)
        {
            var CatalogoConversionList = _CatalogoConversionRepository.GetAll().ToList();
            return CatalogoConversionList;
        }

        public async Task<bool> Update(CatalogoConversionEntity entity)
        {
            _CatalogoConversionRepository.Update(entity);
            return true;
        }
    }
}
