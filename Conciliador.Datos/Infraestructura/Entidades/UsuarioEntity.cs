using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conciliador.Datos.Infraestructura.Entidades
{
    public class UsuarioEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Int32 Id { get; set; }

        public string Identificacion { get; set; }

        public string Nombres { get; set; }

        public string Correo { get; set; }

        public int Rol { get; set; }

        public string Estado { get; set; }
        public string Estado2 { get; set; }

        public DateTime UltimaConexion { get; set; }

        public DateTime FechaCreacion { get; set; }

        public DateTime FechaActualizacion { get; set; }

        public string UsuarioCreacionModificacion { get; set; }
    }
}
