using AutoMapper;
using Conciliador.Datos.Infraestructura.Entidades;
using Conciliador.Datos.Infraestructura.IRespositorios;
using Conciliador.Logica.Servicios.Interfaces;
using Conciliador.Modelos.DTOs;
using Microsoft.EntityFrameworkCore;


namespace Conciliador.Logica.Servicios.Implementaciones
{
    public class ModuloService : IModuloService
    {
        private readonly IModuloRepository _ModuloRepository;
        private readonly IMapper _mapper;

        public ModuloService(IModuloRepository ModuloRepository, IMapper mapper)
        {
            this._ModuloRepository = ModuloRepository;
            _mapper = mapper;
        }
        public async Task<bool> Add(ModuloDto entityDto)
        {
            if (entityDto == null) throw new Exception("La entidad Modulo es requerida");
            var entity = _mapper.Map<ModuloEntity>(entityDto);
            return _ModuloRepository.Insert(entity);
        }

        public async Task<bool> Delete(Int32 id)
        {
            return _ModuloRepository.Delete(id);
        }

        public async Task<List<ModuloDto>> GetAll()
        {
            var entities = _ModuloRepository.FindBy(m=>m.IdModuloPadre==null)
                .Include(m=>m.InverseIdModuloPadreNavigation)
                .ToList();
            var responseDTOs = _mapper.Map<List<ModuloDto>>(entities);
            return responseDTOs;

        }

        public async Task<ModuloDto> GetById(Int32 id)
        {
            var entity = _ModuloRepository.GetById(id);
            return _mapper.Map<ModuloDto>(entity);
        }

        public Task<List<ModuloDto>> GetByStatus(bool status)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> Update(ModuloDto entityDto)
        {
            if (entityDto == null) throw new Exception("La entidad Modulo es requerida");
            var entity = _mapper.Map<ModuloEntity>(entityDto);
            return _ModuloRepository.Update(entity);
        }
    }
}
