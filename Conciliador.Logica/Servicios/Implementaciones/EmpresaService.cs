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
        private readonly IEmpresaRepository _empresaRepository;

        public EmpresaService(IEmpresaRepository empresaRepository)
        {
            _empresaRepository = empresaRepository;
        }

        public async Task<bool> Add(EmpresaEntity entity)
        {
            _empresaRepository.Insert(entity);
            return true;
        }

        public Task<bool> Add(TodoEntity entity)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> Delete(Guid id)
        {
            _empresaRepository.Delete(id);
            return true;
        }

        public async Task<List<EmpresaEntity>> GetAll()
        {
            return _empresaRepository.GetAll().ToList();
        }

        public async Task<EmpresaEntity> GetById(Guid id)
        {
            return _empresaRepository.GetById(id);
        }

        public async Task<List<EmpresaEntity>> GetByStatus(string status)
        {
            var empresas = _empresaRepository.FindBy(e => e.Estado == status).ToList();
            return empresas;
        }

        public Task<List<TodoEntity>> GetByStatus(bool status)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> Update(EmpresaEntity entity)
        {
            _empresaRepository.Update(entity);
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
    }
}
