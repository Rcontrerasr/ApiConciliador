using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Conciliador.Datos.Infraestructura.Entidades;
using Conciliador.Datos.Infraestructura.Repositorios;


namespace Conciliador.Datos.Infraestructura
{
    public class DataBaseContext : DbContext
    {
        public DataBaseContext() { }

        public DataBaseContext(DbContextOptions<DataBaseContext> options)
            : base(options)
        {
        }
 
        public DbSet<ConversionCentrosCostoEntity> conversionCentrosCostoEntities { get; set; }
        public DbSet<ModuloEntity> moduloEntities { get; set; }
        public DbSet<ModuloRolesEntity> moduloRolesEntities { get; set; }
        public DbSet<TodoEntity> TodoEntities { get; set; }
        public DbSet<UsuarioEntity> usuarioEntities { get; set; }
        public DbSet<EmpresaEntity> empresaEntities { get; set; }
        public DbSet<CatalogoConversionEntity> catalogoConversionEntities { get; set; }
        public DbSet<CatalogoGeneralEntity> catalogoGeneralEntities { get; set; }
        public DbSet<CatalogoNombreEntity> catalogoNombreEntities { get; set; }



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
           

        }
    }
}

