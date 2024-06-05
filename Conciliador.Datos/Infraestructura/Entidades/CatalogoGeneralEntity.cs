using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conciliador.Datos.Infraestructura.Entidades
{
    public class CatalogoGeneralEntity: BaseEntity
    {
       
        public string Codigo { get; set; }
        public string Descripcion { get; set; }
        public int Orden { get; set; }


        [ForeignKey("TipoCatalogo")]
        public int IdTipoCatalogo { get; set; }
        public TipoCatalogoEntity TipoCatalogo { get; set; }
    }
}
