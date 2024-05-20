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
 
        public DbSet<ConversionCentrosCostoEntity> ConversionCentrosCostoEntities { get; set; }
        public DbSet<ModuloEntity> ModuloEntities { get; set; }
        public DbSet<ModuloRolesEntity> moduloRolesEntities { get; set; }
        public DbSet<UsuarioEntity> UsuarioEntities { get; set; }
        public DbSet<EmpresaEntity> EmpresaEntities { get; set; }
        public DbSet<CatalogoConversionEntity> CatalogoConversionEntities { get; set; }
        public DbSet<CatalogoGeneralEntity> CatalogoGeneralEntities { get; set; }
        public DbSet<CatalogoNombreEntity> CatalogoNombreEntities { get; set; }
        public DbSet<RolesEntity> RolesEntities { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ConversionCentrosCostoEntity>().ToTable("ConversionCentroCosto");
            modelBuilder.Entity<ModuloEntity>().ToTable("Modulo");
            modelBuilder.Entity<ModuloRolesEntity>().ToTable("moduloRoles");
            modelBuilder.Entity<UsuarioEntity>().ToTable("Usuario");
            modelBuilder.Entity<EmpresaEntity>().ToTable("Empresa");
            modelBuilder.Entity<CatalogoConversionEntity>().ToTable("CatalogoConversion");
            modelBuilder.Entity<CatalogoGeneralEntity>().ToTable("CatalogoGeneral");
            modelBuilder.Entity<CatalogoNombreEntity>().ToTable("CatalogoNombre");
            modelBuilder.Entity<RolesEntity>().ToTable("Roles");
           

        }
    }
}

