using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TasksController : Controller
    {
        private readonly ILogger<TasksController> _logger;

        public TasksController(ILogger<TasksController> logger) =>
            _logger = logger;

        [HttpPost]
        public TaskItem Post(TaskItem model)
        {
            // TODO: Save in a database
            return model;
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
