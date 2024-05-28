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

namespace TipoFuenteList.Controllers
{
    [ApiController]
    [AllowAnonymous]
    [Route("api/[controller]")]
    public class TipoFuenteController : ControllerBase
    {
        private readonly ILogger<TipoFuenteController> _logger;
        private readonly IHttpContextAccessor _contextAccessor;
        private readonly ITipoFuenteService _TipoFuenteService;

        public TipoFuenteController(ILogger<TipoFuenteController> logger, IHttpContextAccessor contextAccessor, ITipoFuenteService TipoFuenteService)
        {
            _logger = logger;
            _contextAccessor = contextAccessor;
            _TipoFuenteService = TipoFuenteService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var result = await _TipoFuenteService.GetAll();
            var response = new ServiceResponseDTO<List<TipoFuenteDto>>()
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
            var result = await _TipoFuenteService.GetById(id);
            var response = new ServiceResponseDTO<TipoFuenteDto>()
            {
                Data = result,
                Message = "ok",
                Success = true,
                CountRecords = result != null ? 1 : 0
            };

            return Ok(response);
        }

        [HttpPost]
        public async Task<IActionResult> Create(TipoFuenteDto TipoFuenteDto)
        {
            var result = await _TipoFuenteService.Add(TipoFuenteDto);
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
        public async Task<IActionResult> Update(Int32 id, TipoFuenteDto TipoFuenteDto)
        {
            var result = await _TipoFuenteService.Update(TipoFuenteDto);
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
            var result = await _TipoFuenteService.Delete(id);
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
