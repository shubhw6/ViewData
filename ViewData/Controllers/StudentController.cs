using Microsoft.AspNetCore.Mvc;
using ViewData.Models;

namespace ViewData.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Index()
        {

            ViewData["Name"] = "Shubh Verma";
            ViewBag.Name = "Shubh";
            ViewData["Age"] = 12;

            ViewData["NAmeList"]= new string[] { "Rajesh","Ajay","Amar"};


            Student student = new Student()
            {
                Id = 1,
                Name = "Akasha",
                Description = "Developer",
               
            };

            ViewData["StudentList"] = student;

            return View();
        }
    }
}
