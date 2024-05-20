using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conciliador.Datos.Infraestructura.Entidades
{
    public class CatalogoConversionEntity: BaseEntity
    {
        
        
        public string ConjuntoConversion { get; set; }
        public string CodigoConversion { get; set; }
        public string EquivalenciaConversion { get; set; }
        public string ConjuntoRelacionado { get; set; }
        public string ValorRelacionado { get; set; }
    }
}
