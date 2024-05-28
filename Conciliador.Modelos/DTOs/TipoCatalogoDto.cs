using System;

namespace Conciliador.Modelos.DTOs
{
    public class TipoCatalogoDto
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public bool Estado { get; set; }
    }
}
