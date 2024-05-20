using System;
using System.ComponentModel.DataAnnotations;

namespace Conciliador.Modelos.DTOs
{
    public class ModuloRolesModel
    {
        public int IdTabla { get; set; }

        public string NombreRol { get; set; }

        public string Estado { get; set; }

        public DateTime FechaCreacion { get; set; }

        public DateTime FechaActualizacion { get; set; }

        public string UsuarioCreacionModificacion { get; set; }
    }
}
