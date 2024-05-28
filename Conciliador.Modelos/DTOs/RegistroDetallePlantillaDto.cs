using System;

namespace Conciliador.Modelos.DTOs
{
    public class RegistroDetallePlantillaDto
    {
        public int Id { get; set; }
        public int IdRegistroCabeceraPlantilla { get; set; }
        public int IdDetallePlantilla { get; set; }
        public int IdCabeceraPlantilla { get; set; }
        public string ValorCampo { get; set; }
    }
}
