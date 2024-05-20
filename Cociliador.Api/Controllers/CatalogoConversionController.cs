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

namespace CatalogoConversionList.Controllers
{
    [ApiController]
    [AllowAnonymous]
    [Route("api/[controller]")]
    public class CatalogoConversionController : ControllerBase
    {
        private readonly ILogger<CatalogoConversionController> _logger;
        private readonly IHttpContextAccessor _contextAccessor;
        private readonly ICatalogoConversionService _CatalogoConversionService;

        public CatalogoConversionController(ILogger<CatalogoConversionController> logger, IHttpContextAccessor contextAccessor, ICatalogoConversionService CatalogoConversionService)
        {
            _logger = logger;
            _contextAccessor = contextAccessor;
            _CatalogoConversionService = CatalogoConversionService;
        }

        [HttpGet]
        public ActionResult<IEnumerable<CatalogoConversionEntity>> GetAll()
        {
            var CatalogoConversionEntity = _CatalogoConversionService.GetAll();
            if (CatalogoConversionEntity == null)
            {
                return NotFound();
            }
            return Ok(CatalogoConversionEntity);
        }

        [HttpGet("{id}")]
        public ActionResult<CatalogoConversionEntity> GetById(Int32 id)
        {
            var CatalogoConversionEntity = _CatalogoConversionService.GetById(id);
            if (CatalogoConversionEntity == null)
            {
                return NotFound();
            }
            return Ok(CatalogoConversionEntity);
        }

        [HttpPost]
        public ActionResult<CatalogoConversionEntity> Create(CatalogoConversionEntity CatalogoConversionEntity)
        {
            _CatalogoConversionService.Add(CatalogoConversionEntity);
            return CreatedAtAction(nameof(GetById), new { id = CatalogoConversionEntity.Id }, CatalogoConversionEntity);
        }

        [HttpPut("{id}")]
        public IActionResult Update(Int32 id, CatalogoConversionEntity CatalogoConversionEntity)
        {
            var existingItem = _CatalogoConversionService.Update(CatalogoConversionEntity);
            if (existingItem == null)
            {
                return NotFound();
            }

            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(Int32 id)
        {
            var existingItem = _CatalogoConversionService.Delete(id);
            if (existingItem == null)
            {
                return NotFound();
            }
            return NoContent();
        }
    }


}
