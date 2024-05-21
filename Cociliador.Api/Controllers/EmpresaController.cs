using Conciliador.Logica.Servicios.Interfaces;
using Conciliador.Modelos.DTOs;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace EmpresaList.Controllers
{
    [ApiController]
    [AllowAnonymous]
    [Route("api/[controller]")]
    public class EmpresaController : ControllerBase
    {
        private readonly ILogger<EmpresaController> _logger;
        private readonly IHttpContextAccessor _contextAccessor;
        private readonly IEmpresaService _EmpresaService;

        public EmpresaController(ILogger<EmpresaController> logger, IHttpContextAccessor contextAccessor, IEmpresaService EmpresaService)
        {
            _logger = logger;
            _contextAccessor = contextAccessor;
            _EmpresaService = EmpresaService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var result = await _EmpresaService.GetAll();
            var response = new ServiceResponseDTO<List<EmpresaDto>>()
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
            var result = await _EmpresaService.GetById(id);
            var response = new ServiceResponseDTO<EmpresaDto>()
            {
                Data = result,
                Message = "ok",
                Success = true,
                CountRecords = result != null ? 1 : 0
            };

            return Ok(response);
        }

        [HttpPost]
        public async Task<IActionResult> Create(EmpresaDto EmpresaDto)
        {
            var result = await _EmpresaService.Add(EmpresaDto);
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
        public async Task<IActionResult> Update(Int32 id, EmpresaDto EmpresaDto)
        {
            var result = await _EmpresaService.Update(EmpresaDto);
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
            var result = await _EmpresaService.Delete(id);
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
