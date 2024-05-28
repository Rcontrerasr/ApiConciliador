using Conciliador.Datos.Infraestructura.Entidades;
using Conciliador.Datos.Infraestructura.IRespositorios;
using Microsoft.Extensions.Logging;

namespace Conciliador.Datos.Infraestructura.Repositorios
{
 

    public class DetallesPlantillaRepository : RepositorioGenerico<DetallesPlantillaEntity, DataBaseContext>, IDetallesPlantillaRepository
    {
        public DetallesPlantillaRepository(DataBaseContext context, ILogger<DetallesPlantillaEntity> logger) : base(context, logger)
        {

        }
    }




}
