using Conciliador.Datos.Infraestructura.Entidades;
using Conciliador.Datos.Infraestructura.IRespositorios;
using Conciliador.Datos.Infraestructura.Repositorios;
using Conciliador.Logica.Servicios.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conciliador.Logica.Servicios.Implementaciones
{
    public class UsuarioService : IUsuarioService
    {
        private readonly IUsuarioRepository _usuarioRepository;

        public UsuarioService(IUsuarioRepository usuarioRepository)
        {
            _usuarioRepository = usuarioRepository ?? throw new ArgumentNullException(nameof(usuarioRepository));
        }

        public async Task<bool> Add(UsuarioEntity entity)
        {
            _usuarioRepository.Insert(entity);
            return true;
        }

        public Task<bool> Add(TodoEntity entity)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> Delete(Guid id)
        {
            _usuarioRepository.Delete(id);
            return true;
        }

        public async Task<List<UsuarioEntity>> GetAll()
        {
            return _usuarioRepository.GetAll().ToList();
        }

        public async Task<UsuarioEntity> GetById(Guid id)
        {
            return _usuarioRepository.GetById(id);
        }

        //public async Task<List<UsuarioEntity>> GetByStatus(string status)
        //{
        //    var Usuarios = _usuarioRepository.FindBy(e => e.Estado == status).ToList();
        //    return Usuarios;
        //}


        public Task<List<TodoEntity>> GetByStatus(bool status)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> Update(UsuarioEntity entity)
        {
            _usuarioRepository.Update(entity);
            return true;
        }

        public Task<bool> Update(TodoEntity entity)
        {
            throw new NotImplementedException();
        }

        Task<List<TodoEntity>> IUsuarioService.GetAll()
        {
            throw new NotImplementedException();
        }

        Task<TodoEntity> IUsuarioService.GetById(Guid id)
        {
            throw new NotImplementedException();
        }
    }

    public interface IUsuarioRepository
    {
        void Insert(UsuarioEntity entity);
        void Delete(Guid id);
        IEnumerable<UsuarioEntity> GetAll();
        UsuarioEntity GetById(Guid id);
        IEnumerable<UsuarioEntity> FindBy(Func<UsuarioEntity, bool> predicate);
        void Update(UsuarioEntity entity);
    }
}
