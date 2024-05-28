using Conciliador.Datos.Infraestructura.Entidades;
using Conciliador.Datos.Infraestructura.IRespositorios;
using Microsoft.Extensions.Logging;

namespace Conciliador.Datos.Infraestructura.Repositorios
{
 

    public class ColumnasExcelRepository : RepositorioGenerico<ColumnasExcelEntity, DataBaseContext>, IColumnasExcelRepository
    {
        public ColumnasExcelRepository(DataBaseContext context, ILogger<ColumnasExcelEntity> logger) : base(context, logger)
        {

        }
    }




}
