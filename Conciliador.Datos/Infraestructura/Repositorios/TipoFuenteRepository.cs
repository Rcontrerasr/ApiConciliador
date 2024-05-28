using Conciliador.Datos.Infraestructura.Entidades;
using Conciliador.Datos.Infraestructura.IRespositorios;
using Microsoft.Extensions.Logging;

namespace Conciliador.Datos.Infraestructura.Repositorios
{
 

    public class TipoFuenteRepository : RepositorioGenerico<TipoFuenteEntity, DataBaseContext>, ITipoFuenteRepository
    {
        public TipoFuenteRepository(DataBaseContext context, ILogger<TipoFuenteEntity> logger) : base(context, logger)
        {

        }
    }




}
