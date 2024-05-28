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
    public class TipoFuenteService : ITipoFuenteService
    {
        private readonly ITipoFuenteRepository _TipoFuenteRepository;
        private readonly IMapper _mapper;

        public TipoFuenteService(ITipoFuenteRepository TipoFuenteRepository, IMapper mapper)
        {
            this._TipoFuenteRepository = TipoFuenteRepository;
            _mapper = mapper;
        }
        public async Task<bool> Add(TipoFuenteDto entityDto)
        {
            if (entityDto == null) throw new Exception("La entidad TipoFuente es requerida");
            var entity = _mapper.Map<TipoFuenteEntity>(entityDto);
            return _TipoFuenteRepository.Insert(entity);
        }

        public async Task<bool> Delete(Int32 id)
        {
            return _TipoFuenteRepository.Delete(id);
        }

        public async Task<List<TipoFuenteDto>> GetAll()
        {
            var entities = _TipoFuenteRepository.GetAll().ToList();
            var responseDTOs = _mapper.Map<List<TipoFuenteDto>>(entities);
            return responseDTOs;

        }

        public async Task<TipoFuenteDto> GetById(Int32 id)
        {
            var entity = _TipoFuenteRepository.GetById(id);
            return _mapper.Map<TipoFuenteDto>(entity);
        }

        public Task<List<TipoFuenteDto>> GetByStatus(bool status)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> Update(TipoFuenteDto entityDto)
        {
            if (entityDto == null) throw new Exception("La entidad TipoFuente es requerida");
            var entity = _mapper.Map<TipoFuenteEntity>(entityDto);
            return _TipoFuenteRepository.Update(entity);
        }
    }
}
