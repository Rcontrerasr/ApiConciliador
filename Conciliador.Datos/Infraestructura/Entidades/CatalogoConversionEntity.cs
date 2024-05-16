using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conciliador.Datos.Infraestructura.Entidades
{
    public class CatalogoConversionEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
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
