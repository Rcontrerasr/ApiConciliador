using System;
using System.ComponentModel.DataAnnotations;

namespace Conciliador.Modelos.DTOs
{
    public class ModuloDto
    {


        public int Id { get; set; }
        public string? Descripcion { get; set; }
        public string? Url { get; set; }
        public int? IdMenuPadre { get; set; }
        public ICollection<ModuloDto> InverseIdMenuPadreNavigation { get; set; } = new List<ModuloDto>();


    }
}
