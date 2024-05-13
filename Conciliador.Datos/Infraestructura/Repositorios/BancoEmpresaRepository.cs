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
    public class BancoEmpresaRepository : RepositorioGenerico<BancoEmpresaEntity, DataBaseContext>, IBancoEmpresaRepository
    {
        public BancoEmpresaRepository(DataBaseContext context, ILogger<BancoEmpresaEntity> logger) : base(context, logger)
        {
        }
    }
}
