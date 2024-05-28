using Conciliador.Datos.Infraestructura.Entidades;
using Conciliador.Datos.Infraestructura.IRespositorios;
using Microsoft.Extensions.Logging;

namespace Conciliador.Datos.Infraestructura.Repositorios
{
 

    public class RegistroDetallePlantillaRepository : RepositorioGenerico<RegistroDetallePlantillaEntity, DataBaseContext>, IRegistroDetallePlantillaRepository
    {
        public RegistroDetallePlantillaRepository(DataBaseContext context, ILogger<RegistroDetallePlantillaEntity> logger) : base(context, logger)
        {

        }
    }




}
