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

namespace BancosList.Controllers
{
    [ApiController]
    [AllowAnonymous]
    [Route("[controller]")]
    public class BancosController : ControllerBase
    {
        private readonly ILogger<BancosController> _logger;
        private readonly IHttpContextAccessor _contextAccessor;
        private readonly IBancosService _BancosService;

        public BancosController(ILogger<BancosController> logger, IHttpContextAccessor contextAccessor, IBancosService BancosService)
        {
            _logger = logger;
            _contextAccessor = contextAccessor;
            _BancosService = BancosService;
        }

        [HttpGet]
        public ActionResult<IEnumerable<BancosEntity>> GetAll()
        {
            var BancosEntity = _BancosService.GetAll();
            if (BancosEntity == null)
            {
                return NotFound();
            }
            return Ok(BancosEntity);
        }

        [HttpGet("{id}")]
        public ActionResult<BancosEntity> GetById(Int32 id)
        {
            var BancosEntity = _BancosService.GetById(id);
            if (BancosEntity == null)
            {
                return NotFound();
            }
            return Ok(BancosEntity);
        }

        [HttpPost]
        public ActionResult<BancosEntity> Create(BancosEntity BancosEntity)
        {
            _BancosService.Add(BancosEntity);
            return CreatedAtAction(nameof(GetById), new { id = BancosEntity.Id }, BancosEntity);
        }

        [HttpPut("{id}")]
        public IActionResult Update(Int32 id, BancosEntity BancosEntity)
        {
            var existingItem = _BancosService.Update(BancosEntity);
            if (existingItem == null)
            {
                return NotFound();
            }

            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(Int32 id)
        {
            var existingItem = _BancosService.Delete(id);
            if (existingItem == null)
            {
                return NotFound();
            }
            return NoContent();
        }
    }


}
