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

namespace CatalogoNombreList.Controllers
{
    [ApiController]
    [AllowAnonymous]
    [Route("[controller]")]
    public class CatalogoNombreController : ControllerBase
    {
        private readonly ILogger<CatalogoNombreController> _logger;
        private readonly IHttpContextAccessor _contextAccessor;
        private readonly ICatalogoNombreService _CatalogoNombreService;

        public CatalogoNombreController(ILogger<CatalogoNombreController> logger, IHttpContextAccessor contextAccessor, ICatalogoNombreService CatalogoNombreService)
        {
            _logger = logger;
            _contextAccessor = contextAccessor;
            _CatalogoNombreService = CatalogoNombreService;
        }

        [HttpGet]
        public ActionResult<IEnumerable<CatalogoNombreEntity>> GetAll()
        {
            var CatalogoNombreEntity = _CatalogoNombreService.GetAll();
            if (CatalogoNombreEntity == null)
            {
                return NotFound();
            }
            return Ok(CatalogoNombreEntity);
        }

        [HttpGet("{id}")]
        public ActionResult<CatalogoNombreEntity> GetById(Int32 id)
        {
            var CatalogoNombreEntity = _CatalogoNombreService.GetById(id);
            if (CatalogoNombreEntity == null)
            {
                return NotFound();
            }
            return Ok(CatalogoNombreEntity);
        }

        [HttpPost]
        public ActionResult<CatalogoNombreEntity> Create(CatalogoNombreEntity CatalogoNombreEntity)
        {
            _CatalogoNombreService.Add(CatalogoNombreEntity);
            return CreatedAtAction(nameof(GetById), new { id = CatalogoNombreEntity.Id }, CatalogoNombreEntity);
        }

        [HttpPut("{id}")]
        public IActionResult Update(Int32 id, CatalogoNombreEntity CatalogoNombreEntity)
        {
            var existingItem = _CatalogoNombreService.Update(CatalogoNombreEntity);
            if (existingItem == null)
            {
                return NotFound();
            }

            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(Int32 id)
        {
            var existingItem = _CatalogoNombreService.Delete(id);
            if (existingItem == null)
            {
                return NotFound();
            }
            return NoContent();
        }
    }


}
