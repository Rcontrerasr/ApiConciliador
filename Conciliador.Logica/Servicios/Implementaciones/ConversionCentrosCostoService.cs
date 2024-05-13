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
    public class ConversionCentrosCostoService : IConversionCentrosCostoService
    {
        private readonly IConversionCentrosCostoRepository _ConversionCentrosCostoRepository;

        public ConversionCentrosCostoService(IConversionCentrosCostoRepository ConversionCentrosCostoRepository)
        {
            this._ConversionCentrosCostoRepository = ConversionCentrosCostoRepository;
        }
        public async Task<bool> Add(ConversionCentrosCostoEntity entity)
        {
            _ConversionCentrosCostoRepository.Insert(entity);
            return true;
        }

        public async Task<bool> Delete(Guid id)
        {
            _ConversionCentrosCostoRepository.Delete(id);
            return true;
        }

        public async Task<List<ConversionCentrosCostoEntity>> GetAll()
        {
            return _ConversionCentrosCostoRepository.GetAll().ToList();

        }

        public async Task<ConversionCentrosCostoEntity> GetById(Guid id)
        {
            return _ConversionCentrosCostoRepository.GetById(id);
        }

        public async Task<List<ConversionCentrosCostoEntity>> GetByStatus(bool status)
        {
           var ConversionCentrosCostoList=_ConversionCentrosCostoRepository.FindBy(t=>t.Status == status).ToList();
            return ConversionCentrosCostoList;
        }

        public async Task<bool> Update(ConversionCentrosCostoEntity entity)
        {
            _ConversionCentrosCostoRepository.Update(entity);
            return true;
        }
    }
}
