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
    public class TipoCatalogoService : ITipoCatalogoService
    {
        private readonly ITipoCatalogoRepository _TipoCatalogoRepository;
        private readonly IMapper _mapper;

        public TipoCatalogoService(ITipoCatalogoRepository TipoCatalogoRepository, IMapper mapper)
        {
            this._TipoCatalogoRepository = TipoCatalogoRepository;
            _mapper = mapper;
        }
        public async Task<bool> Add(TipoCatalogoDto entityDto)
        {
            if (entityDto == null) throw new Exception("La entidad TipoCatalogo es requerida");
            var entity = _mapper.Map<TipoCatalogoEntity>(entityDto);
            return _TipoCatalogoRepository.Insert(entity);
        }

        public async Task<bool> Delete(Int32 id)
        {
            return _TipoCatalogoRepository.Delete(id);
        }

        public async Task<List<TipoCatalogoDto>> GetAll()
        {
            var entities = _TipoCatalogoRepository.GetAll().ToList();
            var responseDTOs = _mapper.Map<List<TipoCatalogoDto>>(entities);
            return responseDTOs;

        }

        public async Task<TipoCatalogoDto> GetById(Int32 id)
        {
            var entity = _TipoCatalogoRepository.GetById(id);
            return _mapper.Map<TipoCatalogoDto>(entity);
        }

        public Task<List<TipoCatalogoDto>> GetByStatus(bool status)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> Update(TipoCatalogoDto entityDto)
        {
            if (entityDto == null) throw new Exception("La entidad TipoCatalogo es requerida");
            var entity = _mapper.Map<TipoCatalogoEntity>(entityDto);
            return _TipoCatalogoRepository.Update(entity);
        }
    }
}
