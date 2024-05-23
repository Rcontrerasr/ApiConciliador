using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using ClosedXML.Excel;
using Conciliador.Datos.Infraestructura.Entidades;
using Conciliador.Logica.Servicios.Interfaces;
using Conciliador.Modelos.DTOs;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.Identity.Web.Resource;

namespace CatalogoConversionList.Controllers
{
    [ApiController]
    [AllowAnonymous]
    [Route("api/[controller]")]
    public class CatalogoConversionController : ControllerBase
    {
        private readonly ILogger<CatalogoConversionController> _logger;
        private readonly IHttpContextAccessor _contextAccessor;
        private readonly ICatalogoConversionService _CatalogoConversionService;

        public CatalogoConversionController(ILogger<CatalogoConversionController> logger, IHttpContextAccessor contextAccessor, ICatalogoConversionService CatalogoConversionService)
        {
            _logger = logger;
            _contextAccessor = contextAccessor;
            _CatalogoConversionService = CatalogoConversionService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var result = await _CatalogoConversionService.GetAll();
            var response = new ServiceResponseDTO<List<CatalogoConversionDto>>()
            {
                Data = result,
                Message = "ok",
                Success = true,
                CountRecords = result.Count
            };

            return Ok(response);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(Int32 id)
        {
            var result = await _CatalogoConversionService.GetById(id);
            var response = new ServiceResponseDTO<CatalogoConversionDto>()
            {
                Data = result,
                Message = "ok",
                Success = true,
                CountRecords = result != null ? 1 : 0
            };

            return Ok(response);
        }

        [HttpPost]
        public async Task<IActionResult> Create(CatalogoConversionDto CatalogoConversionDto)
        {
            var result = await _CatalogoConversionService.Add(CatalogoConversionDto);
            var response = new ServiceResponseDTO<Boolean>()
            {
                Data = result,
                Message = "ok",
                Success = true,
                CountRecords = result ? 1 : 0
            };

            return Ok(response);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(Int32 id, CatalogoConversionDto CatalogoConversionDto)
        {
            var result = await _CatalogoConversionService.Update(CatalogoConversionDto);
            var response = new ServiceResponseDTO<Boolean>()
            {
                Data = result,
                Message = "ok",
                Success = true,
                CountRecords = result ? 1 : 0
            };

            return Ok(response);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Int32 id)
        {
            var result = await _CatalogoConversionService.Delete(id);
            var response = new ServiceResponseDTO<Boolean>()
            {
                Data = result,
                Message = "ok",
                Success = true,
                CountRecords = result ? 1 : 0
            };

            return Ok(response);
        }


        [HttpGet]
        [Route("exporta-excel")]
        public async Task<FileResult> ExportarCatalogoConversionAExcel()
        {
            var CatalogoConversion = await _CatalogoConversionService.GetAll();
            var nombreArchivo = "CatalogoConversion.xlsx";
            return GenerarExcel(nombreArchivo, CatalogoConversion);
        }


        [HttpPost]
        [Route("importa-excel")]
        public async Task<IActionResult> ImportarCatalogoConversionDesdeExcel(IFormFile file)
        {
            if (file == null || file.Length == 0)
                return BadRequest("El archivo está vacío o no se ha proporcionado.");

            using (var stream = new MemoryStream())
            {
                await file.CopyToAsync(stream);

                using (var workbook = new XLWorkbook(stream))
                {
                    var worksheet = workbook.Worksheets.FirstOrDefault();
                    if (worksheet == null)
                        return BadRequest("No se encontró ninguna hoja en el archivo Excel.");

                    var catalogoConversionList = new List<CatalogoConversionDto>();

                    foreach (var row in worksheet.RowsUsed().Skip(1)) // Omite la fila de encabezado
                    {
                        var catalogoConversion = new CatalogoConversionDto
                        {
                            Id = 0,//row.Cell(1).GetValue<int>(),
                            ConjuntoConversion = row.Cell(2).GetValue<string>(),
                            CodigoConversion = row.Cell(3).GetValue<string>(),
                            EquivalenciaConversion = row.Cell(4).GetValue<string>(),
                            ConjuntoRelacionado = row.Cell(5).GetValue<string>(),
                            Estado = row.Cell(6).GetValue<string>(),
                            ValorRelacionado = row.Cell(7).GetValue<string>(),
                        };

                        catalogoConversionList.Add(catalogoConversion);
                    }

                    foreach (var item in catalogoConversionList)
                    {


                        await _CatalogoConversionService.Add(item);
                    }

                }
            }

            return Ok("Archivo importado y datos guardados exitosamente.");
        }
        private FileResult GenerarExcel(string nombreArchivo, List<CatalogoConversionDto> CatalogoConversion)
        {
            DataTable dataTable = new DataTable(" CatalogoConversion");
            dataTable.Columns.AddRange(new DataColumn[]
            {
                new DataColumn("Id"),
                new DataColumn("ConjuntoConversion"),
                new DataColumn("CodigoConversion"),
                new DataColumn("EquivalenciaConversion"),
                new DataColumn("ConjuntoRelacionado"),
                new DataColumn("Estado"),
                new DataColumn("ValorRelacionado"),
           

            });

            foreach (var item in CatalogoConversion)
            {
                dataTable.Rows.Add(item.Id,item.ConjuntoConversion, item.CodigoConversion,
                    item.EquivalenciaConversion,item.ConjuntoRelacionado,item.Estado,item.ValorRelacionado);
            }


            using (XLWorkbook wb = new XLWorkbook())
            {
                wb.Worksheets.Add(dataTable);

                using (MemoryStream stream = new MemoryStream())
                {
                    wb.SaveAs(stream);
                    return File(stream.ToArray(),
                        "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet",
                        nombreArchivo);
                }
            }


        }

    }


}
