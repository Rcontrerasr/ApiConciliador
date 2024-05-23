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
    public partial class MenuEntity:BaseEntity
    {
        public MenuEntity()
        {
            InverseIdMenuPadreNavigation = new HashSet<MenuEntity>();
        }

        public string? Descripcion { get; set; }
        public string? Url { get; set; }

        [ForeignKey("IdMenuPadreNavigation")]
        public int? IdMenuPadre { get; set; }

        public virtual MenuEntity? IdMenuPadreNavigation { get; set; }
        public virtual ICollection<MenuEntity> InverseIdMenuPadreNavigation { get; set; }
    }
}
