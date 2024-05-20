using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conciliador.Datos.Infraestructura.Entidades
{
    public class ConversionCentrosCostoEntity:BaseEntity
    {
        public string CodigoConversion { get; set; }
        public string CentroCostoConversion { get; set; }
        public int BancoConversion { get; set; }

    } 
}
