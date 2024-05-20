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
        public ActionResult<IEnumerable<ModuloRolesEntity>> GetAll()
        {
            var ModuloRolesEntity = _ModuloRolesService.GetAll();
            if (ModuloRolesEntity == null)
            {
                return NotFound();
            }
            return Ok(ModuloRolesEntity);
        }

        [HttpGet("{id}")]
        public ActionResult<ModuloRolesEntity> GetById(Int32 id)
        {
            var ModuloRolesEntity = _ModuloRolesService.GetById(id);
            if (ModuloRolesEntity == null)
            {
                return NotFound();
            }
            return Ok(ModuloRolesEntity);
        }

        [HttpPost]
        public ActionResult<ModuloRolesEntity> Create(ModuloRolesEntity ModuloRolesEntity)
        {
            _ModuloRolesService.Add(ModuloRolesEntity);
            return CreatedAtAction(nameof(GetById), new { id = ModuloRolesEntity.Id }, ModuloRolesEntity);
        }

        [HttpPut("{id}")]
        public IActionResult Update(Int32 id, ModuloRolesEntity ModuloRolesEntity)
        {
            var existingItem = _ModuloRolesService.Update(ModuloRolesEntity);
            if (existingItem == null)
            {
                return NotFound();
            }

            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(Int32 id)
        {
            var existingItem = _ModuloRolesService.Delete(id);
            if (existingItem == null)
            {
                return NotFound();
            }
            return NoContent();
        }
    }


}
