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

namespace BancoEmpresaList.Controllers
{
    [ApiController]
    [AllowAnonymous]
    [Route("[controller]")]
    public class BancoEmpresaController : ControllerBase
    {
        private readonly ILogger<BancoEmpresaController> _logger;
        private readonly IHttpContextAccessor _contextAccessor;
        private readonly IBancoEmpresaService _BancoEmpresaService;

        public BancoEmpresaController(ILogger<BancoEmpresaController> logger, IHttpContextAccessor contextAccessor, IBancoEmpresaService BancoEmpresaService)
        {
            _logger = logger;
            _contextAccessor = contextAccessor;
            _BancoEmpresaService = BancoEmpresaService;
        }

        [HttpGet]
        public ActionResult<IEnumerable<BancoEmpresaEntity>> GetAll()
        {
            var BancoEmpresaEntity = _BancoEmpresaService.GetAll();
            if (BancoEmpresaEntity == null)
            {
                return NotFound();
            }
            return Ok(BancoEmpresaEntity);
        }

        [HttpGet("{id}")]
        public ActionResult<BancoEmpresaEntity> GetById(Int32 id)
        {
            var BancoEmpresaEntity = _BancoEmpresaService.GetById(id);
            if (BancoEmpresaEntity == null)
            {
                return NotFound();
            }
            return Ok(BancoEmpresaEntity);
        }

        [HttpPost]
        public ActionResult<BancoEmpresaEntity> Create(BancoEmpresaEntity BancoEmpresaEntity)
        {
            _BancoEmpresaService.Add(BancoEmpresaEntity);
            return CreatedAtAction(nameof(GetById), new { id = BancoEmpresaEntity.Id }, BancoEmpresaEntity);
        }

        [HttpPut("{id}")]
        public IActionResult Update(Int32 id, BancoEmpresaEntity BancoEmpresaEntity)
        {
            var existingItem = _BancoEmpresaService.Update(BancoEmpresaEntity);
            if (existingItem == null)
            {
                return NotFound();
            }

            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(Int32 id)
        {
            var existingItem = _BancoEmpresaService.Delete(id);
            if (existingItem == null)
            {
                return NotFound();
            }
            return NoContent();
        }
    }


}
