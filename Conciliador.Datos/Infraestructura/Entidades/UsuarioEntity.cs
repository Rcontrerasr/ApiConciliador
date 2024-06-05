using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conciliador.Datos.Infraestructura.Entidades
{
    public class UsuarioEntity:BaseEntity
    {

        public string Identificacion { get; set; }

        public string Nombres { get; set; }

        public string Correo { get; set; }


        [ForeignKey("Rol")]
        public int IdRol { get; set; }        
        public RolesEntity Rol { get; set; }


    }
}
