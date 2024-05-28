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

namespace TipoConciliacionList.Controllers
{
    [ApiController]
    [AllowAnonymous]
    [Route("api/[controller]")]
    public class TipoConciliacionController : ControllerBase
    {
        private readonly ILogger<TipoConciliacionController> _logger;
        private readonly IHttpContextAccessor _contextAccessor;
        private readonly ITipoConciliacionService _TipoConciliacionService;

        public TipoConciliacionController(ILogger<TipoConciliacionController> logger, IHttpContextAccessor contextAccessor, ITipoConciliacionService TipoConciliacionService)
        {
            _logger = logger;
            _contextAccessor = contextAccessor;
            _TipoConciliacionService = TipoConciliacionService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var result = await _TipoConciliacionService.GetAll();
            var response = new ServiceResponseDTO<List<TipoConciliacionDto>>()
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
            var result = await _TipoConciliacionService.GetById(id);
            var response = new ServiceResponseDTO<TipoConciliacionDto>()
            {
                Data = result,
                Message = "ok",
                Success = true,
                CountRecords = result != null ? 1 : 0
            };

            return Ok(response);
        }

        [HttpPost]
        public async Task<IActionResult> Create(TipoConciliacionDto TipoConciliacionDto)
        {
            var result = await _TipoConciliacionService.Add(TipoConciliacionDto);
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
        public async Task<IActionResult> Update(Int32 id, TipoConciliacionDto TipoConciliacionDto)
        {
            var result = await _TipoConciliacionService.Update(TipoConciliacionDto);
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
            var result = await _TipoConciliacionService.Delete(id);
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
