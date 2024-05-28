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
    public class DetallesPlantillaService : IDetallesPlantillasService
    {
        private readonly IDetallesPlantillaRepository _DetallesPlantillaRepository;
        private readonly IMapper _mapper;

        public DetallesPlantillaService(IDetallesPlantillaRepository DetallesPlantillaRepository, IMapper mapper)
        {
            this._DetallesPlantillaRepository = DetallesPlantillaRepository;
            _mapper = mapper;
        }
        public async Task<bool> Add(DetallesPlantillaDto entityDto)
        {
            if (entityDto == null) throw new Exception("La entidad DetallesPlantilla es requerida");
            var entity = _mapper.Map<DetallesPlantillaEntity>(entityDto);
            return _DetallesPlantillaRepository.Insert(entity);
        }

        public async Task<bool> Delete(Int32 id)
        {
            return _DetallesPlantillaRepository.Delete(id);
        }

        public async Task<List<DetallesPlantillaDto>> GetAll()
        {
            var entities = _DetallesPlantillaRepository.GetAll().ToList();
            var responseDTOs = _mapper.Map<List<DetallesPlantillaDto>>(entities);
            return responseDTOs;

        }

        public async Task<DetallesPlantillaDto> GetById(Int32 id)
        {
            var entity = _DetallesPlantillaRepository.GetById(id);
            return _mapper.Map<DetallesPlantillaDto>(entity);
        }

        public Task<List<DetallesPlantillaDto>> GetByStatus(bool status)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> Update(DetallesPlantillaDto entityDto)
        {
            if (entityDto == null) throw new Exception("La entidad DetallesPlantilla es requerida");
            var entity = _mapper.Map<DetallesPlantillaEntity>(entityDto);
            return _DetallesPlantillaRepository.Update(entity);
        }
    }
}
