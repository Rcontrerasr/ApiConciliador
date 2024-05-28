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
    public class ColumnasExcelService : IColumnasExcelService
    {
        private readonly IColumnasExcelRepository _ColumnasExcelRepository;
        private readonly IMapper _mapper;

        public ColumnasExcelService(IColumnasExcelRepository ColumnasExcelRepository, IMapper mapper)
        {
            this._ColumnasExcelRepository = ColumnasExcelRepository;
            _mapper = mapper;
        }
        public async Task<bool> Add(ColumnasExceloDto entityDto)
        {
            if (entityDto == null) throw new Exception("La entidad ColumnasExcel es requerida");
            var entity = _mapper.Map<ColumnasExcelEntity>(entityDto);
            return _ColumnasExcelRepository.Insert(entity);
        }

        public async Task<bool> Delete(Int32 id)
        {
            return _ColumnasExcelRepository.Delete(id);
        }

        public async Task<List<ColumnasExceloDto>> GetAll()
        {
            var entities = _ColumnasExcelRepository.GetAll().ToList();
            var responseDTOs = _mapper.Map<List<ColumnasExceloDto>>(entities);
            return responseDTOs;

        }

        public async Task<ColumnasExceloDto> GetById(Int32 id)
        {
            var entity = _ColumnasExcelRepository.GetById(id);
            return _mapper.Map<ColumnasExceloDto>(entity);
        }

        public Task<List<ColumnasExceloDto>> GetByStatus(bool status)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> Update(ColumnasExceloDto entityDto)
        {
            if (entityDto == null) throw new Exception("La entidad ColumnasExcel es requerida");
            var entity = _mapper.Map<ColumnasExcelEntity>(entityDto);
            return _ColumnasExcelRepository.Update(entity);
        }
    }
}
