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
    public class UsuarioService : IUsuarioService
    {
        private readonly IUsuarioRepository _UsuarioRepository;

        public UsuarioService(IUsuarioRepository UsuarioRepository)
        {
            this._UsuarioRepository = UsuarioRepository;
        }
        public async Task<bool> Add(UsuarioEntity entity)
        {
            _UsuarioRepository.Insert(entity);
            return true;
        }

        public async Task<bool> Delete(Int32 id)
        {
            _UsuarioRepository.Delete(id);
            return true;
        }

      

        public async Task<List<UsuarioEntity>> GetAll()
        {
            return _UsuarioRepository.GetAll().ToList();

        }

        public async Task<UsuarioEntity> GetById(Int32 id)
        {
            return _UsuarioRepository.GetById(id);
        }

       

        public async Task<List<UsuarioEntity>> GetByStatus(bool status)
        {
            var UsuarioList = _UsuarioRepository.FindBy(t => t.Estado == "").ToList();
            return UsuarioList;
        }

        public async Task<bool> Update(UsuarioEntity entity)
        {
            _UsuarioRepository.Update(entity);
            return true;
        }
    }
}
