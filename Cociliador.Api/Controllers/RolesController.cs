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

namespace RolesList.Controllers
{
    [ApiController]
    [AllowAnonymous]
    [Route("api/[controller]")]
    public class RolesController : ControllerBase
    {
        private readonly ILogger<RolesController> _logger;
        private readonly IHttpContextAccessor _contextAccessor;
        private readonly IRolesService _RolesService;

        public RolesController(ILogger<RolesController> logger, IHttpContextAccessor contextAccessor, IRolesService RolesService)
        {
            _logger = logger;
            _contextAccessor = contextAccessor;
            _RolesService = RolesService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var result = await _RolesService.GetAll();
            var response = new ServiceResponseDTO<List<RolesDto>>()
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
            var result = await _RolesService.GetById(id);
            var response = new ServiceResponseDTO<RolesDto>()
            {
                Data = result,
                Message = "ok",
                Success = true,
                CountRecords = result!=null?1:0
            };

            return Ok(response);
        }

        [HttpPost]
        public async Task<IActionResult> Create(RolesDto RolesDto)
        {
            var result = await _RolesService.Add(RolesDto);
            var response = new ServiceResponseDTO<Boolean>()
            {
                Data = result,
                Message = "ok",
                Success = true,
                CountRecords = result ?1:0
            };

            return Ok(response);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(Int32 id, RolesDto RolesDto)
        {
            var result = await _RolesService.Update(RolesDto);
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
            var result = await _RolesService.Delete(id);
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
