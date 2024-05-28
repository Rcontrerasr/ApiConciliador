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

namespace RegistroCabeceraPlantillaList.Controllers
{
    [ApiController]
    [AllowAnonymous]
    [Route("api/[controller]")]
    public class RegistroCabeceraPlantillaController : ControllerBase
    {
        private readonly ILogger<RegistroCabeceraPlantillaController> _logger;
        private readonly IHttpContextAccessor _contextAccessor;
        private readonly IRegistroCabeceraPlantillaService _RegistroCabeceraPlantillaService;

        public RegistroCabeceraPlantillaController(ILogger<RegistroCabeceraPlantillaController> logger, IHttpContextAccessor contextAccessor, IRegistroCabeceraPlantillaService RegistroCabeceraPlantillaService)
        {
            _logger = logger;
            _contextAccessor = contextAccessor;
            _RegistroCabeceraPlantillaService = RegistroCabeceraPlantillaService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var result = await _RegistroCabeceraPlantillaService.GetAll();
            var response = new ServiceResponseDTO<List<RegistroCabeceraPlantillaDto>>()
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
            var result = await _RegistroCabeceraPlantillaService.GetById(id);
            var response = new ServiceResponseDTO<RegistroCabeceraPlantillaDto>()
            {
                Data = result,
                Message = "ok",
                Success = true,
                CountRecords = result != null ? 1 : 0
            };

            return Ok(response);
        }

        [HttpPost]
        public async Task<IActionResult> Create(RegistroCabeceraPlantillaDto RegistroCabeceraPlantillaDto)
        {
            var result = await _RegistroCabeceraPlantillaService.Add(RegistroCabeceraPlantillaDto);
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
        public async Task<IActionResult> Update(Int32 id, RegistroCabeceraPlantillaDto RegistroCabeceraPlantillaDto)
        {
            var result = await _RegistroCabeceraPlantillaService.Update(RegistroCabeceraPlantillaDto);
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
            var result = await _RegistroCabeceraPlantillaService.Delete(id);
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
