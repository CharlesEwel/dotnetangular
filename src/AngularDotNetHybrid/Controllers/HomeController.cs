using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using AngularDotNetHybrid.Models;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace AngularDotNetHybrid.Controllers
{
    public class HomeController : Controller
    {
        // GET: /<controller>/
        public ActionResult Index()
        {
            return View();
        }
        public string GetTasks()
        {
            Console.WriteLine("Get Tasks Fires CS");
            Models.Task task1 = new Models.Task { Id = 0, Description = "Walk the dog." };
            Models.Task task2 = new Models.Task { Id = 1, Description = "Grocery shopping." };
            List<Models.Task> tasks = new List<Models.Task>();
            tasks.Add(task1);
            tasks.Add(task2);
            var settings = new JsonSerializerSettings { ContractResolver = new CamelCasePropertyNamesContractResolver() };
            return JsonConvert.SerializeObject(tasks, Formatting.None, settings);
        }
        public IActionResult Test()
        {
            return View();
        }
    }
}

