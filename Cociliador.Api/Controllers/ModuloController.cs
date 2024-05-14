using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.Identity.Web.Resource;

namespace ModuloList.Controllers
{
    [Authorize]
    [ApiController]
    [Route("[controller]")]
    public class ModuloController : ControllerBase
    {
        private readonly ILogger<ModuloController> _logger;
        private readonly IHttpContextAccessor _contextAccessor;
        private static List<ModuloItem> _ModuloItems = new List<ModuloItem>();

        public ModuloController(ILogger<ModuloController> logger, IHttpContextAccessor contextAccessor)
        {
            _logger = logger;
            _contextAccessor = contextAccessor;
        }

        [HttpGet]
        public ActionResult<IEnumerable<ModuloItem>> GetAll()
        {
            return Ok(_ModuloItems);
        }

        [HttpGet("{id}")]
        public ActionResult<ModuloItem> GetById(Guid id)
        {
            var ModuloItem = _ModuloItems.FirstOrDefault(item => item.Id == id);
            if (ModuloItem == null)
            {
                return NotFound();
            }
            return Ok(ModuloItem);
        }

        [HttpPost]
        public ActionResult<ModuloItem> Create(ModuloItem ModuloItem)
        {
            ModuloItem.Id = Guid.NewGuid();
            _ModuloItems.Add(ModuloItem);
            return CreatedAtAction(nameof(GetById), new { id = ModuloItem.Id }, ModuloItem);
        }

        [HttpPut("{id}")]
        public IActionResult Update(Guid id, ModuloItem ModuloItem)
        {
            var existingItem = _ModuloItems.FirstOrDefault(item => item.Id == id);
            if (existingItem == null)
            {
                return NotFound();
            }
            existingItem.Name = ModuloItem.Name;
            existingItem.IsComplete = ModuloItem.IsComplete;
            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(Guid id)
        {
            var existingItem = _ModuloItems.FirstOrDefault(item => item.Id == id);
            if (existingItem == null)
            {
                return NotFound();
            }
            _ModuloItems.Remove(existingItem);
            return NoContent();
        }
    }

    public class ModuloItem
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public bool IsComplete { get; set; }
    }
}
