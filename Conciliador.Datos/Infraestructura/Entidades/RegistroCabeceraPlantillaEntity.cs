﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conciliador.Datos.Infraestructura.Entidades
{
    public class RegistroCabeceraPlantillaEntity:BaseEntity
    {

        public int Id { get; set; }
        public DateTime Fecha { get; set; }
        public string CodigoReferencia { get; set; }
      
        public string CentroCostos { get; set; }
        public DateTime Hora { get; set; }



        [ForeignKey("Plantilla")]
        public int IdPlantilla { get; set; }
        public PlantillaEntity Plantilla { get; set; }
    }
}
