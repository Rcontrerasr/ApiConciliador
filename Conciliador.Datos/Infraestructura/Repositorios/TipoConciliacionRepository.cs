using Conciliador.Datos.Infraestructura.Entidades;
using Conciliador.Datos.Infraestructura.IRespositorios;
using Microsoft.Extensions.Logging;

namespace Conciliador.Datos.Infraestructura.Repositorios
{
 

    public class TipoConciliacionRepository : RepositorioGenerico<TipoConciliacionEntity, DataBaseContext>, ITipoConciliacionRepository
    {
        public TipoConciliacionRepository(DataBaseContext context, ILogger<TipoConciliacionEntity> logger) : base(context, logger)
        {

        }
    }




}
