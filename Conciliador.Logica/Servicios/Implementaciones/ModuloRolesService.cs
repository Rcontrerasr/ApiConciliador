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
    public class ModuloRolesService : IModuloRolesService
    {
        private readonly IModuloRolesRepository _ModuloRolesRepository;
        private readonly IMapper _mapper;

        public ModuloRolesService(IModuloRolesRepository ModuloRolesRepository, IMapper mapper)
        {
            this._ModuloRolesRepository = ModuloRolesRepository;
            _mapper = mapper;
        }
        public async Task<bool> Add(ModuloRolesDto entityDto)
        {
            if (entityDto == null) throw new Exception("La entidad ModuloRoles es requerida");
            var entity = _mapper.Map<ModuloRolesEntity>(entityDto);
            return _ModuloRolesRepository.Insert(entity);
        }

        public async Task<bool> Delete(Int32 id)
        {
            return _ModuloRolesRepository.Delete(id);
        }

        public async Task<List<ModuloRolesDto>> GetAll()
        {
            var entities = _ModuloRolesRepository.GetAll().ToList();
            var responseDTOs = _mapper.Map<List<ModuloRolesDto>>(entities);
            return responseDTOs;

        }

        public async Task<ModuloRolesDto> GetById(Int32 id)
        {
            var entity = _ModuloRolesRepository.GetById(id);
            return _mapper.Map<ModuloRolesDto>(entity);
        }

        public Task<List<ModuloRolesDto>> GetByStatus(bool status)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> Update(ModuloRolesDto entityDto)
        {
            if (entityDto == null) throw new Exception("La entidad ModuloRoles es requerida");
            var entity = _mapper.Map<ModuloRolesEntity>(entityDto);
            return _ModuloRolesRepository.Update(entity);
        }
    }
}
