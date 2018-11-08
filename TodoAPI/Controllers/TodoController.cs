using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using TodoApi.Models;
using TodoAPI.Models;

namespace TodoApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TodoController : ControllerBase
    {

        private static readonly HttpClient _client = new HttpClient();
        private static readonly string _remoteUrl = "https://myFirstAzureWebApp1234.azurewebsites.net";

        private readonly TodoContext _context;

        public TodoController(TodoContext context)
        {
            _context = context;

            if (_context.TodoItems.Count() == 0)
            {
                // Create a new TodoItem if collection is empty,
                // which means you can't delete all TodoItems.
                _context.TodoItems.Add(new TodoItem { name = "Item1" });
                _context.SaveChanges();
            }
        }

        [HttpGet]
        public ActionResult<List<TodoItem>> GetAll()
        {
            var data = _client.GetStringAsync($"{_remoteUrl}/api/Todo").Result;
            return JsonConvert.DeserializeObject<List<TodoItem>>(data);
        }

        [HttpGet("{id}", Name = "GetTodo")]
        public ActionResult<TodoItem> GetById(long id)
        {
            var data = _client.GetStringAsync($"{_remoteUrl}/api/Todo/{id}").Result;
            return Content(data, "application/json");
        }

        [HttpPost]
        public IActionResult Create(TodoItem item)
        {
            var response = _client.PostAsJsonAsync($"{_remoteUrl}/api/Todo", item).Result;
            var data = response.Content.ReadAsStringAsync().Result;
            return Content(data, "application/json");
        }

        [HttpPut("{id}")]
        public IActionResult Update(long id, TodoItem item)
        {
            var res = _client.PutAsJsonAsync($"{_remoteUrl}/api/Todo/{id}", item).Result;
            return new NoContentResult();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(long id)
        {
            var res = _client.DeleteAsync($"{_remoteUrl}/api/Todo/{id}").Result;
            return new NoContentResult();
        }
    }
}