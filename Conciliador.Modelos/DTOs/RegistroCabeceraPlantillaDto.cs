using System;

namespace Conciliador.Modelos.DTOs
{
    public class RegistroCabeceraPlantillaDto
    {
        public int Id { get; set; } 
        public DateTime Fecha { get; set; }
        public string CodigoReferencia { get; set; }
        public int IdPlanilla { get; set; } 
        public string CentroCostos { get; set; } 
        public DateTime Hora { get; set; }
    }
}
