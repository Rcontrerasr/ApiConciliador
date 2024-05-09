using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Conciliador.Datos.Infraestructura.IRespositorios
{
    public interface IRepositorioGenerico<T> where T : class
    {
        IQueryable<T> Table { get; }
        IQueryable<T> FindBy(Expression<Func<T, bool>> predicate);
        IQueryable<T> GetAll();
        bool Insert(T entity);
        bool Update(T entity);
        bool Update(object id, T entity);
        bool DeleteEntity(T entity);
        T GetById(object id);
        void reload(ref T entity);
        bool Delete(object id);
        bool DeleteAll(List<T> list);
        bool SaveAll(List<T> list);
        bool UpdateAll(List<T> list);
    }
}
