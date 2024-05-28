using System;

namespace Conciliador.Modelos.DTOs
{
    public class CatalogoGeneralDto
    {
        public Int32 Id { get; set; }
        public string TipoCatalogoGeneral { get; set; }
        public string Codigo { get; set; }
        public string Descripcion { get; set; }
        public int Orden { get; set; }
  
    }
}
