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
        public ActionResult<IEnumerable<ModuloEntity>> GetAll()
        {
            var ModuloEntity = _ModuloService.GetAll();
            if (ModuloEntity == null)
            {
                return NotFound();
            }
            return Ok(ModuloEntity);
        }

        [HttpGet("{id}")]
        public ActionResult<ModuloEntity> GetById(Int32 id)
        {
            var ModuloEntity = _ModuloService.GetById(id);
            if (ModuloEntity == null)
            {
                return NotFound();
            }
            return Ok(ModuloEntity);
        }

        [HttpPost]
        public ActionResult<ModuloEntity> Create(ModuloEntity ModuloEntity)
        {
            _ModuloService.Add(ModuloEntity);
            return CreatedAtAction(nameof(GetById), new { id = ModuloEntity.Id }, ModuloEntity);
        }

        [HttpPut("{id}")]
        public IActionResult Update(Int32 id, ModuloEntity ModuloEntity)
        {
            var existingItem = _ModuloService.Update(ModuloEntity);
            if (existingItem == null)
            {
                return NotFound();
            }

            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(Int32 id)
        {
            var existingItem = _ModuloService.Delete(id);
            if (existingItem == null)
            {
                return NotFound();
            }
            return NoContent();
        }
    }


}
