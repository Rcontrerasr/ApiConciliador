using System;
using System.ComponentModel.DataAnnotations;

namespace Conciliador.Datos.Infraestructura.Modelos
{
    public class BancosModelo
    {
        public int IdTabla { get; set; }
        public string NombreBanco { get; set; }
        public string CodigoBanco { get; set; }
        public string Estado { get; set; }
        public DateTime FechaCreacion { get; set; }
        public DateTime FechaActualizacion { get; set; }
        public string UsuarioCreacionModificacion { get; set; }
    }
}
