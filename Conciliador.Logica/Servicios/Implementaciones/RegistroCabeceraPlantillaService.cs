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
    public class RegistroCabeceraPlantillaService : IRegistroCabeceraPlantillaService
    {
        private readonly IRegistroCabeceraPlantillaRepository _RegistroCabeceraPlantillaRepository;
        private readonly IMapper _mapper;

        public RegistroCabeceraPlantillaService(IRegistroCabeceraPlantillaRepository RegistroCabeceraPlantillaRepository, IMapper mapper)
        {
            this._RegistroCabeceraPlantillaRepository = RegistroCabeceraPlantillaRepository;
            _mapper = mapper;
        }
        public async Task<bool> Add(RegistroCabeceraPlantillaDto entityDto)
        {
            if (entityDto == null) throw new Exception("La entidad RegistroCabeceraPlantilla es requerida");
            var entity = _mapper.Map<RegistroCabeceraPlantillaEntity>(entityDto);
            return _RegistroCabeceraPlantillaRepository.Insert(entity);
        }

        public async Task<bool> Delete(Int32 id)
        {
            return _RegistroCabeceraPlantillaRepository.Delete(id);
        }

        public async Task<List<RegistroCabeceraPlantillaDto>> GetAll()
        {
            var entities = _RegistroCabeceraPlantillaRepository.GetAll().ToList();
            var responseDTOs = _mapper.Map<List<RegistroCabeceraPlantillaDto>>(entities);
            return responseDTOs;

        }

        public async Task<RegistroCabeceraPlantillaDto> GetById(Int32 id)
        {
            var entity = _RegistroCabeceraPlantillaRepository.GetById(id);
            return _mapper.Map<RegistroCabeceraPlantillaDto>(entity);
        }

        public Task<List<RegistroCabeceraPlantillaDto>> GetByStatus(bool status)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> Update(RegistroCabeceraPlantillaDto entityDto)
        {
            if (entityDto == null) throw new Exception("La entidad RegistroCabeceraPlantilla es requerida");
            var entity = _mapper.Map<RegistroCabeceraPlantillaEntity>(entityDto);
            return _RegistroCabeceraPlantillaRepository.Update(entity);
        }
    }
}
