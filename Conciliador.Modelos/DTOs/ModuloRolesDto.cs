﻿using System;
using System.ComponentModel.DataAnnotations;

namespace Conciliador.Modelos.DTOs
{
    public class ModuloRolesDto
    {
        public Int32 Id { get; set; }
        public string NombreRol { get; set; }

        public string Estado { get; set; }

    }
}
