using Microsoft.AspNetCore.Mvc;
using StudentPortal.Models;
using StudentPortal.Services;

namespace StudentPortal.Controllers
{
	public class StudentsController : Controller
	{
		private readonly IRequestLogService _logService;

		public StudentsController(IRequestLogService logService)
		{
			_logService = logService;
		}

		public IActionResult Index()
		{
			List<Student> students = new List<Student>()
			{
				new Student{Id=1,Name="Aryan",Email="aryan@gmail.com"},
				new Student{Id=2,Name="Rahul",Email="rahul@gmail.com"},
				new Student{Id=3,Name="Simran",Email="simran@gmail.com"}
			};

			ViewBag.Logs = _logService.GetLogs();

			return View(students);
		}
	}
}