using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conciliador.Datos.Infraestructura.Entidades
{
    public class ModuloRolesEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Int32 Id { get; set; }
        public Int32 IdRol { get; set; }
        public Int32 Idtabla { get; set; }

        //public string NombreRol { get; set; }

        //public string Estado { get; set; }

        //public DateTime FechaCreacion { get; set; }

        //public DateTime FechaActualizacion { get; set; }

        //public string UsuarioCreacionModificacion { get; set; }
    }
}
