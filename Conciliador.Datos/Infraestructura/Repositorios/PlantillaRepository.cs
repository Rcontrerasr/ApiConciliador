using Conciliador.Datos.Infraestructura.Entidades;
using Conciliador.Datos.Infraestructura.IRespositorios;
using Microsoft.Extensions.Logging;

namespace Conciliador.Datos.Infraestructura.Repositorios
{
 

    public class PlantillaRepository : RepositorioGenerico<PlantillaEntity, DataBaseContext>, IPlantillaRepository
    {
        public PlantillaRepository(DataBaseContext context, ILogger<PlantillaEntity> logger) : base(context, logger)
        {

        }
    }




}
