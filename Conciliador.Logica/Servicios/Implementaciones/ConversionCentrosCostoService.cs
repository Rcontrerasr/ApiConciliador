using AutoMapper;
using Conciliador.Datos.Infraestructura.Entidades;
using Conciliador.Datos.Infraestructura.IRespositorios;
using Conciliador.Logica.Servicios.Interfaces;
using Conciliador.Modelos.DTOs;
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
        private readonly IMapper _mapper;

        public ConversionCentrosCostoService(IConversionCentrosCostoRepository ConversionCentrosCostoRepository, IMapper mapper)
        {
            this._ConversionCentrosCostoRepository = ConversionCentrosCostoRepository;
            _mapper = mapper;
        }
        public async Task<bool> Add(ConversionCentrosCostoDto entityDto)
        {
            if (entityDto == null) throw new Exception("La entidad ConversionCentrosCosto es requerida");
            var entity = _mapper.Map<ConversionCentrosCostoEntity>(entityDto);
            return _ConversionCentrosCostoRepository.Insert(entity);
        }

        public async Task<bool> Delete(Int32 id)
        {
            return _ConversionCentrosCostoRepository.Delete(id);
        }

        public async Task<List<ConversionCentrosCostoDto>> GetAll()
        {
            var entities = _ConversionCentrosCostoRepository.GetAll().ToList();
            var responseDTOs = _mapper.Map<List<ConversionCentrosCostoDto>>(entities);
            return responseDTOs;

        }

        public async Task<ConversionCentrosCostoDto> GetById(Int32 id)
        {
            var entity = _ConversionCentrosCostoRepository.GetById(id);
            return _mapper.Map<ConversionCentrosCostoDto>(entity);
        }

        public Task<List<ConversionCentrosCostoDto>> GetByStatus(bool status)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> Update(ConversionCentrosCostoDto entityDto)
        {
            if (entityDto == null) throw new Exception("La entidad ConversionCentrosCosto es requerida");
            var entity = _mapper.Map<ConversionCentrosCostoEntity>(entityDto);
            return _ConversionCentrosCostoRepository.Update(entity);
        }
    }
}
