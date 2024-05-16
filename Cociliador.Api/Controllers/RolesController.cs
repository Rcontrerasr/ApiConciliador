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

namespace RolesList.Controllers
{
    [ApiController]
    [AllowAnonymous]
    [Route("[controller]")]
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
        public ActionResult<IEnumerable<RolesEntity>> GetAll()
        {
            var RolesEntity = _RolesService.GetAll();
            if (RolesEntity == null)
            {
                return NotFound();
            }
            return Ok(RolesEntity);
        }

        [HttpGet("{id}")]
        public ActionResult<RolesEntity> GetById(Int32 id)
        {
            var RolesEntity = _RolesService.GetById(id);
            if (RolesEntity == null)
            {
                return NotFound();
            }
            return Ok(RolesEntity);
        }

        [HttpPost]
        public ActionResult<RolesEntity> Create(RolesEntity RolesEntity)
        {
            _RolesService.Add(RolesEntity);
            return CreatedAtAction(nameof(GetById), new { id = RolesEntity.Id }, RolesEntity);
        }

        [HttpPut("{id}")]
        public IActionResult Update(Int32 id, RolesEntity RolesEntity)
        {
            var existingItem = _RolesService.Update(RolesEntity);
            if (existingItem == null)
            {
                return NotFound();
            }

            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(Int32 id)
        {
            var existingItem = _RolesService.Delete(id);
            if (existingItem == null)
            {
                return NotFound();
            }
            return NoContent();
        }
    }


}
