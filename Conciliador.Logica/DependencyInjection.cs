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
            services.AddTransient<IEmpresaRepository, EmpresaRepository>();
            services.AddTransient<IModuloRepository, ModuloRepository>();
            services.AddTransient<IModuloRolesRepository, ModuloRolesRepository>();
            services.AddTransient<IUsuarioRepository, UsuarioRepository>();
            services.AddTransient<IConversionCentrosCostoRepository, ConversionCentrosCostoRepository>();
            services.AddTransient<ICatalogoConversionRepository, CatalogoConversionRepository>();
            services.AddTransient<ICatalogoGeneralRepository, CatalogoGeneralRepository>();
            services.AddTransient<ICatalogoNombreRepository, CatalogoNombreRepository>();
            services.AddTransient<IRolesRepository, RolesRepository>();
            services.AddTransient<IMenuRepository, MenuRepository>();

            services.AddTransient<ITipoConciliacionRepository, TipoConciliacionRepository>();
            services.AddTransient<ITipoFuenteRepository, TipoFuenteRepository>();
            services.AddTransient<ITipoCatalogoRepository, TipoCatalogoRepository>();
            services.AddTransient<IPlantillaRepository, PlantillaRepository>();
            services.AddTransient<IColumnasExcelRepository, ColumnasExcelRepository>();
            services.AddTransient<IRegistroCabeceraPlantillaRepository, RegistroCabeceraPlantillaRepository>();
            services.AddTransient<IDetallesPlantillaRepository, DetallesPlantillaRepository>();
            services.AddTransient<IMenuRepository, MenuRepository>();
            services.AddTransient<IRegistroDetallePlantillaRepository, RegistroDetallePlantillaRepository>();




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
            services.AddTransient<IMenuService, MenuService>();

            services.AddTransient<ITipoConciliacionService, TipoConciliacionService>();
            services.AddTransient<ITipoFuenteService, TipoFuenteService>();
            services.AddTransient<ITipoCatalogoService, TipoCatalogoService>();
            services.AddTransient<IPlantillasService, PlantillaService>();
            services.AddTransient<IColumnasExcelService, ColumnasExcelService>();
            services.AddTransient<IRegistroCabeceraPlantillaService, RegistroCabeceraPlantillaService>();
            services.AddTransient<IDetallesPlantillasService, DetallesPlantillaService>();
            services.AddTransient<IRegistroDetallePlantillaService, RegistroDetallePlantillaService>();

            #endregion




            return services;
        }
    }
}