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

namespace DetallesPlantillaList.Controllers
{
    [ApiController]
    [AllowAnonymous]
    [Route("api/[controller]")]
    public class DetallesPlantillaController : ControllerBase
    {
        private readonly ILogger<DetallesPlantillaController> _logger;
        private readonly IHttpContextAccessor _contextAccessor;
        private readonly IDetallesPlantillasService _DetallesPlantillaService;

        public DetallesPlantillaController(ILogger<DetallesPlantillaController> logger, IHttpContextAccessor contextAccessor, IDetallesPlantillasService DetallesPlantillaService)
        {
            _logger = logger;
            _contextAccessor = contextAccessor;
            _DetallesPlantillaService = DetallesPlantillaService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var result = await _DetallesPlantillaService.GetAll();
            var response = new ServiceResponseDTO<List<DetallesPlantillaDto>>()
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
            var result = await _DetallesPlantillaService.GetById(id);
            var response = new ServiceResponseDTO<DetallesPlantillaDto>()
            {
                Data = result,
                Message = "ok",
                Success = true,
                CountRecords = result != null ? 1 : 0
            };

            return Ok(response);
        }

        [HttpPost]
        public async Task<IActionResult> Create(DetallesPlantillaDto DetallesPlantillaDto)
        {
            var result = await _DetallesPlantillaService.Add(DetallesPlantillaDto);
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
        public async Task<IActionResult> Update(Int32 id, DetallesPlantillaDto DetallesPlantillaDto)
        {
            var result = await _DetallesPlantillaService.Update(DetallesPlantillaDto);
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
            var result = await _DetallesPlantillaService.Delete(id);
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
