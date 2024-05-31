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
    public class CabeceraPlantillaService : ICabeceraPlantillaService
    {
        private readonly ICabeceraPlantillaRepository _CabeceraPlantillaRepository;
        private readonly IMapper _mapper;

        public CabeceraPlantillaService(ICabeceraPlantillaRepository CabeceraPlantillaRepository, IMapper mapper)
        {
            this._CabeceraPlantillaRepository = CabeceraPlantillaRepository;
            _mapper = mapper;
        }
        public async Task<bool> Add(CabeceraPlantillaDto entityDto)
        {
            if (entityDto == null) throw new Exception("La entidad CabeceraPlantilla es requerida");
            var entity = _mapper.Map<CabeceraPlantillaEntity>(entityDto);
            return _CabeceraPlantillaRepository.Insert(entity);
        }

        public async Task<bool> Delete(Int32 id)
        {
            return _CabeceraPlantillaRepository.Delete(id);
        }

        public async Task<List<CabeceraPlantillaDto>> GetAll()
        {
            var entities = _CabeceraPlantillaRepository.GetAll().ToList();
            var responseDTOs = _mapper.Map<List<CabeceraPlantillaDto>>(entities);
            return responseDTOs;

        }

        public async Task<CabeceraPlantillaDto> GetById(Int32 id)
        {
            var entity = _CabeceraPlantillaRepository.GetById(id);
            return _mapper.Map<CabeceraPlantillaDto>(entity);
        }

        public Task<List<CabeceraPlantillaDto>> GetByStatus(bool status)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> Update(CabeceraPlantillaDto entityDto)
        {
            if (entityDto == null) throw new Exception("La entidad CabeceraPlantilla es requerida");
            var entity = _mapper.Map<CabeceraPlantillaEntity>(entityDto);
            return _CabeceraPlantillaRepository.Update(entity);
        }
    }
}
