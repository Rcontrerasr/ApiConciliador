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
        public ActionResult<IEnumerable<EmpresaEntity>> GetAll()
        {
            var EmpresaEntity = _EmpresaService.GetAll();
            if (EmpresaEntity == null)
            {
                return NotFound();
            }
            return Ok(EmpresaEntity);
        }

        [HttpGet("{id}")]
        public ActionResult<EmpresaEntity> GetById(Int32 id)
        {
            var EmpresaEntity = _EmpresaService.GetById(id);
            if (EmpresaEntity == null)
            {
                return NotFound();
            }
            return Ok(EmpresaEntity);
        }

        [HttpPost]
        public ActionResult<EmpresaEntity> Create(EmpresaEntity EmpresaEntity)
        {
            _EmpresaService.Add(EmpresaEntity);
            return CreatedAtAction(nameof(GetById), new { id = EmpresaEntity.Id }, EmpresaEntity);
        }

        [HttpPut("{id}")]
        public IActionResult Update(Int32 id, EmpresaEntity EmpresaEntity)
        {
            var existingItem = _EmpresaService.Update(EmpresaEntity);
            if (existingItem == null)
            {
                return NotFound();
            }

            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(Int32 id)
        {
            var existingItem = _EmpresaService.Delete(id);
            if (existingItem == null)
            {
                return NotFound();
            }
            return NoContent();
        }
    }


}
