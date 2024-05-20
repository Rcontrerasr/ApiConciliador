using Conciliador.Datos.Infraestructura.Entidades;
using Conciliador.Datos.Infraestructura.IRespositorios;
using Conciliador.Modelos.Enums;
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
    public class RepositorioGenerico<T, TContext> : IRepositorioGenerico<T> where T : BaseEntity where TContext : DbContext
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
                query = query.Where(e => e.EstadoRegistro.Equals(EstadoRegistroEntity.Activo));
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
                return context.Set<T>().Where(e => e.EstadoRegistro.Equals(EstadoRegistroEntity.Activo));
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error", System.Reflection.MethodBase.GetCurrentMethod().Name, "PORTAL-TIERRAS", "GET");
                throw ex;
            }
        }

        public bool Insert(T entity, string user)
        {
            try
            {
                if (entity == null)
                {
                    throw new ArgumentNullException("entity");
                }
                entity.FechaCreacion = DateTime.Now;
                entity.FechaEdicion = DateTime.Now;
                entity.CreadoPor = user;
                entity.EditadoPor = user;
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

        public bool Update(T entity, string user)
        {
            try
            {
                if (entity == null)
                {
                    throw new ArgumentNullException("entity");
                }
                entity.FechaEdicion = DateTime.Now;
                entity.EditadoPor = user;
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

        public bool Update(object id, T entity, string user)
        {
            try
            {
                if (entity == null)
                {
                    throw new ArgumentNullException("entity");
                }


                var original = context.Set<T>().Find(id);

                var EraseDate = original.FechaEliminacion;
                var deleteBy = original.EliminadoPor;
                var CreateDate = original.FechaCreacion;
                var createBy = original.CreadoPor;

                if (original != null)
                {
                    entity.FechaEdicion = DateTime.Now;
                    entity.EditadoPor = user;
                    context.Entry(original).CurrentValues.SetValues(entity);

                    original.FechaEliminacion = EraseDate;
                    original.EliminadoPor = deleteBy;
                    original.FechaCreacion = CreateDate;
                    original.CreadoPor = createBy;

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

        public bool DeleteEntity(T entity, string user)
        {
            try
            {
                if (entity == null)
                {
                    throw new ArgumentNullException("entity");
                }
                entity.FechaEliminacion = DateTime.Now;
                entity.EliminadoPor = user;
                entity.EstadoRegistro = EstadoRegistroEntity.Inactivo;
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

        public T GetById(object id)
        {
            try
            {
                T entity = null;

                if (id.GetType() == typeof(System.Object[]))
                {
                    var param_S = ((System.Object[])id).Cast<object>().ToArray();
                    entity = context.Set<T>().Find(param_S);
                    entity=entity!=null && entity.EstadoRegistro.Equals(EstadoRegistroEntity.Inactivo)?null:entity;
                }
                else
                {
                    entity = context.Set<T>().Find(id);
                    entity = entity != null && entity.EstadoRegistro.Equals(EstadoRegistroEntity.Inactivo) ? null : entity;
                }

                return entity == null ? null : entity;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public IQueryable<T> Table => context.Set<T>();

        public bool Delete(object id, string user)
        {
            try
            {
                var original = context.Set<T>().Find(id);

                if (original != null)
                {
                    original.FechaEliminacion = DateTime.Now;
                    original.EliminadoPor = user;

                    context.SaveChanges();
                    _logger.LogInformation("Exito", System.Reflection.MethodBase.GetCurrentMethod().Name, JsonConvert.SerializeObject(original));
                }

                return true;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error", System.Reflection.MethodBase.GetCurrentMethod().Name, "id:" + id);
                throw;
            }
        }


        public bool DeleteAll(List<T> list, string user)
        {
            try
            {
                list.ForEach(entity =>
                {
                    entity.FechaEliminacion = DateTime.Now;
                    entity.EliminadoPor = user;
                    entity.EstadoRegistro = EstadoRegistroEntity.Inactivo;

                });

                context.Set<T>().UpdateRange(list);
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


        public bool SaveAll(List<T> list, string user)
        {
            try
            {

                list.ForEach(entity =>
                {
                    entity.FechaCreacion = DateTime.Now;
                    entity.FechaEdicion = DateTime.Now;
                    entity.CreadoPor = user;
                    entity.EditadoPor = user;

                });

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

        public bool UpdateAll(List<T> list, string user)
        {
            try
            {
                list.ForEach(entity =>
                {
                    entity.FechaEdicion = DateTime.Now;
                    entity.EditadoPor = user;

                });

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
