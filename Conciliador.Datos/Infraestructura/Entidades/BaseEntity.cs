using Conciliador.Modelos.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conciliador.Datos.Infraestructura.Entidades
{
    public class BaseEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string CreadoPor { get; set; }
        public string EditadoPor { get; set; }
        public string? EliminadoPor { get; set; }
        public EstadoRegistroEntity EstadoRegistro { get; set; }=EstadoRegistroEntity.Activo;
        public DateTime FechaCreacion { get; set; }
        public DateTime FechaEdicion { get; set; }
        public DateTime? FechaEliminacion { get; set; }
    }
}
