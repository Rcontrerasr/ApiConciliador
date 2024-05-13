using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.Identity.Web.Resource;

namespace BancosList.Controllers
{
    [Authorize]
    [ApiController]
    [Route("[controller]")]
    public class BancosController : ControllerBase
    {
        private readonly ILogger<BancosController> _logger;
        private readonly IHttpContextAccessor _contextAccessor;
        private static List<BancosItem> _BancosItems = new List<BancosItem>();

        public BancosController(ILogger<BancosController> logger, IHttpContextAccessor contextAccessor)
        {
            _logger = logger;
            _contextAccessor = contextAccessor;
        }

        [HttpGet]
        public ActionResult<IEnumerable<BancosItem>> GetAll()
        {

            return Ok(_BancosItems);
        }

        [HttpGet("{id}")]
        public ActionResult<BancosItem> GetById(Guid id)
        {
            var BancosItem = _BancosItems.FirstOrDefault(item => item.Id == id);
            if (BancosItem == null)
            {
                return NotFound();
            }
            return Ok(BancosItem);
        }

        [HttpPost]
        public ActionResult<BancosItem> Create(BancosItem BancosItem)
        {
            BancosItem.Id = Guid.NewGuid();
            _BancosItems.Add(BancosItem);
            return CreatedAtAction(nameof(GetById), new { id = BancosItem.Id }, BancosItem);
        }

        [HttpPut("{id}")]
        public IActionResult Update(Guid id, BancosItem BancosItem)
        {
            var existingItem = _BancosItems.FirstOrDefault(item => item.Id == id);
            if (existingItem == null)
            {
                return NotFound();
            }
            existingItem.Name = BancosItem.Name;
            existingItem.IsComplete = BancosItem.IsComplete;
            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(Guid id)
        {
            var existingItem = _BancosItems.FirstOrDefault(item => item.Id == id);
            if (existingItem == null)
            {
                return NotFound();
            }
            _BancosItems.Remove(existingItem);
            return NoContent();
        }
    }

    public class BancosItem
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public bool IsComplete { get; set; }
    }
}
