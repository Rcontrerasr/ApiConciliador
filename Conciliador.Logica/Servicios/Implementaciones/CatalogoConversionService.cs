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
    public class CatalogoConversionService : ICatalogoConversionService
    {
        private readonly ICatalogoConversionRepository _CatalogoConversionRepository;
        private readonly IMapper _mapper;

        public CatalogoConversionService(ICatalogoConversionRepository CatalogoConversionRepository, IMapper mapper)
        {
            this._CatalogoConversionRepository = CatalogoConversionRepository;
            _mapper = mapper;
        }
        public async Task<bool> Add(CatalogoConversionDto entityDto)
        {
            if (entityDto == null) throw new Exception("La entidad CatalogoConversion es requerida");
            var entity = _mapper.Map<CatalogoConversionEntity>(entityDto);
            return _CatalogoConversionRepository.Insert(entity);
        }

        public async Task<bool> Delete(Int32 id)
        {
            return _CatalogoConversionRepository.Delete(id);
        }

        public async Task<List<CatalogoConversionDto>> GetAll()
        {
            var entities = _CatalogoConversionRepository.GetAll().ToList();
            var responseDTOs = _mapper.Map<List<CatalogoConversionDto>>(entities);
            return responseDTOs;

        }

        public async Task<CatalogoConversionDto> GetById(Int32 id)
        {
            var entity = _CatalogoConversionRepository.GetById(id);
            return _mapper.Map<CatalogoConversionDto>(entity);
        }

        public Task<List<CatalogoConversionDto>> GetByStatus(bool status)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> Update(CatalogoConversionDto entityDto)
        {
            if (entityDto == null) throw new Exception("La entidad CatalogoConversion es requerida");
            var entity = _mapper.Map<CatalogoConversionEntity>(entityDto);
            return _CatalogoConversionRepository.Update(entity);
        }
    }
}
