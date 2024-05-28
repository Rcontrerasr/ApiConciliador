using System;
using System.ComponentModel.DataAnnotations;

namespace Conciliador.Modelos.DTOs
{
    public class EmpresaDto
    {
        public Int32 Id { get; set; }
        public string NombreEmpresa { get; set; }
        public string CodigoEmpresa { get; set; }
        public string DireccionEmpresa { get; set; }
        public string Estado { get; set; }     


    }
}
