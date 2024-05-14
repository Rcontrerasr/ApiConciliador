using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conciliador.Datos.Infraestructura.Entidades
{
    public class Usuario
    {
        [Key]
        public int IdTabla { get; set; }

        [MaxLength(20)]
        public string Identificacion { get; set; }

        [MaxLength(200)]
        public string Nombres { get; set; }

        [MaxLength(100)]
        public string Correo { get; set; }

        public int Rol { get; set; }

        [MaxLength(50)]
        public string Estado { get; set; }

        public DateTime UltimaConexion { get; set; }

        public DateTime FechaCreacion { get; set; }

        public DateTime FechaActualizacion { get; set; }

        [MaxLength(200)]
        public string UsuarioCreacionModificacion { get; set; }
    }
}
