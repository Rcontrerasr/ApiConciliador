using System;
using System.ComponentModel.DataAnnotations;

namespace Conciliador.Modelos.DTOs
{
    public class MenuDto
    {


        public int Id { get; set; }
        public string? Descripcion { get; set; }
        public string? Url { get; set; }
        public int? IdMenuPadre { get; set; }
        public ICollection<MenuDto> InverseIdMenuPadreNavigation { get; set; } = new List<MenuDto>();


    }
}
