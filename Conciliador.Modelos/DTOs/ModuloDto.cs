using System;
using System.ComponentModel.DataAnnotations;

namespace Conciliador.Modelos.DTOs
{
    public class ModuloDto
    {
        public Int32 Id { get; set; }
        public string NombreModulo { get; set; }
        public string CodigoModulo { get; set; }
        public string DireccionModulo { get; set; }
        public string Estado { get; set; }
    
    }
}
