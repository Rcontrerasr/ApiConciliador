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

namespace RegistroDetallePlantillaList.Controllers
{
    [ApiController]
    [AllowAnonymous]
    [Route("api/[controller]")]
    public class RegistroDetallePlantillaController : ControllerBase
    {
        private readonly ILogger<RegistroDetallePlantillaController> _logger;
        private readonly IHttpContextAccessor _contextAccessor;
        private readonly IRegistroDetallePlantillaService _RegistroDetallePlantillaService;

        public RegistroDetallePlantillaController(ILogger<RegistroDetallePlantillaController> logger, IHttpContextAccessor contextAccessor, IRegistroDetallePlantillaService RegistroDetallePlantillaService)
        {
            _logger = logger;
            _contextAccessor = contextAccessor;
            _RegistroDetallePlantillaService = RegistroDetallePlantillaService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var result = await _RegistroDetallePlantillaService.GetAll();
            var response = new ServiceResponseDTO<List<RegistroDetallePlantillaDto>>()
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
            var result = await _RegistroDetallePlantillaService.GetById(id);
            var response = new ServiceResponseDTO<RegistroDetallePlantillaDto>()
            {
                Data = result,
                Message = "ok",
                Success = true,
                CountRecords = result != null ? 1 : 0
            };

            return Ok(response);
        }

        [HttpPost]
        public async Task<IActionResult> Create(RegistroDetallePlantillaDto RegistroDetallePlantillaDto)
        {
            var result = await _RegistroDetallePlantillaService.Add(RegistroDetallePlantillaDto);
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
        public async Task<IActionResult> Update(Int32 id, RegistroDetallePlantillaDto RegistroDetallePlantillaDto)
        {
            var result = await _RegistroDetallePlantillaService.Update(RegistroDetallePlantillaDto);
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
            var result = await _RegistroDetallePlantillaService.Delete(id);
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
