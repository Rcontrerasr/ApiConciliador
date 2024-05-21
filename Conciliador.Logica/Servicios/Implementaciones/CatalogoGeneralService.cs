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
    public class CatalogoGeneralService : ICatalogoGeneralService
    {
        private readonly ICatalogoGeneralRepository _CatalogoGeneralRepository;
        private readonly IMapper _mapper;

        public CatalogoGeneralService(ICatalogoGeneralRepository CatalogoGeneralRepository, IMapper mapper)
        {
            this._CatalogoGeneralRepository = CatalogoGeneralRepository;
            _mapper = mapper;
        }
        public async Task<bool> Add(CatalogoGeneralDto entityDto)
        {
            if (entityDto == null) throw new Exception("La entidad CatalogoGeneral es requerida");
            var entity = _mapper.Map<CatalogoGeneralEntity>(entityDto);
            return _CatalogoGeneralRepository.Insert(entity);
        }

        public async Task<bool> Delete(Int32 id)
        {
            return _CatalogoGeneralRepository.Delete(id);
        }

        public async Task<List<CatalogoGeneralDto>> GetAll()
        {
            var entities = _CatalogoGeneralRepository.GetAll().ToList();
            var responseDTOs = _mapper.Map<List<CatalogoGeneralDto>>(entities);
            return responseDTOs;

        }

        public async Task<CatalogoGeneralDto> GetById(Int32 id)
        {
            var entity = _CatalogoGeneralRepository.GetById(id);
            return _mapper.Map<CatalogoGeneralDto>(entity);
        }

        public Task<List<CatalogoGeneralDto>> GetByStatus(bool status)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> Update(CatalogoGeneralDto entityDto)
        {
            if (entityDto == null) throw new Exception("La entidad CatalogoGeneral es requerida");
            var entity = _mapper.Map<CatalogoGeneralEntity>(entityDto);
            return _CatalogoGeneralRepository.Update(entity);
        }
    }
}
