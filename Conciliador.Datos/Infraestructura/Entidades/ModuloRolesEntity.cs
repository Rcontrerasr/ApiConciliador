using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conciliador.Datos.Infraestructura.Entidades
{
    public class ModuloRolesEntity
    {
        [Key]
        public int IdTabla { get; set; }

        [MaxLength(100)]
        public string NombreRol { get; set; }

        [MaxLength(50)]
        public string Estado { get; set; }

        public DateTime FechaCreacion { get; set; }

        public DateTime FechaActualizacion { get; set; }

        [MaxLength(200)]
        public string UsuarioCreacionModificacion { get; set; }
    }
}
