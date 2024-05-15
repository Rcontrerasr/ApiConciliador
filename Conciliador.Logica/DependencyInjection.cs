using Conciliador.Datos.Infraestructura;
using Conciliador.Datos.Infraestructura.IRespositorios;
using Conciliador.Datos.Infraestructura.Repositorios;
using Conciliador.Logica.Servicios.Implementaciones;
using Conciliador.Logica.Servicios.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conciliador.Logica
{
    public static class DependencyInjection
    {

        public static IServiceCollection AddDbContextBusiness(this IServiceCollection services, string connectionString)
        {

            services.AddDbContext<DataBaseContext>(
                options => options.UseSqlServer(connectionString));
            return services;
        }


        public static IServiceCollection AddInfrastructureBusiness(this IServiceCollection services)
        {
            #region Repositorios
            services.AddTransient<ITodoRepository, TodoRepository> ();
          

            #endregion 
            #region Servicios
            services.AddTransient<ITodoService, TodoService>();

            #endregion

           


            return services;
        }
    }
}
