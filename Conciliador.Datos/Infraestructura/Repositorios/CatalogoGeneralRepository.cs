using Conciliador.Datos.Infraestructura.Entidades;
using Conciliador.Datos.Infraestructura.IRespositorios;
using Microsoft.Extensions.Logging;

namespace Conciliador.Datos.Infraestructura.Repositorios
{
 

    public class CatalogoGeneralRepository : RepositorioGenerico<CatalogoGeneralEntity, DataBaseContext>, ICatalogoGeneralRepository
    {
        public CatalogoGeneralRepository(DataBaseContext context, ILogger<CatalogoGeneralEntity> logger) : base(context, logger)
        {

        }
    }




}
