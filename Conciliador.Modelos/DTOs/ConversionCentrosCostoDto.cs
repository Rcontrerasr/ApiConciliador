using System;
using System.ComponentModel.DataAnnotations;

namespace Conciliador.Modelos.DTOs
{
    public class ConversionCentrosCostoDto
    {
        public Int32 Id { get; set; }
        public string CodigoConversion { get; set; }
        public string CentroCostoConversion { get; set; }
        public int BancoConversion { get; set; }
        public string Estado { get; set; }
    }
}
