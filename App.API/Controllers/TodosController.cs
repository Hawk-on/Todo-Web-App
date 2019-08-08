using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using App.API.Data;

namespace App.API.Controllers
{
    // POST http://localhost:5000/api/values/5
    [Route("api/[controller]")]
    [ApiController]
    public class TodosController : ControllerBase
    {
        private readonly DataContext _context;
        public TodosController(DataContext context)
        {
            this._context = context;
        }

        // GET api/todos
        [HttpGet]
        public IActionResult GetTodoPoints()
        {
            var todos = _context.TodoPoints.ToList();

            return Ok(todos);
        }


        // GET api/todos/5
        [HttpGet("{id}")]
        public IActionResult GetTodoPoint(int id)
        {
            var todo = _context.TodoPoints.FirstOrDefault(x => x.Id == id);
            return Ok(todo);
        }

        // POST api/todos
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/todos/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/todos/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
