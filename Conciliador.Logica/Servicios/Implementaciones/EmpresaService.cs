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
    public class EmpresaService : IEmpresaService
    {
        private readonly IEmpresaRepository _EmpresaRepository;
        private readonly IMapper _mapper;

        public EmpresaService(IEmpresaRepository EmpresaRepository, IMapper mapper)
        {
            this._EmpresaRepository = EmpresaRepository;
            _mapper = mapper;
        }
        public async Task<bool> Add(EmpresaDto entityDto)
        {
            if (entityDto == null) throw new Exception("La entidad Empresa es requerida");
            var entity = _mapper.Map<EmpresaEntity>(entityDto);
            return _EmpresaRepository.Insert(entity);
        }

        public async Task<bool> Delete(Int32 id)
        {
            return _EmpresaRepository.Delete(id);
        }

        public async Task<List<EmpresaDto>> GetAll()
        {
            var entities = _EmpresaRepository.GetAll().ToList();
            var responseDTOs = _mapper.Map<List<EmpresaDto>>(entities);
            return responseDTOs;

        }

        public async Task<EmpresaDto> GetById(Int32 id)
        {
            var entity = _EmpresaRepository.GetById(id);
            return _mapper.Map<EmpresaDto>(entity);
        }

        public Task<List<EmpresaDto>> GetByStatus(bool status)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> Update(EmpresaDto entityDto)
        {
            if (entityDto == null) throw new Exception("La entidad Empresa es requerida");
            var entity = _mapper.Map<EmpresaEntity>(entityDto);
            return _EmpresaRepository.Update(entity);
        }
    }
}
