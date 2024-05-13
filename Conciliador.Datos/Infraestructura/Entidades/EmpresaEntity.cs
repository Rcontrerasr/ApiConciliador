using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conciliador.Datos.Infraestructura.Entidades
{
    public class EmpresaEntity
    {
        [Key]
        public int IdTabla { get; set; }
        public string NombreEmpresa { get; set; }
        public string CodigoEmpresa { get; set; }
        public string DireccionEmpresa { get; set; }
        public string Estado { get; set; }
        public DateTime FechaCreacion { get; set; }
        public DateTime FechaActualizacion { get; set; }
        public string UsuarioCreacionModificacion { get; set; }
    }
}
