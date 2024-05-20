using System;

namespace Conciliador.Modelos.DTOs
{
    public class CatalogoNombreModelo
    {
        public int Id { get; set; }
        public int IdTabla { get; set; }
        public string Codigo { get; set; }
        public string Descripcion { get; set; }
        public DateTime FechaCreacion { get; set; }
        public DateTime FechaActualizacion { get; set; }
        public string UsuarioCreacionModificacion { get; set; }
    }
}
