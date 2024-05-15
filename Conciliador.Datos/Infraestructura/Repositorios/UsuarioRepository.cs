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
    public class UsuarioRepository : RepositorioGenerico<UsuarioEntity, DataBaseContext>, IUsuarioRepository
    {
        public UsuarioRepository(DataBaseContext context, ILogger<UsuarioEntity> logger) : base(context, logger)
        {
        }
    }

   

    internal interface IUsuarioRepository
    {
    }
}
