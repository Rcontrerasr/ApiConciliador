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
    public class RolesService : IRolesService
    {
        private readonly IRolesRepository _RolesRepository;
        private readonly IMapper _mapper;

        public RolesService(IRolesRepository RolesRepository, IMapper mapper)
        {
            this._RolesRepository = RolesRepository;
            _mapper = mapper;
        }
        public async Task<bool> Add(RolesDto entityDto)
        {
            if (entityDto == null) throw new Exception("La entidad Roles es requerida");
            var entity = _mapper.Map<RolesEntity>(entityDto);
            return _RolesRepository.Insert(entity);
        }

        public async Task<bool> Delete(Int32 id)
        {
            return _RolesRepository.Delete(id);
        }

        public async Task<List<RolesDto>> GetAll()
        {
            var entities = _RolesRepository.GetAll().ToList();
            var responseDTOs = _mapper.Map<List<RolesDto>>(entities);
            return responseDTOs;

        }

        public async Task<RolesDto> GetById(Int32 id)
        {
            var entity = _RolesRepository.GetById(id);
            return _mapper.Map<RolesDto>(entity);
        }



        public async Task<bool> Update(RolesDto entityDto)
        {
            if (entityDto == null) throw new Exception("La entidad Roles es requerida");
            var entity = _mapper.Map<RolesEntity>(entityDto);
            return _RolesRepository.Update(entity);
        }
    }
}
