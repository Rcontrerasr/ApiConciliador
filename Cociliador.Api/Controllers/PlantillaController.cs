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

namespace PlantillaList.Controllers
{
    [ApiController]
    [AllowAnonymous]
    [Route("api/[controller]")]
    public class PlantillaController : ControllerBase
    {
        private readonly ILogger<PlantillaController> _logger;
        private readonly IHttpContextAccessor _contextAccessor;
        private readonly IPlantillasService _PlantillaService;

        public PlantillaController(ILogger<PlantillaController> logger, IHttpContextAccessor contextAccessor, IPlantillasService PlantillaService)
        {
            _logger = logger;
            _contextAccessor = contextAccessor;
            _PlantillaService = PlantillaService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var result = await _PlantillaService.GetAll();
            var response = new ServiceResponseDTO<List<PlantillaDto>>()
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
            var result = await _PlantillaService.GetById(id);
            var response = new ServiceResponseDTO<PlantillaDto>()
            {
                Data = result,
                Message = "ok",
                Success = true,
                CountRecords = result != null ? 1 : 0
            };

            return Ok(response);
        }

        [HttpPost]
        public async Task<IActionResult> Create(PlantillaDto PlantillaDto)
        {
            var result = await _PlantillaService.Add(PlantillaDto);
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
        public async Task<IActionResult> Update(Int32 id, PlantillaDto PlantillaDto)
        {
            var result = await _PlantillaService.Update(PlantillaDto);
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
            var result = await _PlantillaService.Delete(id);
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
