using Microsoft.AspNetCore.Mvc;

using Topicos_especiais.Models;

namespace Topicos_especiais.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            // Lógica para obter a lista de tarefas do Model
            List<TaskModel> tasks = GetTasksFromDatabase();
            return View(tasks);
        }

        private List<TaskModel> GetTasksFromDatabase()
        {
            return new List<TaskModel>
            {
                new TaskModel { TaskId = 1, TaskName = "Tarefa 1", IsCompleted = false },
                new TaskModel { TaskId = 2, TaskName = "Tarefa 2", IsCompleted = true },
            };
        }
    }
}
