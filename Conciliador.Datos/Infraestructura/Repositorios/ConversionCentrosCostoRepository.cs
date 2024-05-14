using Conciliador.Datos.Infraestructura.Entidades;
using Conciliador.Datos.Infraestructura.IRespositorios;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conciliador.Datos.Infraestructura.Repositorios
{
    public class ConversionCentrosCostoRepository : RepositorioGenerico<ConversionCentrosCostoEntity, DataBaseContext>, IConversionCentrosCostoRepository
    {
        public ConversionCentrosCostoRepository(DataBaseContext context, ILogger<ConversionCentrosCostoEntity> logger) : base(context, logger)
        {
        }
    }

    internal interface IConversionCentrosCostoRepository
    {
    }
}
