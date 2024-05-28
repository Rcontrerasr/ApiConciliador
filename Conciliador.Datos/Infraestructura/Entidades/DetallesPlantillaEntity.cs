using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conciliador.Datos.Infraestructura.Entidades
{
    public class DetallesPlantillaEntity:BaseEntity
    {

        public int Id { get; set; }
        public int IdPlanilla { get; set; }
        public string Anombre { get; set; }
        public string TipoCampo { get; set; }
        public string Columna { get; set; }
        public bool EsCatalogo { get; set; }
        public string NombreCatalogo { get; set; }
        public int? IdCatalogoGeneral { get; set; }
        public int? ValorCatalogo { get; set; }
        public bool EsObligatorio { get; set; }
        public string TipoOperacion { get; set; }
        public string Operacion { get; set; }


    }
}
