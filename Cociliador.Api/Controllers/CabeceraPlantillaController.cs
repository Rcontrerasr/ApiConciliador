using System.Threading.Tasks;
using Conciliador.Logica.Servicios.Interfaces;
using Conciliador.Modelos.DTOs;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Swashbuckle.AspNetCore.Annotations;
using Microsoft.AspNetCore.Http;

namespace CabeceraPlantillaList.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CabeceraPlantillaController : ControllerBase
    {
        private readonly ILogger<CabeceraPlantillaController> _logger;
        private readonly IHttpContextAccessor _contextAccessor;
        private readonly ICabeceraPlantillaService _CabeceraPlantillaService;

        public CabeceraPlantillaController(ILogger<CabeceraPlantillaController> logger, IHttpContextAccessor contextAccessor, ICabeceraPlantillaService CabeceraPlantillaService)
        {
            _logger = logger;
            _contextAccessor = contextAccessor;
            _CabeceraPlantillaService = CabeceraPlantillaService;
        }

        [HttpGet]
        [SwaggerOperation(Summary = "Obtiene todas las CabeceraPlantillas", Description = "Devuelve una lista de todas las CabeceraPlantillas.")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<IActionResult> GetAll()
        {
            var result = await _CabeceraPlantillaService.GetAll();
            var response = new ServiceResponseDTO<List<CabeceraPlantillaDto>>()
            {
                Data = result,
                Message = "ok",
                Success = true,
                CountRecords = result.Count
            };

            return Ok(response);
        }

        [HttpGet("{id}")]
        [SwaggerOperation(Summary = "Obtiene una CabeceraPlantilla por ID", Description = "Devuelve una CabeceraPlantilla específica por su ID.")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> GetById(int id)
        {
            var result = await _CabeceraPlantillaService.GetById(id);
            if (result == null)
            {
                return NotFound();
            }

            var response = new ServiceResponseDTO<CabeceraPlantillaDto>()
            {
                Data = result,
                Message = "ok",
                Success = true,
                CountRecords = result != null ? 1 : 0
            };

            return Ok(response);
        }

        [HttpPost]
        [SwaggerOperation(Summary = "Crea una nueva CabeceraPlantilla", Description = "Agrega una nueva CabeceraPlantilla a la base de datos.")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> Create(CabeceraPlantillaDto CabeceraPlantillaDto)
        {
            var result = await _CabeceraPlantillaService.Add(CabeceraPlantillaDto);
            var response = new ServiceResponseDTO<bool>()
            {
                Data = result,
                Message = "ok",
                Success = true,
                CountRecords = result ? 1 : 0
            };

            return Ok(response);
        }

        [HttpPut("{id}")]
        [SwaggerOperation(Summary = "Actualiza una CabeceraPlantilla existente", Description = "Actualiza una CabeceraPlantilla específica por su ID.")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> Update(int id, CabeceraPlantillaDto CabeceraPlantillaDto)
        {
            var result = await _CabeceraPlantillaService.Update(CabeceraPlantillaDto);
            if (!result)
            {
                return NotFound();
            }

            var response = new ServiceResponseDTO<bool>()
            {
                Data = result,
                Message = "ok",
                Success = true,
                CountRecords = result ? 1 : 0
            };

            return Ok(response);
        }

        [HttpDelete("{id}")]
        [SwaggerOperation(Summary = "Elimina una CabeceraPlantilla existente", Description = "Elimina una CabeceraPlantilla específica por su ID.")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> Delete(int id)
        {
            var result = await _CabeceraPlantillaService.Delete(id);
            if (!result)
            {
                return NotFound();
            }

            var response = new ServiceResponseDTO<bool>()
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
