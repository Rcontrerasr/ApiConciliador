using System;

namespace Conciliador.Modelos.DTOs
{
    public class CatalogoConversionModelo
    {
        public int Id { get; set; }
        public int IdTabla { get; set; }
        public string ConjuntoConversion { get; set; }
        public string CodigoConversion { get; set; }
        public string EquivalenciaConversion { get; set; }
        public string ConjuntoRelacionado { get; set; }
        public string ValorRelacionado { get; set; }
        public string Estado { get; set; }
        public DateTime FechaCreacion { get; set; }
        public DateTime FechaActualizacion { get; set; }
        public string UsuarioCreacionModificacion { get; set; }
    }
}
