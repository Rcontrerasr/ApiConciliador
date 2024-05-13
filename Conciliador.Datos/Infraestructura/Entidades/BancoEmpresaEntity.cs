using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conciliador.Datos.Infraestructura.Entidades
{
    public class BancoEmpresaEntity
    {
        [Key]
        [Column(Order = 1)]
        [ForeignKey("Empresa")]
        public int IdEmpresa { get; set; }

        [Key]
        [Column(Order = 2)]
        [ForeignKey("Bancos")]
        public int IdBanco { get; set; }

        public string Cuenta { get; set; }

    }
}
