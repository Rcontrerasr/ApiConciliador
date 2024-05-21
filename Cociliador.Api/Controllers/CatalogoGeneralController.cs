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

namespace CatalogoGeneralList.Controllers
{
    [ApiController]
    [AllowAnonymous]
    [Route("api/[controller]")]
    public class CatalogoGeneralController : ControllerBase
    {
        private readonly ILogger<CatalogoGeneralController> _logger;
        private readonly IHttpContextAccessor _contextAccessor;
        private readonly ICatalogoGeneralService _CatalogoGeneralService;

        public CatalogoGeneralController(ILogger<CatalogoGeneralController> logger, IHttpContextAccessor contextAccessor, ICatalogoGeneralService CatalogoGeneralService)
        {
            _logger = logger;
            _contextAccessor = contextAccessor;
            _CatalogoGeneralService = CatalogoGeneralService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var result = await _CatalogoGeneralService.GetAll();
            var response = new ServiceResponseDTO<List<CatalogoGeneralDto>>()
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
            var result = await _CatalogoGeneralService.GetById(id);
            var response = new ServiceResponseDTO<CatalogoGeneralDto>()
            {
                Data = result,
                Message = "ok",
                Success = true,
                CountRecords = result != null ? 1 : 0
            };

            return Ok(response);
        }

        [HttpPost]
        public async Task<IActionResult> Create(CatalogoGeneralDto CatalogoGeneralDto)
        {
            var result = await _CatalogoGeneralService.Add(CatalogoGeneralDto);
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
        public async Task<IActionResult> Update(Int32 id, CatalogoGeneralDto CatalogoGeneralDto)
        {
            var result = await _CatalogoGeneralService.Update(CatalogoGeneralDto);
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
            var result = await _CatalogoGeneralService.Delete(id);
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
