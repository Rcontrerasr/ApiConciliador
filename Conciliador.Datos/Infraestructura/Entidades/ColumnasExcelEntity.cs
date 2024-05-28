using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conciliador.Datos.Infraestructura.Entidades
{
    public class ColumnasExcelEntity:BaseEntity
    {

        public int Id { get; set; }
        public int IdPlantilla { get; set; }
        public string NombreColumna { get; set; }
        public bool Estado { get; set; }

    }
}
