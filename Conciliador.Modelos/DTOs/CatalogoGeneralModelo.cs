using System;

namespace Conciliador.Modelos.DTOs
{
    public class CatalogoGeneralModelo
    {
        public int Id { get; set; }
        public int IdTabla { get; set; }
        public string TipoCatalogoGeneral { get; set; }
        public string Codigo { get; set; }
        public string Descripcion { get; set; }
        public int Orden { get; set; }
        public DateTime FechaCreacion { get; set; }
        public string UsuarioCreacionModificacion { get; set; }
    }
}
