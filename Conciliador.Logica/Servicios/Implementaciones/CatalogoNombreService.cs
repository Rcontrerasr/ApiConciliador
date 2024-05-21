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
    public class CatalogoNombreService : ICatalogoNombreService
    {
        private readonly ICatalogoNombreRepository _CatalogoNombreRepository;
        private readonly IMapper _mapper;

        public CatalogoNombreService(ICatalogoNombreRepository CatalogoNombreRepository, IMapper mapper)
        {
            this._CatalogoNombreRepository = CatalogoNombreRepository;
            _mapper = mapper;
        }
        public async Task<bool> Add(CatalogoNombreDto entityDto)
        {
            if (entityDto == null) throw new Exception("La entidad CatalogoNombre es requerida");
            var entity = _mapper.Map<CatalogoNombreEntity>(entityDto);
            return _CatalogoNombreRepository.Insert(entity);
        }

        public async Task<bool> Delete(Int32 id)
        {
            return _CatalogoNombreRepository.Delete(id);
        }

        public async Task<List<CatalogoNombreDto>> GetAll()
        {
            var entities = _CatalogoNombreRepository.GetAll().ToList();
            var responseDTOs = _mapper.Map<List<CatalogoNombreDto>>(entities);
            return responseDTOs;

        }

        public async Task<CatalogoNombreDto> GetById(Int32 id)
        {
            var entity = _CatalogoNombreRepository.GetById(id);
            return _mapper.Map<CatalogoNombreDto>(entity);
        }

        public Task<List<CatalogoNombreDto>> GetByStatus(bool status)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> Update(CatalogoNombreDto entityDto)
        {
            if (entityDto == null) throw new Exception("La entidad CatalogoNombre es requerida");
            var entity = _mapper.Map<CatalogoNombreEntity>(entityDto);
            return _CatalogoNombreRepository.Update(entity);
        }
    }
}
