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
    public class RegistroDetallePlantillaService : IRegistroDetallePlantillaService
    {
        private readonly IRegistroDetallePlantillaRepository _RegistroDetallePlantillaRepository;
        private readonly IMapper _mapper;

        public RegistroDetallePlantillaService(IRegistroDetallePlantillaRepository RegistroDetallePlantillaRepository, IMapper mapper)
        {
            this._RegistroDetallePlantillaRepository = RegistroDetallePlantillaRepository;
            _mapper = mapper;
        }
        public async Task<bool> Add(RegistroDetallePlantillaDto entityDto)
        {
            if (entityDto == null) throw new Exception("La entidad RegistroDetallePlantilla es requerida");
            var entity = _mapper.Map<RegistroDetallePlantillaEntity>(entityDto);
            return _RegistroDetallePlantillaRepository.Insert(entity);
        }

        public async Task<bool> Delete(Int32 id)
        {
            return _RegistroDetallePlantillaRepository.Delete(id);
        }

        public async Task<List<RegistroDetallePlantillaDto>> GetAll()
        {
            var entities = _RegistroDetallePlantillaRepository.GetAll().ToList();
            var responseDTOs = _mapper.Map<List<RegistroDetallePlantillaDto>>(entities);
            return responseDTOs;

        }

        public async Task<RegistroDetallePlantillaDto> GetById(Int32 id)
        {
            var entity = _RegistroDetallePlantillaRepository.GetById(id);
            return _mapper.Map<RegistroDetallePlantillaDto>(entity);
        }

        public Task<List<RegistroDetallePlantillaDto>> GetByStatus(bool status)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> Update(RegistroDetallePlantillaDto entityDto)
        {
            if (entityDto == null) throw new Exception("La entidad RegistroDetallePlantilla es requerida");
            var entity = _mapper.Map<RegistroDetallePlantillaEntity>(entityDto);
            return _RegistroDetallePlantillaRepository.Update(entity);
        }
    }
}
