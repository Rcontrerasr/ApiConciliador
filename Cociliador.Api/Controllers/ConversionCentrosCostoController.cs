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

namespace ConversionCentrosCostoList.Controllers
{
    [ApiController]
    [AllowAnonymous]
    [Route("api/[controller]")]
    public class ConversionCentrosCostoController : ControllerBase
    {
        private readonly ILogger<ConversionCentrosCostoController> _logger;
        private readonly IHttpContextAccessor _contextAccessor;
        private readonly IConversionCentrosCostoService _ConversionCentrosCostoService;

        public ConversionCentrosCostoController(ILogger<ConversionCentrosCostoController> logger, IHttpContextAccessor contextAccessor, IConversionCentrosCostoService ConversionCentrosCostoService)
        {
            _logger = logger;
            _contextAccessor = contextAccessor;
            _ConversionCentrosCostoService = ConversionCentrosCostoService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var result = await _ConversionCentrosCostoService.GetAll();
            var response = new ServiceResponseDTO<List<ConversionCentrosCostoDto>>()
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
            var result = await _ConversionCentrosCostoService.GetById(id);
            var response = new ServiceResponseDTO<ConversionCentrosCostoDto>()
            {
                Data = result,
                Message = "ok",
                Success = true,
                CountRecords = result != null ? 1 : 0
            };

            return Ok(response);
        }

        [HttpPost]
        public async Task<IActionResult> Create(ConversionCentrosCostoDto ConversionCentrosCostoDto)
        {
            var result = await _ConversionCentrosCostoService.Add(ConversionCentrosCostoDto);
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
        public async Task<IActionResult> Update(Int32 id, ConversionCentrosCostoDto ConversionCentrosCostoDto)
        {
            var result = await _ConversionCentrosCostoService.Update(ConversionCentrosCostoDto);
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
            var result = await _ConversionCentrosCostoService.Delete(id);
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
