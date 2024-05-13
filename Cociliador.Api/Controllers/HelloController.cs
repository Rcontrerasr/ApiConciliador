using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.Identity.Web.Resource;

namespace TodoList.Controllers
{
    [Authorize]
    [ApiController]
    [Route("[controller]")]
    public class TodoController : ControllerBase
    {
        private readonly ILogger<TodoController> _logger;
        private readonly IHttpContextAccessor _contextAccessor;
        private static List<TodoItem> _todoItems = new List<TodoItem>();

        public TodoController(ILogger<TodoController> logger, IHttpContextAccessor contextAccessor)
        {
            _logger = logger;
            _contextAccessor = contextAccessor;
        }

        [HttpGet]
        public ActionResult<IEnumerable<TodoItem>> GetAll()
        {
            return Ok(_todoItems);
        }

        [HttpGet("{id}")]
        public ActionResult<TodoItem> GetById(Guid id)
        {
            var todoItem = _todoItems.FirstOrDefault(item => item.Id == id);
            if (todoItem == null)
            {
                return NotFound();
            }
            return Ok(todoItem);
        }

        [HttpPost]
        public ActionResult<TodoItem> Create(TodoItem todoItem)
        {
            todoItem.Id = Guid.NewGuid();
            _todoItems.Add(todoItem);
            return CreatedAtAction(nameof(GetById), new { id = todoItem.Id }, todoItem);
        }

        [HttpPut("{id}")]
        public IActionResult Update(Guid id, TodoItem todoItem)
        {
            var existingItem = _todoItems.FirstOrDefault(item => item.Id == id);
            if (existingItem == null)
            {
                return NotFound();
            }
            existingItem.Name = todoItem.Name;
            existingItem.IsComplete = todoItem.IsComplete;
            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(Guid id)
        {
            var existingItem = _todoItems.FirstOrDefault(item => item.Id == id);
            if (existingItem == null)
            {
                return NotFound();
            }
            _todoItems.Remove(existingItem);
            return NoContent();
        }
    }

    public class TodoItem
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public bool IsComplete { get; set; }
    }
}
