using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conciliador.Datos.Infraestructura.Entidades
{
    public class EmpresaEntity: BaseEntity
    {
       
        public string NombreEmpresa { get; set; }
        public string CodigoEmpresa { get; set; }
        public string DireccionEmpresa { get; set; }
        
    }
}
