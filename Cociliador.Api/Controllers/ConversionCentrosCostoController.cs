using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.Identity.Web.Resource;

namespace ConversionCentrosCostoList.Controllers
{
    [Authorize]
    [ApiController]
    [Route("[controller]")]
    public class ConversionCentrosCostoController : ControllerBase
    {
        private readonly ILogger<ConversionCentrosCostoController> _logger;
        private readonly IHttpContextAccessor _contextAccessor;
        private static List<ConversionCentrosCostoItem> _ConversionCentrosCostoItems = new List<ConversionCentrosCostoItem>();

        public ConversionCentrosCostoController(ILogger<ConversionCentrosCostoController> logger, IHttpContextAccessor contextAccessor)
        {
            _logger = logger;
            _contextAccessor = contextAccessor;
        }

        [HttpGet]
        public ActionResult<IEnumerable<ConversionCentrosCostoItem>> GetAll()
        {
            return Ok(_ConversionCentrosCostoItems);
        }

        [HttpGet("{id}")]
        public ActionResult<ConversionCentrosCostoItem> GetById(Guid id)
        {
            var ConversionCentrosCostoItem = _ConversionCentrosCostoItems.FirstOrDefault(item => item.Id == id);
            if (ConversionCentrosCostoItem == null)
            {
                return NotFound();
            }
            return Ok(ConversionCentrosCostoItem);
        }

        [HttpPost]
        public ActionResult<ConversionCentrosCostoItem> Create(ConversionCentrosCostoItem ConversionCentrosCostoItem)
        {
            ConversionCentrosCostoItem.Id = Guid.NewGuid();
            _ConversionCentrosCostoItems.Add(ConversionCentrosCostoItem);
            return CreatedAtAction(nameof(GetById), new { id = ConversionCentrosCostoItem.Id }, ConversionCentrosCostoItem);
        }

        [HttpPut("{id}")]
        public IActionResult Update(Guid id, ConversionCentrosCostoItem ConversionCentrosCostoItem)
        {
            var existingItem = _ConversionCentrosCostoItems.FirstOrDefault(item => item.Id == id);
            if (existingItem == null)
            {
                return NotFound();
            }
            existingItem.Name = ConversionCentrosCostoItem.Name;
            existingItem.IsComplete = ConversionCentrosCostoItem.IsComplete;
            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(Guid id)
        {
            var existingItem = _ConversionCentrosCostoItems.FirstOrDefault(item => item.Id == id);
            if (existingItem == null)
            {
                return NotFound();
            }
            _ConversionCentrosCostoItems.Remove(existingItem);
            return NoContent();
        }
    }

    public class ConversionCentrosCostoItem
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public bool IsComplete { get; set; }
    }
}
