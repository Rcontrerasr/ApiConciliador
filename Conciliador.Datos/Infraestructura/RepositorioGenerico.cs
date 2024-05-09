using Conciliador.Datos.Infraestructura.IRespositorios;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Conciliador.Datos.Infraestructura
{
    public class RepositorioGenerico<T, TContext> : IRepositorioGenerico<T> where T : class where TContext : DbContext
    {
        public readonly TContext context;
        private readonly ILogger<T> _logger;

        public RepositorioGenerico(TContext context, ILogger<T> logger)
        {
            this.context = context;
            _logger = logger;
        }

        public IQueryable<T> FindBy(Expression<Func<T, bool>> predicate)
        {
            //asqueryable

            try
            {
                var query = context.Set<T>().Where(predicate);
                return query;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public IQueryable<T> GetAll()
        {
            try
            {
                return context.Set<T>();//.Where(i => i.fechaEliminacion == null); ;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error", System.Reflection.MethodBase.GetCurrentMethod().Name, "PORTAL-TIERRAS", "GET");
                throw ex;
            }
        }

        public bool Insert(T entity)
        {
            try
            {
                if (entity == null)
                {
                    throw new ArgumentNullException("entity");
                }

                context.Add(entity);
                context.SaveChanges();

                _logger.LogInformation("Exito", System.Reflection.MethodBase.GetCurrentMethod().Name, JsonConvert.SerializeObject(entity));

                return true;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error", System.Reflection.MethodBase.GetCurrentMethod().Name, JsonConvert.SerializeObject(entity));
                throw ex;
            }
        }

        public bool Update(T entity)
        {
            try
            {
                if (entity == null)
                {
                    throw new ArgumentNullException("entity");
                }

                context.Entry(entity).State = EntityState.Modified;
                context.SaveChanges();

                _logger.LogInformation("Exito", System.Reflection.MethodBase.GetCurrentMethod().Name, JsonConvert.SerializeObject(entity));

                return true;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error", System.Reflection.MethodBase.GetCurrentMethod().Name, JsonConvert.SerializeObject(entity));
                throw;
            }
        }

        public bool Update(object id, T entity)
        {
            try
            {
                if (entity == null)
                {
                    throw new ArgumentNullException("entity");
                }


                var original = context.Set<T>().Find(id);

                //var EraseDate = original.fechaEliminacion;

                if (original != null)
                {
                    context.Entry(original).CurrentValues.SetValues(entity);

                    //original.fechaEliminacion = EraseDate;


                    context.SaveChanges();
                    _logger.LogInformation("Exito", System.Reflection.MethodBase.GetCurrentMethod().Name, JsonConvert.SerializeObject(entity));
                }

                return true;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error", System.Reflection.MethodBase.GetCurrentMethod().Name, JsonConvert.SerializeObject(entity));
                throw;
            }
        }

        public bool DeleteEntity(T entity)
        {
            try
            {
                if (entity == null) return false;

                context.Entry(entity).State = EntityState.Deleted;
                context.SaveChanges();

                _logger.LogInformation("Exito", System.Reflection.MethodBase.GetCurrentMethod().Name, JsonConvert.SerializeObject(entity));

                return true;
            }

            catch (Exception ex)
            {
                _logger.LogError(ex, "Error", System.Reflection.MethodBase.GetCurrentMethod().Name, JsonConvert.SerializeObject(entity));
                throw;
            }
        }

        public T GetById(object id)
        {
            try
            {
                T entity = null;

                if (id.GetType() == typeof(System.Object[]))
                {
                    var param_S = ((System.Object[])id).Cast<object>().ToArray();
                    entity = context.Set<T>().Find(param_S);
                }
                else
                {
                    entity = context.Set<T>().Find(id);
                }

                return entity == null ? null : entity;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public IQueryable<T> Table => context.Set<T>();

        public bool Delete(object id)
        {
            try
            {


                var entity = GetById(id);
                if (entity == null)
                {
                    throw new ArgumentNullException("entity");
                }

                // entity.fechaEliminacion = DateTime.Now;
                this.context.Entry(entity).State = EntityState.Deleted;
                this.context.SaveChanges();

                _logger.LogInformation("Exito", System.Reflection.MethodBase.GetCurrentMethod().Name, JsonConvert.SerializeObject(entity));

                return true;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error", System.Reflection.MethodBase.GetCurrentMethod().Name, id);
                throw;
            }
        }


        public bool DeleteAll(List<T> list)
        {
            try
            {
                context.Set<T>().RemoveRange(list);
                this.context.SaveChanges();

                _logger.LogInformation("Exito", System.Reflection.MethodBase.GetCurrentMethod().Name, JsonConvert.SerializeObject(list));

                return true;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error", System.Reflection.MethodBase.GetCurrentMethod().Name, JsonConvert.SerializeObject(list));
                throw;
            }
        }


        public bool SaveAll(List<T> list)
        {
            try
            {

                context.Set<T>().AddRange(list);
                context.SaveChanges();

                _logger.LogInformation("Exito", System.Reflection.MethodBase.GetCurrentMethod().Name, JsonConvert.SerializeObject(list));

                return true;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error", System.Reflection.MethodBase.GetCurrentMethod().Name, JsonConvert.SerializeObject(list));
                throw;
            }
        }

        public bool UpdateAll(List<T> list)
        {
            try
            {
                //list.ForEach(entity =>
                //{

                //    context.Entry(entity).State = EntityState.Modified;
                //});

                context.Set<T>().UpdateRange(list);
                context.SaveChanges();

                _logger.LogInformation("Exito", System.Reflection.MethodBase.GetCurrentMethod().Name, JsonConvert.SerializeObject(list));

                return true;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error", System.Reflection.MethodBase.GetCurrentMethod().Name, JsonConvert.SerializeObject(list));

                throw;
            }
        }

        public void reload(ref T entity)
        {
            context.Entry(entity).Reload();

        }
    }
}
