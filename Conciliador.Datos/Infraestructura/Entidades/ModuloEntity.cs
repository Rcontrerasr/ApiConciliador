using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using System.Collections.Generic;

namespace Conciliador.Datos.Infraestructura.Entidades
{
    public partial class ModuloEntity:BaseEntity
    {
        public ModuloEntity()
        {
            InverseIdModuloPadreNavigation = new HashSet<ModuloEntity>();
        }

        public string? Descripcion { get; set; }
        public string? Url { get; set; }

        [ForeignKey("IdModuloPadreNavigation")]
        public int? IdModuloPadre { get; set; }

        public virtual ModuloEntity? IdModuloPadreNavigation { get; set; }
        public virtual ICollection<ModuloEntity> InverseIdModuloPadreNavigation { get; set; }
    }
}
