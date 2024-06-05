using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conciliador.Datos.Infraestructura.Entidades
{
    public class RegistroDetallePlantillaEntity : BaseEntity
    {

        public int Id { get; set; }
        public string ValorCampo { get; set; }


        [ForeignKey("RegistroCabeceraPlantilla")]
        public int IdRegistroCabeceraPlantilla { get; set; }
        public RegistroCabeceraPlantillaEntity RegistroCabeceraPlantilla { get; set; }


        [ForeignKey("CabeceraPlantilla")]
        public int IdCabeceraPlantilla { get; set; }
        public CabeceraPlantillaEntity CabeceraPlantilla { get; set; }


        [ForeignKey("DetallesPlantilla")]
        public int IdDetallePlantilla { get; set; }
        public DetallesPlantillaEntity DetallesPlantilla { get; set; }

    }
}
