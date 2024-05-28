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
    public class TipoConciliacionService : ITipoConciliacionService
    {
        private readonly ITipoConciliacionRepository _TipoConciliacionRepository;
        private readonly IMapper _mapper;

        public TipoConciliacionService(ITipoConciliacionRepository TipoConciliacionRepository, IMapper mapper)
        {
            this._TipoConciliacionRepository = TipoConciliacionRepository;
            _mapper = mapper;
        }
        public async Task<bool> Add(TipoConciliacionDto entityDto)
        {
            if (entityDto == null) throw new Exception("La entidad TipoConciliacion es requerida");
            var entity = _mapper.Map<TipoConciliacionEntity>(entityDto);
            return _TipoConciliacionRepository.Insert(entity);
        }

        public async Task<bool> Delete(Int32 id)
        {
            return _TipoConciliacionRepository.Delete(id);
        }

        public async Task<List<TipoConciliacionDto>> GetAll()
        {
            var entities = _TipoConciliacionRepository.GetAll().ToList();
            var responseDTOs = _mapper.Map<List<TipoConciliacionDto>>(entities);
            return responseDTOs;

        }

        public async Task<TipoConciliacionDto> GetById(Int32 id)
        {
            var entity = _TipoConciliacionRepository.GetById(id);
            return _mapper.Map<TipoConciliacionDto>(entity);
        }

        public Task<List<TipoConciliacionDto>> GetByStatus(bool status)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> Update(TipoConciliacionDto entityDto)
        {
            if (entityDto == null) throw new Exception("La entidad TipoConciliacion es requerida");
            var entity = _mapper.Map<TipoConciliacionEntity>(entityDto);
            return _TipoConciliacionRepository.Update(entity);
        }
    }
}
