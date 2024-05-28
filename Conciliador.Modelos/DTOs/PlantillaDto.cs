using System;

namespace Conciliador.Modelos.DTOs
{
    public class PlantillaDto
    {
        public int Id { get; set; }
        public int IdTipoConciliacion { get; set; }
        public int IdEmpresa { get; set; }
        public int IdRoles { get; set; }
        public int IdTipoFuente { get; set; }
        public string NombrePlantilla { get; set; }
        public int InicioDetalles { get; set; }
        public bool Estado { get; set; }
    }
}
