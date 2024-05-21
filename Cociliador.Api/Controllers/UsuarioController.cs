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

namespace UsuarioList.Controllers
{
    [ApiController]
    [AllowAnonymous]
    [Route("api/[controller]")]
    public class UsuarioController : ControllerBase
    {
        private readonly ILogger<UsuarioController> _logger;
        private readonly IHttpContextAccessor _contextAccessor;
        private readonly IUsuarioService _UsuarioService;

        public UsuarioController(ILogger<UsuarioController> logger, IHttpContextAccessor contextAccessor, IUsuarioService UsuarioService)
        {
            _logger = logger;
            _contextAccessor = contextAccessor;
            _UsuarioService = UsuarioService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var result = await _UsuarioService.GetAll();
            var response = new ServiceResponseDTO<List<UsuarioDto>>()
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
            var result = await _UsuarioService.GetById(id);
            var response = new ServiceResponseDTO<UsuarioDto>()
            {
                Data = result,
                Message = "ok",
                Success = true,
                CountRecords = result != null ? 1 : 0
            };

            return Ok(response);
        }

        [HttpPost]
        public async Task<IActionResult> Create(UsuarioDto UsuarioDto)
        {
            var result = await _UsuarioService.Add(UsuarioDto);
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
        public async Task<IActionResult> Update(Int32 id, UsuarioDto UsuarioDto)
        {
            var result = await _UsuarioService.Update(UsuarioDto);
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
            var result = await _UsuarioService.Delete(id);
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
