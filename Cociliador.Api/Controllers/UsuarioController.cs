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

namespace UsuarioList.Controllers
{
    [ApiController]
    [AllowAnonymous]
    [Route("api/[controller]")]
    public class UsuarioController : ControllerBase
    {
        private readonly ILogger<UsuarioController> _logger;
        private readonly IHttpContextAccessor _contextAccessor;
        private readonly IUsuarioService _UsuarioService;

        public UsuarioController(ILogger<UsuarioController> logger, IHttpContextAccessor contextAccessor, IUsuarioService UsuarioService)
        {
            _logger = logger;
            _contextAccessor = contextAccessor;
            _UsuarioService = UsuarioService;
        }

        [HttpGet]
        public ActionResult<IEnumerable<UsuarioEntity>> GetAll()
        {
            var UsuarioEntity = _UsuarioService.GetAll();
            if (UsuarioEntity == null)
            {
                return NotFound();
            }
            return Ok(UsuarioEntity);
        }

        [HttpGet("{id}")]
        public ActionResult<UsuarioEntity> GetById(Int32 id)
        {
            var UsuarioEntity = _UsuarioService.GetById(id);
            if (UsuarioEntity == null)
            {
                return NotFound();
            }
            return Ok(UsuarioEntity);
        }

        [HttpPost]
        public ActionResult<UsuarioEntity> Create(UsuarioEntity UsuarioEntity)
        {
            _UsuarioService.Add(UsuarioEntity);
            return CreatedAtAction(nameof(GetById), new { id = UsuarioEntity.Id }, UsuarioEntity);
        }

        [HttpPut("{id}")]
        public IActionResult Update(Int32 id, UsuarioEntity UsuarioEntity)
        {
            var existingItem = _UsuarioService.Update(UsuarioEntity);
            if (existingItem == null)
            {
                return NotFound();
            }

            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(Int32 id)
        {
            var existingItem = _UsuarioService.Delete(id);
            if (existingItem == null)
            {
                return NotFound();
            }
            return NoContent();
        }
    }


}
