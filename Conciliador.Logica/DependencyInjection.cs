


using Conciliador.Datos.Infraestructura;
using Conciliador.Datos.Infraestructura.IRespositorios;
using Conciliador.Datos.Infraestructura.Repositorios;
using Conciliador.Logica.Servicios.Implementaciones;
using Conciliador.Logica.Servicios.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

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
            services.AddTransient<IEmpresaRepository, EmpresaRepository> ();
            services.AddTransient<IModuloRepository, ModuloRepository> ();
            services.AddTransient<IModuloRolesRepository, ModuloRolesRepository> ();
            services.AddTransient<IUsuarioRepository, UsuarioRepository> ();
            services.AddTransient<IConversionCentrosCostoRepository, ConversionCentrosCostoRepository> ();
            services.AddTransient<ICatalogoConversionRepository, CatalogoConversionRepository> ();
            services.AddTransient<ICatalogoGeneralRepository, CatalogoGeneralRepository> ();
            services.AddTransient<ICatalogoNombreRepository, CatalogoNombreRepository> ();
            services.AddTransient<IRolesRepository, RolesRepository> ();

          

            #endregion 
            #region Servicios
            services.AddTransient<IEmpresaService, EmpresaService>();
            services.AddTransient<IModuloService, ModuloService>();
            services.AddTransient<IModuloRolesService, ModuloRolesService>();
            services.AddTransient<IUsuarioService, UsuarioService>();
            services.AddTransient<IConversionCentrosCostoService, ConversionCentrosCostoService>();
            services.AddTransient<ICatalogoConversionService, CatalogoConversionService>();
            services.AddTransient<ICatalogoGeneralService, CatalogoGeneralService>();
            services.AddTransient<ICatalogoNombreService, CatalogoNombreService>();
            services.AddTransient<IRolesService, RolesService>();

            #endregion

           


            return services;
        }
    }
}
