using System;

namespace Conciliador.Modelos.DTOs
{
    public class CatalogoConversionDto
    {
        public Int32 Id { get; set; }
        public string ConjuntoConversion { get; set; }
        public string CodigoConversion { get; set; }
        public string EquivalenciaConversion { get; set; }
        public string ConjuntoRelacionado { get; set; }
        public string ValorRelacionado { get; set; }
        public string Estado { get; set; }
  
    }
}
