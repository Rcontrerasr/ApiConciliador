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
    public class UsuarioService : IUsuarioService
    {
        private readonly IUsuarioRepository _UsuarioRepository;
        private readonly IMapper _mapper;

        public UsuarioService(IUsuarioRepository UsuarioRepository, IMapper mapper)
        {
            this._UsuarioRepository = UsuarioRepository;
            _mapper = mapper;
        }
        public async Task<bool> Add(UsuarioDto entityDto)
        {
            if (entityDto == null) throw new Exception("La entidad Usuario es requerida");
            var entity = _mapper.Map<UsuarioEntity>(entityDto);
            return _UsuarioRepository.Insert(entity);
        }

        public async Task<bool> Delete(Int32 id)
        {
            return _UsuarioRepository.Delete(id);
        }

        public async Task<List<UsuarioDto>> GetAll()
        {
            var entities = _UsuarioRepository.GetAll().ToList();
            var responseDTOs = _mapper.Map<List<UsuarioDto>>(entities);
            return responseDTOs;

        }

        public async Task<UsuarioDto> GetById(Int32 id)
        {
            var entity = _UsuarioRepository.GetById(id);
            return _mapper.Map<UsuarioDto>(entity);
        }

        public Task<List<UsuarioDto>> GetByStatus(bool status)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> Update(UsuarioDto entityDto)
        {
            if (entityDto == null) throw new Exception("La entidad Usuario es requerida");
            var entity = _mapper.Map<UsuarioEntity>(entityDto);
            return _UsuarioRepository.Update(entity);
        }
    }
}
