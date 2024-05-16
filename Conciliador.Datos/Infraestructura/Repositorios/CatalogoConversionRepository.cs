using Conciliador.Datos.Infraestructura.Entidades;
using Conciliador.Datos.Infraestructura.IRespositorios;
using Microsoft.Extensions.Logging;

namespace Conciliador.Datos.Infraestructura.Repositorios
{
 

    public class CatalogoConversionRepository : RepositorioGenerico<CatalogoConversionEntity, DataBaseContext>, ICatalogoConversionRepository
    {
        public CatalogoConversionRepository(DataBaseContext context, ILogger<CatalogoConversionEntity> logger) : base(context, logger)
        {

        }
    }




}
