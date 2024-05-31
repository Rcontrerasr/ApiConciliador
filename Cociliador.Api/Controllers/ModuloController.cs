using Conciliador.Logica.Servicios.Interfaces;
using Conciliador.Modelos.DTOs;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ModuloList.Controllers
{
    [ApiController]
    [AllowAnonymous]
    [Route("api/[controller]")]
    public class ModuloController : ControllerBase
    {
        private readonly ILogger<ModuloController> _logger;
        private readonly IHttpContextAccessor _contextAccessor;
        private readonly IModuloService _ModuloService;

        public ModuloController(ILogger<ModuloController> logger, IHttpContextAccessor contextAccessor, IModuloService ModuloService)
        {
            _logger = logger;
            _contextAccessor = contextAccessor;
            _ModuloService = ModuloService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var result = await _ModuloService.GetAll();
            var response = new ServiceResponseDTO<List<ModuloDto>>()
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
            var result = await _ModuloService.GetById(id);
            var response = new ServiceResponseDTO<ModuloDto>()
            {
                Data = result,
                Message = "ok",
                Success = true,
                CountRecords = result != null ? 1 : 0
            };

            return Ok(response);
        }

        [HttpPost]
        public async Task<IActionResult> Create(ModuloDto ModuloDto)
        {
            var result = await _ModuloService.Add(ModuloDto);
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
        public async Task<IActionResult> Update(Int32 id, ModuloDto ModuloDto)
        {
            var result = await _ModuloService.Update(ModuloDto);
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
            var result = await _ModuloService.Delete(id);
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
