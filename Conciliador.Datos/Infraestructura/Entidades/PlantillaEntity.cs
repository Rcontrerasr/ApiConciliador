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
        
        public string NombrePlantilla { get; set; }
        public int InicioDetalles { get; set; }
        public bool Estado { get; set; }


        [ForeignKey("Rol")]
        public int IdRol { get; set; }
        public RolesEntity Rol { get; set; }


        [ForeignKey("Empresa")]
        public int IdEmpresa { get; set; }
        public EmpresaEntity Empresa { get; set; }


        [ForeignKey("TipoConciliacion")]
        public int IdTipoConciliacion { get; set; }
        public TipoConciliacionEntity TipoConciliacion { get; set; }

        [ForeignKey("TipoFuente")]
        public int IdTipoFuente { get; set; }
        public TipoFuenteEntity TipoFuente { get; set; }






    }
}
