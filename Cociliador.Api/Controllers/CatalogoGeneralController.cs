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

namespace CatalogoGeneralList.Controllers
{
    [ApiController]
    [AllowAnonymous]
    [Route("[controller]")]
    public class CatalogoGeneralController : ControllerBase
    {
        private readonly ILogger<CatalogoGeneralController> _logger;
        private readonly IHttpContextAccessor _contextAccessor;
        private readonly ICatalogoGeneralService _CatalogoGeneralService;

        public CatalogoGeneralController(ILogger<CatalogoGeneralController> logger, IHttpContextAccessor contextAccessor, ICatalogoGeneralService CatalogoGeneralService)
        {
            _logger = logger;
            _contextAccessor = contextAccessor;
            _CatalogoGeneralService = CatalogoGeneralService;
        }

        [HttpGet]
        public ActionResult<IEnumerable<CatalogoGeneralEntity>> GetAll()
        {
            var CatalogoGeneralEntity = _CatalogoGeneralService.GetAll();
            if (CatalogoGeneralEntity == null)
            {
                return NotFound();
            }
            return Ok(CatalogoGeneralEntity);
        }

        [HttpGet("{id}")]
        public ActionResult<CatalogoGeneralEntity> GetById(Int32 id)
        {
            var CatalogoGeneralEntity = _CatalogoGeneralService.GetById(id);
            if (CatalogoGeneralEntity == null)
            {
                return NotFound();
            }
            return Ok(CatalogoGeneralEntity);
        }

        [HttpPost]
        public ActionResult<CatalogoGeneralEntity> Create(CatalogoGeneralEntity CatalogoGeneralEntity)
        {
            _CatalogoGeneralService.Add(CatalogoGeneralEntity);
            return CreatedAtAction(nameof(GetById), new { id = CatalogoGeneralEntity.Id }, CatalogoGeneralEntity);
        }

        [HttpPut("{id}")]
        public IActionResult Update(Int32 id, CatalogoGeneralEntity CatalogoGeneralEntity)
        {
            var existingItem = _CatalogoGeneralService.Update(CatalogoGeneralEntity);
            if (existingItem == null)
            {
                return NotFound();
            }

            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(Int32 id)
        {
            var existingItem = _CatalogoGeneralService.Delete(id);
            if (existingItem == null)
            {
                return NotFound();
            }
            return NoContent();
        }
    }


}
