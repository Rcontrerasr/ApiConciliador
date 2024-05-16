using System;

namespace Conciliador.Datos.Infraestructura.Modelos
{
    public class RolesModelo
    {
        public int IdTabla { get; set; }
        public string NombreRol { get; set; }
        public string Estado { get; set; }
        public DateTime FechaCreacion { get; set; }
        public DateTime FechaActualizacion { get; set; }
        public string UsuarioCreacionModificacion { get; set; }
    }
}
