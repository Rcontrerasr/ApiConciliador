using System;
using System.ComponentModel.DataAnnotations;

namespace Conciliador.Datos.Infraestructura.Modelos
{
    public class EmpresaModelo
    {
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
