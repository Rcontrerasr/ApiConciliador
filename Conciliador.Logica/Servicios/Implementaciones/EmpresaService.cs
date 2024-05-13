using Conciliador.Datos.Infraestructura.Entidades;
using Conciliador.Datos.Infraestructura.IRespositorios;
using Conciliador.Logica.Servicios.Interfaces;
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

        public EmpresaService(IEmpresaRepository EmpresaRepository)
        {
            this._EmpresaRepository = EmpresaRepository;
        }
        public async Task<bool> Add(EmpresaEntity entity)
        {
            _EmpresaRepository.Insert(entity);
            return true;
        }

        public Task<bool> Add(TodoEntity entity)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> Delete(Guid id)
        {
            _EmpresaRepository.Delete(id);
            return true;
        }

        public async Task<List<EmpresaEntity>> GetAll()
        {
            return _EmpresaRepository.GetAll().ToList();

        }

        public async Task<EmpresaEntity> GetById(Guid id)
        {
            return _EmpresaRepository.GetById(id);
        }

        public async Task<List<EmpresaEntity>> GetByStatus(bool status)
        {
           var EmpresaList=_EmpresaRepository.FindBy(t=>t.Status == status).ToList();
            return EmpresaList;
        }

        public async Task<bool> Update(EmpresaEntity entity)
        {
            _EmpresaRepository.Update(entity);
            return true;
        }

        public Task<bool> Update(TodoEntity entity)
        {
            throw new NotImplementedException();
        }

        Task<List<TodoEntity>> IEmpresaService.GetAll()
        {
            throw new NotImplementedException();
        }

        Task<TodoEntity> IEmpresaService.GetById(Guid id)
        {
            throw new NotImplementedException();
        }

        Task<List<TodoEntity>> IEmpresaService.GetByStatus(bool status)
        {
            throw new NotImplementedException();
        }
    }
}
