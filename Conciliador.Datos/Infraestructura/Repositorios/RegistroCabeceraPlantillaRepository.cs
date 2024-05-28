using Conciliador.Datos.Infraestructura.Entidades;
using Conciliador.Datos.Infraestructura.IRespositorios;
using Microsoft.Extensions.Logging;

namespace Conciliador.Datos.Infraestructura.Repositorios
{
 

    public class RegistroCabeceraPlantillaRepository : RepositorioGenerico<RegistroCabeceraPlantillaEntity, DataBaseContext>, IRegistroCabeceraPlantillaRepository
    {
        public RegistroCabeceraPlantillaRepository(DataBaseContext context, ILogger<RegistroCabeceraPlantillaEntity> logger) : base(context, logger)
        {

        }
    }




}
