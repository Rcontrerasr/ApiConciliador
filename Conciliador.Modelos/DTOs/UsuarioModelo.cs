using System;

namespace Conciliador.Modelos.DTOs
{
    public class UsuarioModelo
    {
        public int Id { get; set; }
        public string Identificacion { get; set; }
        public string Nombres { get; set; }
        public string Correo { get; set; }
        public int Rol { get; set; }
        public string Estado { get; set; }
        public DateTime UltimaConexion { get; set; }
        public DateTime FechaCreacion { get; set; }
        public DateTime FechaActualizacion { get; set; }
        public string UsuarioCreacionModificacion { get; set; }
    }
}
