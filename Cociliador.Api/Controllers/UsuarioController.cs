using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.Identity.Web.Resource;

namespace UsuarioList.Controllers
{
    [Authorize]
    [ApiController]
    [Route("[controller]")]
    public class UsuarioController : ControllerBase
    {
        private readonly ILogger<UsuarioController> _logger;
        private readonly IHttpContextAccessor _contextAccessor;
        private static List<UsuarioItem> _UsuarioItems = new List<UsuarioItem>();

        public UsuarioController(ILogger<UsuarioController> logger, IHttpContextAccessor contextAccessor)
        {
            _logger = logger;
            _contextAccessor = contextAccessor;
        }

        [HttpGet]
        public ActionResult<IEnumerable<UsuarioItem>> GetAll()
        {
            return Ok(_UsuarioItems);
        }

        [HttpGet("{id}")]
        public ActionResult<UsuarioItem> GetById(Guid id)
        {
            var UsuarioItem = _UsuarioItems.FirstOrDefault(item => item.Id == id);
            if (UsuarioItem == null)
            {
                return NotFound();
            }
            return Ok(UsuarioItem);
        }

        [HttpPost]
        public ActionResult<UsuarioItem> Create(UsuarioItem UsuarioItem)
        {
            UsuarioItem.Id = Guid.NewGuid();
            _UsuarioItems.Add(UsuarioItem);
            return CreatedAtAction(nameof(GetById), new { id = UsuarioItem.Id }, UsuarioItem);
        }

        [HttpPut("{id}")]
        public IActionResult Update(Guid id, UsuarioItem UsuarioItem)
        {
            var existingItem = _UsuarioItems.FirstOrDefault(item => item.Id == id);
            if (existingItem == null)
            {
                return NotFound();
            }
            existingItem.Name = UsuarioItem.Name;
            existingItem.IsComplete = UsuarioItem.IsComplete;
            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(Guid id)
        {
            var existingItem = _UsuarioItems.FirstOrDefault(item => item.Id == id);
            if (existingItem == null)
            {
                return NotFound();
            }
            _UsuarioItems.Remove(existingItem);
            return NoContent();
        }
    }

    public class UsuarioItem
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public bool IsComplete { get; set; }
    }
}
