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
    public class ModuloRepository : RepositorioGenerico<ModuloEntity, DataBaseContext>, IModuloRepository
    {
        public ModuloRepository(DataBaseContext context, ILogger<ModuloEntity> logger) : base(context, logger)
        {
        }
    }
}
