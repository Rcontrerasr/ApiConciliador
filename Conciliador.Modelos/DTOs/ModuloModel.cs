using System;
using System.ComponentModel.DataAnnotations;

namespace Conciliador.Modelos.DTOs
{
    public class ModuloModel
    {
        public int IdTabla { get; set; }
        public string NombreModulo { get; set; }
        public string CodigoModulo { get; set; }
        public string DireccionModulo { get; set; }
        public string Estado { get; set; }
        public DateTime FechaCreacion { get; set; }
        public DateTime FechaActualizacion { get; set; }
        public string UsuarioCreacionModificacion { get; set; }
    }
}
