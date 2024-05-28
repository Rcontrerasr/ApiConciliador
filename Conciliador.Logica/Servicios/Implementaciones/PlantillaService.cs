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
    public class PlantillaService : IPlantillasService
    {
        private readonly IPlantillaRepository _PlantillaRepository;
        private readonly IMapper _mapper;

        public PlantillaService(IPlantillaRepository PlantillaRepository, IMapper mapper)
        {
            this._PlantillaRepository = PlantillaRepository;
            _mapper = mapper;
        }
        public async Task<bool> Add(PlantillaDto entityDto)
        {
            if (entityDto == null) throw new Exception("La entidad Plantilla es requerida");
            var entity = _mapper.Map<PlantillaEntity>(entityDto);
            return _PlantillaRepository.Insert(entity);
        }

        public async Task<bool> Delete(Int32 id)
        {
            return _PlantillaRepository.Delete(id);
        }

        public async Task<List<PlantillaDto>> GetAll()
        {
            var entities = _PlantillaRepository.GetAll().ToList();
            var responseDTOs = _mapper.Map<List<PlantillaDto>>(entities);
            return responseDTOs;

        }

        public async Task<PlantillaDto> GetById(Int32 id)
        {
            var entity = _PlantillaRepository.GetById(id);
            return _mapper.Map<PlantillaDto>(entity);
        }

        public Task<List<PlantillaDto>> GetByStatus(bool status)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> Update(PlantillaDto entityDto)
        {
            if (entityDto == null) throw new Exception("La entidad Plantilla es requerida");
            var entity = _mapper.Map<PlantillaEntity>(entityDto);
            return _PlantillaRepository.Update(entity);
        }
    }
}
