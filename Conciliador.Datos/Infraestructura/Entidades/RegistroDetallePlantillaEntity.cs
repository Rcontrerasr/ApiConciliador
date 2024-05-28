using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conciliador.Datos.Infraestructura.Entidades
{
    public class RegistroDetallePlantillaEntity:BaseEntity
    {

        public int Id { get; set; }
        public int IdRegistroCabeceraPlantilla { get; set; }
        public int IdDetallePlantilla { get; set; }
        public int IdCabeceraPlantilla { get; set; }
        public string ValorCampo { get; set; }


    }
}
