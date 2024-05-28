using System;

namespace Conciliador.Modelos.DTOs
{
    public class ColumnasExceloDto
    {
        public int Id { get; set; } 
        public int IdPlantilla { get; set; } 
        public string NombreColumna { get; set; } 
        public bool Estado { get; set; } 
    }
}
