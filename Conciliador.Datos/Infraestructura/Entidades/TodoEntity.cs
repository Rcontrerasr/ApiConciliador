using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conciliador.Datos.Infraestructura.Entidades
{
    public class TodoEntity
    {
        [Key]
        public Guid Id { get; set; }
        public string Task { get; set; }
        public bool Status { get; set; }
    }
}
