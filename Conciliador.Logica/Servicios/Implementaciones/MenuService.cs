using AutoMapper;
using Conciliador.Datos.Infraestructura.Entidades;
using Conciliador.Datos.Infraestructura.IRespositorios;
using Conciliador.Logica.Servicios.Interfaces;
using Conciliador.Modelos.DTOs;
using Microsoft.EntityFrameworkCore;


namespace Conciliador.Logica.Servicios.Implementaciones
{
    public class MenuService : IMenuService
    {
        private readonly IMenuRepository _MenuRepository;
        private readonly IMapper _mapper;

        public MenuService(IMenuRepository MenuRepository, IMapper mapper)
        {
            this._MenuRepository = MenuRepository;
            _mapper = mapper;
        }
        public async Task<bool> Add(MenuDto entityDto)
        {
            if (entityDto == null) throw new Exception("La entidad Menu es requerida");
            var entity = _mapper.Map<MenuEntity>(entityDto);
            return _MenuRepository.Insert(entity);
        }

        public async Task<bool> Delete(Int32 id)
        {
            return _MenuRepository.Delete(id);
        }

        public async Task<List<MenuDto>> GetAll()
        {
            var entities = _MenuRepository.FindBy(m=>m.IdMenuPadre==null)
                .Include(m=>m.InverseIdMenuPadreNavigation)
                .ToList();
            var responseDTOs = _mapper.Map<List<MenuDto>>(entities);
            return responseDTOs;

        }

        public async Task<MenuDto> GetById(Int32 id)
        {
            var entity = _MenuRepository.GetById(id);
            return _mapper.Map<MenuDto>(entity);
        }

        public Task<List<MenuDto>> GetByStatus(bool status)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> Update(MenuDto entityDto)
        {
            if (entityDto == null) throw new Exception("La entidad Menu es requerida");
            var entity = _mapper.Map<MenuEntity>(entityDto);
            return _MenuRepository.Update(entity);
        }
    }
}
