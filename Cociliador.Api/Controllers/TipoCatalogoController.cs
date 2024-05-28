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

namespace TipoCatalogoList.Controllers
{
    [ApiController]
    [AllowAnonymous]
    [Route("api/[controller]")]
    public class TipoCatalogoController : ControllerBase
    {
        private readonly ILogger<TipoCatalogoController> _logger;
        private readonly IHttpContextAccessor _contextAccessor;
        private readonly ITipoCatalogoService _TipoCatalogoService;

        public TipoCatalogoController(ILogger<TipoCatalogoController> logger, IHttpContextAccessor contextAccessor, ITipoCatalogoService TipoCatalogoService)
        {
            _logger = logger;
            _contextAccessor = contextAccessor;
            _TipoCatalogoService = TipoCatalogoService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var result = await _TipoCatalogoService.GetAll();
            var response = new ServiceResponseDTO<List<TipoCatalogoDto>>()
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
            var result = await _TipoCatalogoService.GetById(id);
            var response = new ServiceResponseDTO<TipoCatalogoDto>()
            {
                Data = result,
                Message = "ok",
                Success = true,
                CountRecords = result != null ? 1 : 0
            };

            return Ok(response);
        }

        [HttpPost]
        public async Task<IActionResult> Create(TipoCatalogoDto TipoCatalogoDto)
        {
            var result = await _TipoCatalogoService.Add(TipoCatalogoDto);
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
        public async Task<IActionResult> Update(Int32 id, TipoCatalogoDto TipoCatalogoDto)
        {
            var result = await _TipoCatalogoService.Update(TipoCatalogoDto);
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
            var result = await _TipoCatalogoService.Delete(id);
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
