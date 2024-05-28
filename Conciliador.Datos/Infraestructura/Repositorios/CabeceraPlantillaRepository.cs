using Conciliador.Datos.Infraestructura.Entidades;
using Conciliador.Datos.Infraestructura.IRespositorios;
using Microsoft.Extensions.Logging;

namespace Conciliador.Datos.Infraestructura.Repositorios
{
 

    public class CabeceraPlantillaRepository : RepositorioGenerico<CabeceraPlantillaEntity, DataBaseContext>, ICabeceraPlantillaRepository
    {
        public CabeceraPlantillaRepository(DataBaseContext context, ILogger<CabeceraPlantillaEntity> logger) : base(context, logger)
        {

        }
    }




}
