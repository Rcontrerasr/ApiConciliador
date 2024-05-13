using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.Identity.Web.Resource;

namespace EmpresaList.Controllers
{
    [Authorize]
    [ApiController]
    [Route("[controller]")]
    public class EmpresaController : ControllerBase
    {
        private readonly ILogger<EmpresaController> _logger;
        private readonly IHttpContextAccessor _contextAccessor;
        private static List<EmpresaItem> _EmpresaItems = new List<EmpresaItem>();

        public EmpresaController(ILogger<EmpresaController> logger, IHttpContextAccessor contextAccessor)
        {
            _logger = logger;
            _contextAccessor = contextAccessor;
        }

        [HttpGet]
        public ActionResult<IEnumerable<EmpresaItem>> GetAll()
        {
            return Ok(_EmpresaItems);
        }

        [HttpGet("{id}")]
        public ActionResult<EmpresaItem> GetById(Guid id)
        {
            var EmpresaItem = _EmpresaItems.FirstOrDefault(item => item.Id == id);
            if (EmpresaItem == null)
            {
                return NotFound();
            }
            return Ok(EmpresaItem);
        }

        [HttpPost]
        public ActionResult<EmpresaItem> Create(EmpresaItem EmpresaItem)
        {
            EmpresaItem.Id = Guid.NewGuid();
            _EmpresaItems.Add(EmpresaItem);
            return CreatedAtAction(nameof(GetById), new { id = EmpresaItem.Id }, EmpresaItem);
        }

        [HttpPut("{id}")]
        public IActionResult Update(Guid id, EmpresaItem EmpresaItem)
        {
            var existingItem = _EmpresaItems.FirstOrDefault(item => item.Id == id);
            if (existingItem == null)
            {
                return NotFound();
            }
            existingItem.Name = EmpresaItem.Name;
            existingItem.IsComplete = EmpresaItem.IsComplete;
            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(Guid id)
        {
            var existingItem = _EmpresaItems.FirstOrDefault(item => item.Id == id);
            if (existingItem == null)
            {
                return NotFound();
            }
            _EmpresaItems.Remove(existingItem);
            return NoContent();
        }
    }

    public class EmpresaItem
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public bool IsComplete { get; set; }
    }
}
