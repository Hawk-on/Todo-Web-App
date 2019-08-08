using System.Linq;
using Microsoft.AspNetCore.Mvc;
using App.API.Data;
using Microsoft.AspNetCore.Authorization;

namespace App.API.Controllers
{
    [Authorize]
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


        [AllowAnonymous]
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
