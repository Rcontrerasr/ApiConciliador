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
    public class CatalogoNombreService : ICatalogoNombreService
    {
        private readonly ICatalogoNombreRepository _CatalogoNombreRepository;

        public CatalogoNombreService(ICatalogoNombreRepository CatalogoNombreRepository)
        {
            this._CatalogoNombreRepository = CatalogoNombreRepository;
        }
        public async Task<bool> Add(CatalogoNombreEntity entity)
        {
            _CatalogoNombreRepository.Insert(entity);
            return true;
        }

        public async Task<bool> Delete(Int32 id)
        {
            _CatalogoNombreRepository.Delete(id);
            return true;
        }

      

        public async Task<List<CatalogoNombreEntity>> GetAll()
        {
            return _CatalogoNombreRepository.GetAll().ToList();

        }

        public async Task<CatalogoNombreEntity> GetById(Int32 id)
        {
            return _CatalogoNombreRepository.GetById(id);
        }

       

        public async Task<List<CatalogoNombreEntity>> GetByStatus(bool status)
        {
            var CatalogoNombreList = _CatalogoNombreRepository.FindBy(t => t.Codigo == "").ToList();
            return CatalogoNombreList;
        }

        public async Task<bool> Update(CatalogoNombreEntity entity)
        {
            _CatalogoNombreRepository.Update(entity);
            return true;
        }
    }
}
