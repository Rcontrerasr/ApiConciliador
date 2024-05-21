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

namespace CatalogoConversionList.Controllers
{
    [ApiController]
    [AllowAnonymous]
    [Route("api/[controller]")]
    public class CatalogoConversionController : ControllerBase
    {
        private readonly ILogger<CatalogoConversionController> _logger;
        private readonly IHttpContextAccessor _contextAccessor;
        private readonly ICatalogoConversionService _CatalogoConversionService;

        public CatalogoConversionController(ILogger<CatalogoConversionController> logger, IHttpContextAccessor contextAccessor, ICatalogoConversionService CatalogoConversionService)
        {
            _logger = logger;
            _contextAccessor = contextAccessor;
            _CatalogoConversionService = CatalogoConversionService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var result = await _CatalogoConversionService.GetAll();
            var response = new ServiceResponseDTO<List<CatalogoConversionDto>>()
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
            var result = await _CatalogoConversionService.GetById(id);
            var response = new ServiceResponseDTO<CatalogoConversionDto>()
            {
                Data = result,
                Message = "ok",
                Success = true,
                CountRecords = result != null ? 1 : 0
            };

            return Ok(response);
        }

        [HttpPost]
        public async Task<IActionResult> Create(CatalogoConversionDto CatalogoConversionDto)
        {
            var result = await _CatalogoConversionService.Add(CatalogoConversionDto);
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
        public async Task<IActionResult> Update(Int32 id, CatalogoConversionDto CatalogoConversionDto)
        {
            var result = await _CatalogoConversionService.Update(CatalogoConversionDto);
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
            var result = await _CatalogoConversionService.Delete(id);
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
