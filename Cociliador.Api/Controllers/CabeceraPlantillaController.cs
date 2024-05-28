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

namespace CabeceraPlantillaList.Controllers
{
    [ApiController]
    [AllowAnonymous]
    [Route("api/[controller]")]
    public class CabeceraPlantillaController : ControllerBase
    {
        private readonly ILogger<CabeceraPlantillaController> _logger;
        private readonly IHttpContextAccessor _contextAccessor;
        private readonly ICabeceraPlantillaService _CabeceraPlantillaService;

        public CabeceraPlantillaController(ILogger<CabeceraPlantillaController> logger, IHttpContextAccessor contextAccessor, ICabeceraPlantillaService CabeceraPlantillaService)
        {
            _logger = logger;
            _contextAccessor = contextAccessor;
            _CabeceraPlantillaService = CabeceraPlantillaService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var result = await _CabeceraPlantillaService.GetAll();
            var response = new ServiceResponseDTO<List<CabeceraPlantillaDto>>()
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
            var result = await _CabeceraPlantillaService.GetById(id);
            var response = new ServiceResponseDTO<CabeceraPlantillaDto>()
            {
                Data = result,
                Message = "ok",
                Success = true,
                CountRecords = result != null ? 1 : 0
            };

            return Ok(response);
        }

        [HttpPost]
        public async Task<IActionResult> Create(CabeceraPlantillaDto CabeceraPlantillaDto)
        {
            var result = await _CabeceraPlantillaService.Add(CabeceraPlantillaDto);
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
        public async Task<IActionResult> Update(Int32 id, CabeceraPlantillaDto CabeceraPlantillaDto)
        {
            var result = await _CabeceraPlantillaService.Update(CabeceraPlantillaDto);
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
            var result = await _CabeceraPlantillaService.Delete(id);
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
