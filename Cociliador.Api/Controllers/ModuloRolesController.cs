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

namespace ModuloRolesList.Controllers
{
    [ApiController]
    [AllowAnonymous]
    [Route("api/[controller]")]
    public class ModuloRolesController : ControllerBase
    {
        private readonly ILogger<ModuloRolesController> _logger;
        private readonly IHttpContextAccessor _contextAccessor;
        private readonly IModuloRolesService _ModuloRolesService;

        public ModuloRolesController(ILogger<ModuloRolesController> logger, IHttpContextAccessor contextAccessor, IModuloRolesService ModuloRolesService)
        {
            _logger = logger;
            _contextAccessor = contextAccessor;
            _ModuloRolesService = ModuloRolesService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var result = await _ModuloRolesService.GetAll();
            var response = new ServiceResponseDTO<List<ModuloRolesDto>>()
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
            var result = await _ModuloRolesService.GetById(id);
            var response = new ServiceResponseDTO<ModuloRolesDto>()
            {
                Data = result,
                Message = "ok",
                Success = true,
                CountRecords = result != null ? 1 : 0
            };

            return Ok(response);
        }

        [HttpPost]
        public async Task<IActionResult> Create(ModuloRolesDto ModuloRolesDto)
        {
            var result = await _ModuloRolesService.Add(ModuloRolesDto);
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
        public async Task<IActionResult> Update(Int32 id, ModuloRolesDto ModuloRolesDto)
        {
            var result = await _ModuloRolesService.Update(ModuloRolesDto);
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
            var result = await _ModuloRolesService.Delete(id);
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
