using Conciliador.Datos.Infraestructura.Entidades;
using Conciliador.Datos.Infraestructura.IRespositorios;
using Microsoft.Extensions.Logging;

namespace Conciliador.Datos.Infraestructura.Repositorios
{
 

    public class TipoCatalogoRepository : RepositorioGenerico<TipoCatalogoEntity, DataBaseContext>, ITipoCatalogoRepository
    {
        public TipoCatalogoRepository(DataBaseContext context, ILogger<TipoCatalogoEntity> logger) : base(context, logger)
        {

        }
    }




}
