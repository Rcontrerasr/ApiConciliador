using System;

namespace Conciliador.Modelos.DTOs
{
    public class UsuarioDto
    {
        public int Id { get; set; }
        public string Identificacion { get; set; }
        public string Nombres { get; set; }
        public string Correo { get; set; }
        public int Rol { get; set; }
        public string Estado { get; set; }
        //public string UsuarioCreacionModificacion { get; set; }
    }
}
