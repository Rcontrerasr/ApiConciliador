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

namespace TodoList.Controllers
{
    [ApiController]
    [AllowAnonymous]
    [Route("[controller]")]
    public class TodoController : ControllerBase
    {
        private readonly ILogger<TodoController> _logger;
        private readonly IHttpContextAccessor _contextAccessor;
        private readonly ITodoService _todoService;

        public TodoController(ILogger<TodoController> logger, IHttpContextAccessor contextAccessor,ITodoService todoService) 
        {
            _logger = logger;
            _contextAccessor = contextAccessor;
            _todoService= todoService;
        }

        [HttpGet]
        public ActionResult<IEnumerable<TodoEntity>> GetAll()
        {
            var TodoEntity = _todoService.GetAll();
            if (TodoEntity == null)
            {
                return NotFound();
            }
            return Ok(TodoEntity);
        }

        [HttpGet("{id}")]
        public ActionResult<TodoEntity> GetById(Int32 id)
        {
            var TodoEntity = _todoService.GetById(id);
            if (TodoEntity == null)
            {
                return NotFound();
            }
            return Ok(TodoEntity);
        }

        [HttpPost]
        public ActionResult<TodoEntity> Create(TodoEntity TodoEntity)
        {
            _todoService.Add(TodoEntity);
            return CreatedAtAction(nameof(GetById), new { id = TodoEntity.Id }, TodoEntity);
        }

        [HttpPut("{id}")]
        public IActionResult Update(Guid id, TodoEntity TodoEntity)
        {
            var existingItem = _todoService.Update(TodoEntity);
            if (existingItem == null)
            {
                return NotFound();
            }
           
            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(Int32 id)
        {
            var existingItem = _todoService.Delete(id);
            if (existingItem == null)
            {
                return NotFound();
            }
            return NoContent();
        }
    }

   
}
