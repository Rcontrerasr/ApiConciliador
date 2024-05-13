using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.Identity.Web.Resource;

namespace BancoEmpresaList.Controllers
{
    [Authorize]
    [ApiController]
    [Route("[controller]")]
    public class BancoEmpresaController : ControllerBase
    {
        private readonly ILogger<BancoEmpresaController> _logger;
        private readonly IHttpContextAccessor _contextAccessor;
        private static List<BancoEmpresaItem> _BancoEmpresaItems = new List<BancoEmpresaItem>();

        public BancoEmpresaController(ILogger<BancoEmpresaController> logger, IHttpContextAccessor contextAccessor)
        {
            _logger = logger;
            _contextAccessor = contextAccessor;
        }

        [HttpGet]
        public ActionResult<IEnumerable<BancoEmpresaItem>> GetAll()
        {

            return Ok(_BancoEmpresaItems);
        }

        [HttpGet("{id}")]
        public ActionResult<BancoEmpresaItem> GetById(Guid id)
        {
            var BancoEmpresaItem = _BancoEmpresaItems.FirstOrDefault(item => item.Id == id);
            if (BancoEmpresaItem == null)
            {
                return NotFound();
            }
            return Ok(BancoEmpresaItem);
        }

        [HttpPost]
        public ActionResult<BancoEmpresaItem> Create(BancoEmpresaItem BancoEmpresaItem)
        {
            BancoEmpresaItem.Id = Guid.NewGuid();
            _BancoEmpresaItems.Add(BancoEmpresaItem);
            return CreatedAtAction(nameof(GetById), new { id = BancoEmpresaItem.Id }, BancoEmpresaItem);
        }

        [HttpPut("{id}")]
        public IActionResult Update(Guid id, BancoEmpresaItem BancoEmpresaItem)
        {
            var existingItem = _BancoEmpresaItems.FirstOrDefault(item => item.Id == id);
            if (existingItem == null)
            {
                return NotFound();
            }
            existingItem.Name = BancoEmpresaItem.Name;
            existingItem.IsComplete = BancoEmpresaItem.IsComplete;
            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(Guid id)
        {
            var existingItem = _BancoEmpresaItems.FirstOrDefault(item => item.Id == id);
            if (existingItem == null)
            {
                return NotFound();
            }
            _BancoEmpresaItems.Remove(existingItem);
            return NoContent();
        }
    }

    public class BancoEmpresaItem
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public bool IsComplete { get; set; }
    }
}
