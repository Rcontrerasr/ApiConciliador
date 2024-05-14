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
    public class TodoService : ITodoService
    {
        private readonly ITodoRepository _todoRepository;

        public TodoService(ITodoRepository todoRepository)
        {
            this._todoRepository = todoRepository;
        }
        public async Task<bool> Add(TodoEntity entity)
        {
            _todoRepository.Insert(entity);
            return true;
        }

        public async Task<bool> Delete(Guid id)
        {
            _todoRepository.Delete(id);
            return true;
        }

        public async Task<List<TodoEntity>> GetAll()
        {
            return _todoRepository.GetAll().ToList();

        }

        public async Task<TodoEntity> GetById(Guid id)
        {
            return _todoRepository.GetById(id);
        }

        public async Task<List<TodoEntity>> GetByStatus(bool status)
        {
           var todoList=_todoRepository.FindBy(t=>t.Status == status).ToList();
            return todoList;
        }

        public async Task<bool> Update(TodoEntity entity)
        {
            _todoRepository.Update(entity);
            return true;
        }
    }
}
