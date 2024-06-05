using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conciliador.Datos.Infraestructura.Entidades
{
    public class CabeceraPlantillaEntity : BaseEntity
    {

        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public bool Estado { get; set; }

        [ForeignKey("Plantilla")]
        public int IdPlantilla { get; set; }
        public PlantillaEntity Plantilla { get; set; }

        [ForeignKey("CatalogoGeneral")]
        public int IdCatalogoGeneral { get; set; }
        public CatalogoGeneralEntity CatalogoGeneral { get; set; }
    }
}
