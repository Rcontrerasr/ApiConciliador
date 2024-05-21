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

namespace CatalogoNombreList.Controllers
{
    [ApiController]
    [AllowAnonymous]
    [Route("api/[controller]")]
    public class CatalogoNombreController : ControllerBase
    {
        private readonly ILogger<CatalogoNombreController> _logger;
        private readonly IHttpContextAccessor _contextAccessor;
        private readonly ICatalogoNombreService _CatalogoNombreService;

        public CatalogoNombreController(ILogger<CatalogoNombreController> logger, IHttpContextAccessor contextAccessor, ICatalogoNombreService CatalogoNombreService)
        {
            _logger = logger;
            _contextAccessor = contextAccessor;
            _CatalogoNombreService = CatalogoNombreService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var result = await _CatalogoNombreService.GetAll();
            var response = new ServiceResponseDTO<List<CatalogoNombreDto>>()
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
            var result = await _CatalogoNombreService.GetById(id);
            var response = new ServiceResponseDTO<CatalogoNombreDto>()
            {
                Data = result,
                Message = "ok",
                Success = true,
                CountRecords = result != null ? 1 : 0
            };

            return Ok(response);
        }

        [HttpPost]
        public async Task<IActionResult> Create(CatalogoNombreDto CatalogoNombreDto)
        {
            var result = await _CatalogoNombreService.Add(CatalogoNombreDto);
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
        public async Task<IActionResult> Update(Int32 id, CatalogoNombreDto CatalogoNombreDto)
        {
            var result = await _CatalogoNombreService.Update(CatalogoNombreDto);
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
            var result = await _CatalogoNombreService.Delete(id);
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
