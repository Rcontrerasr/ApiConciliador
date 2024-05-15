using System;
using System.ComponentModel.DataAnnotations;

namespace Conciliador.Datos.Infraestructura.Modelos
{
    public class ConversionCentrosCostoModelo
    {
        public int IdTabla { get; set; }
        public string CodigoConversion { get; set; }
        public string CentroCostoConversion { get; set; }
        public int BancoConversion { get; set; }
        public string Estado { get; set; }
        public DateTime FechaCreacion { get; set; }
        public DateTime FechaActualizacion { get; set; }
        public string UsuarioCreacionModificacion { get; set; }
    }
}
