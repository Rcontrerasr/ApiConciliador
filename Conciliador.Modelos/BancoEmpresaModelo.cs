using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Conciliador.Datos.Infraestructura.Modelos
{
    public class BancoEmpresaModelo
    {
        public int IdEmpresa { get; set; }
        public int IdBanco { get; set; }
        public string Cuenta { get; set; }
    }
}
