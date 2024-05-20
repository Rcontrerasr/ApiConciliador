using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conciliador.Datos.Infraestructura.Entidades
{
    public class ModuloEntity:BaseEntity
    {
       
        public string NombreModulo { get; set; }
        public string CodigoModulo { get; set; }
        public string DireccionModulo { get; set; }
      
    }
}
