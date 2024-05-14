using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conciliador.Datos.Infraestructura.Entidades
{
    public class BancosEntity
    {
        [Key]
        public int IdTabla { get; set; }
        public string NombreBanco { get; set; }
        public string CodigoBanco { get; set; }
        public string Estado { get; set; } // Agregada la propiedad Estado
        public DateTime FechaCreacion { get; set; }
        public DateTime FechaActualizacion { get; set; }
        public string UsuarioCreacionModificacion { get; set; }
    }
}
