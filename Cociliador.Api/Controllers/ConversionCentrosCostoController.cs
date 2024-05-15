using System;
using System.Collections.Generic;
using System.Linq;
using Conciliador.Datos.Infraestructura.Entidades;
using Conciliador.Logica.Servicios.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.Identity.Web.Resource;

namespace ConversionCentrosCostoList.Controllers
{
    [ApiController]
    [AllowAnonymous]
    [Route("[controller]")]
    public class ConversionCentrosCostoController : ControllerBase
    {
        private readonly ILogger<ConversionCentrosCostoController> _logger;
        private readonly IHttpContextAccessor _contextAccessor;
        private readonly IConversionCentrosCostoService _ConversionCentrosCostoService;

        public ConversionCentrosCostoController(ILogger<ConversionCentrosCostoController> logger, IHttpContextAccessor contextAccessor, IConversionCentrosCostoService ConversionCentrosCostoService)
        {
            _logger = logger;
            _contextAccessor = contextAccessor;
            _ConversionCentrosCostoService = ConversionCentrosCostoService;
        }

        [HttpGet]
        public ActionResult<IEnumerable<ConversionCentrosCostoEntity>> GetAll()
        {
            var ConversionCentrosCostoEntity = _ConversionCentrosCostoService.GetAll();
            if (ConversionCentrosCostoEntity == null)
            {
                return NotFound();
            }
            return Ok(ConversionCentrosCostoEntity);
        }

        [HttpGet("{id}")]
        public ActionResult<ConversionCentrosCostoEntity> GetById(Int32 id)
        {
            var ConversionCentrosCostoEntity = _ConversionCentrosCostoService.GetById(id);
            if (ConversionCentrosCostoEntity == null)
            {
                return NotFound();
            }
            return Ok(ConversionCentrosCostoEntity);
        }

        [HttpPost]
        public ActionResult<ConversionCentrosCostoEntity> Create(ConversionCentrosCostoEntity ConversionCentrosCostoEntity)
        {
            _ConversionCentrosCostoService.Add(ConversionCentrosCostoEntity);
            return CreatedAtAction(nameof(GetById), new { id = ConversionCentrosCostoEntity.Id }, ConversionCentrosCostoEntity);
        }

        [HttpPut("{id}")]
        public IActionResult Update(Int32 id, ConversionCentrosCostoEntity ConversionCentrosCostoEntity)
        {
            var existingItem = _ConversionCentrosCostoService.Update(ConversionCentrosCostoEntity);
            if (existingItem == null)
            {
                return NotFound();
            }

            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(Int32 id)
        {
            var existingItem = _ConversionCentrosCostoService.Delete(id);
            if (existingItem == null)
            {
                return NotFound();
            }
            return NoContent();
        }
    }


}
