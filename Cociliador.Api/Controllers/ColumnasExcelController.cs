using System;
using System.Collections.Generic;
using System.Linq;
using Conciliador.Datos.Infraestructura.Entidades;
using Conciliador.Logica.Servicios.Interfaces;
using Conciliador.Modelos.DTOs;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.Identity.Web.Resource;

namespace ColumnasExcelList.Controllers
{
    [ApiController]
    [AllowAnonymous]
    [Route("api/[controller]")]
    public class ColumnasExcelController : ControllerBase
    {
        private readonly ILogger<ColumnasExcelController> _logger;
        private readonly IHttpContextAccessor _contextAccessor;
        private readonly IColumnasExcelService _ColumnasExcelService;

        public ColumnasExcelController(ILogger<ColumnasExcelController> logger, IHttpContextAccessor contextAccessor, IColumnasExcelService ColumnasExcelService)
        {
            _logger = logger;
            _contextAccessor = contextAccessor;
            _ColumnasExcelService = ColumnasExcelService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var result = await _ColumnasExcelService.GetAll();
            var response = new ServiceResponseDTO<List<ColumnasExceloDto>>()
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
            var result = await _ColumnasExcelService.GetById(id);
            var response = new ServiceResponseDTO<ColumnasExceloDto>()
            {
                Data = result,
                Message = "ok",
                Success = true,
                CountRecords = result != null ? 1 : 0
            };

            return Ok(response);
        }

        [HttpPost]
        public async Task<IActionResult> Create(ColumnasExceloDto ColumnasExcelDto)
        {
            var result = await _ColumnasExcelService.Add(ColumnasExcelDto);
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
        public async Task<IActionResult> Update(Int32 id, ColumnasExceloDto ColumnasExcelDto)
        {
            var result = await _ColumnasExcelService.Update(ColumnasExcelDto);
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
            var result = await _ColumnasExcelService.Delete(id);
            var response = new ServiceResponseDTO<Boolean>()
            {
                Data = result,
                Message = "ok",
                Success = true,
                CountRecords = result ? 1 : 0
            };

            return Ok(response);
        }
    }


}
