using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.Identity.Web.Resource;

namespace ModuloRolesList.Controllers
{
    [Authorize]
    [ApiController]
    [Route("[controller]")]
    public class ModuloRolesController : ControllerBase
    {
        private readonly ILogger<ModuloRolesController> _logger;
        private readonly IHttpContextAccessor _contextAccessor;
        private static List<ModuloRolesItem> _ModuloRolesItems = new List<ModuloRolesItem>();

        public ModuloRolesController(ILogger<ModuloRolesController> logger, IHttpContextAccessor contextAccessor)
        {
            _logger = logger;
            _contextAccessor = contextAccessor;
        }

        [HttpGet]
        public ActionResult<IEnumerable<ModuloRolesItem>> GetAll()
        {
            return Ok(_ModuloRolesItems);
        }

        [HttpGet("{id}")]
        public ActionResult<ModuloRolesItem> GetById(Guid id)
        {
            var ModuloRolesItem = _ModuloRolesItems.FirstOrDefault(item => item.Id == id);
            if (ModuloRolesItem == null)
            {
                return NotFound();
            }
            return Ok(ModuloRolesItem);
        }

        [HttpPost]
        public ActionResult<ModuloRolesItem> Create(ModuloRolesItem ModuloRolesItem)
        {
            ModuloRolesItem.Id = Guid.NewGuid();
            _ModuloRolesItems.Add(ModuloRolesItem);
            return CreatedAtAction(nameof(GetById), new { id = ModuloRolesItem.Id }, ModuloRolesItem);
        }

        [HttpPut("{id}")]
        public IActionResult Update(Guid id, ModuloRolesItem ModuloRolesItem)
        {
            var existingItem = _ModuloRolesItems.FirstOrDefault(item => item.Id == id);
            if (existingItem == null)
            {
                return NotFound();
            }
            existingItem.Name = ModuloRolesItem.Name;
            existingItem.IsComplete = ModuloRolesItem.IsComplete;
            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(Guid id)
        {
            var existingItem = _ModuloRolesItems.FirstOrDefault(item => item.Id == id);
            if (existingItem == null)
            {
                return NotFound();
            }
            _ModuloRolesItems.Remove(existingItem);
            return NoContent();
        }
    }

    public class ModuloRolesItem
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public bool IsComplete { get; set; }
    }
}
