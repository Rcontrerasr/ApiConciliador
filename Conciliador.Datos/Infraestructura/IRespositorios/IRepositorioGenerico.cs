using Conciliador.Datos.Infraestructura.Entidades;
using System.Linq.Expressions;

namespace Conciliador.Datos.Infraestructura.IRespositorios
{
    public interface IRepositorioGenerico<T> where T : BaseEntity
    {
        IQueryable<T> Table { get; }
        IQueryable<T> FindBy(Expression<Func<T, bool>> predicate);
        IQueryable<T> GetAll();
        bool Insert(T entity,string user="Generic");
        bool Update(T entity, string user = "Generic");
        bool Update(object id, T entity, string user = "Generic");
        bool DeleteEntity(T entity, string user = "Generic");
        T GetById(object id);
        void reload(ref T entity);
        bool Delete(object id, string user = "Generic");
        bool DeleteAll(List<T> list, string user = "Generic");
        bool SaveAll(List<T> list, string user = "Generic");
        bool UpdateAll(List<T> list, string user = "Generic");
    }
}
