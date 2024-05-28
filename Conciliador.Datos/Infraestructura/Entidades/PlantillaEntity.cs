using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conciliador.Datos.Infraestructura.Entidades
{
    public class PlantillaEntity:BaseEntity
    {

        public int Id { get; set; }
        public int IdTipoConciliacion { get; set; }
        public int IdEmpresa { get; set; }
        public int IdRoles { get; set; }
        public int IdTipoFuente { get; set; }
        public string NombrePlantilla { get; set; }
        public int InicioDetalles { get; set; }
        public bool Estado { get; set; }


    }
}
