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
            //mapea desde el Entity hacia el Dto y viceversa
            CreateMap<RolesEntity, RolesDto>().ReverseMap();
            CreateMap<UsuarioEntity, UsuarioDto>().ReverseMap();
            CreateMap<ModuloEntity, ModuloDto>().ReverseMap();
            CreateMap<ModuloRolesEntity, ModuloRolesDto>().ReverseMap();
            CreateMap<EmpresaEntity, EmpresaDto>().ReverseMap();
            CreateMap<CatalogoConversionEntity, CatalogoConversionDto>().ReverseMap();
            CreateMap<CatalogoGeneralEntity, CatalogoGeneralDto>().ReverseMap();
            CreateMap<CatalogoNombreEntity, CatalogoNombreDto>().ReverseMap();
            CreateMap<ConversionCentrosCostoEntity, ConversionCentrosCostoDto>().ReverseMap();
            CreateMap<MenuEntity, MenuDto>().ReverseMap();


            CreateMap<TipoConciliacionEntity, TipoConciliacionDto>().ReverseMap();
            CreateMap<TipoFuenteEntity, TipoFuenteDto>().ReverseMap();
            CreateMap<TipoCatalogoEntity, TipoCatalogoDto>().ReverseMap();
            CreateMap<PlantillaEntity, PlantillaDto>().ReverseMap();
            CreateMap<ColumnasExcelEntity, ColumnasExceloDto>().ReverseMap();
            CreateMap<CabeceraPlantillaEntity, CabeceraPlantillaDto>().ReverseMap();
            CreateMap<RegistroCabeceraPlantillaEntity, RegistroCabeceraPlantillaDto>().ReverseMap();
            CreateMap<DetallesPlantillaEntity, DetallesPlantillaDto>().ReverseMap();
            CreateMap<RegistroDetallePlantillaEntity, RegistroDetallePlantillaDto>().ReverseMap();
            
        }
    
    }
}
