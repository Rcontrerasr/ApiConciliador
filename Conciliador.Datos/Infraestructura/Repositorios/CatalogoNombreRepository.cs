using Conciliador.Datos.Infraestructura.Entidades;
using Conciliador.Datos.Infraestructura.IRespositorios;
using Microsoft.Extensions.Logging;

namespace Conciliador.Datos.Infraestructura.Repositorios
{
 

    public class CatalogoNombreRepository : RepositorioGenerico<CatalogoNombreEntity, DataBaseContext>, ICatalogoNombreRepository
    {
        public CatalogoNombreRepository(DataBaseContext context, ILogger<CatalogoNombreEntity> logger) : base(context, logger)
        {

        }
    }




}
