using AutoMapper;
using Conciliador.Datos.Infraestructura.Entidades;
using Conciliador.Modelos.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conciliador.Logica.Utils
{
    public class AutoMapperProfiles : Profile
    {
        //https://medium.com/@supino0017/automapper-for-object-mapping-in-net-8-5b20a034de8c
        public AutoMapperProfiles()
        {
            CreateMap<RolesEntity, RolesDto>().ReverseMap();//mapea desde RolesEntity hacia RolesDto y viceversa
            CreateMap<UsuarioEntity, UsuarioDto>().ReverseMap();//mapea desde RolesEntity hacia RolesDto y viceversa
        }
    
    }
}
