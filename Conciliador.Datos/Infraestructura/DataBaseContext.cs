using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Conciliador.Datos.Infraestructura.Entidades;


namespace Conciliador.Datos.Infraestructura
{
    public class DataBaseContext : DbContext
    {
        public DataBaseContext() { }

        public DataBaseContext(DbContextOptions<DataBaseContext> options)
            : base(options)
        {
        }


        public DbSet<TodoEntity> TodoEntities { get; set; }



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
           

        }
    }
}

