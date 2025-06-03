using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Mvc;
using WebAPI_.Models;

namespace WebAPI_.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        HttpClient client = new HttpClient();
        [HttpGet]
        public ActionResult GetStudents()
        {
            List<Student_Db> students = new List<Student_Db>();
            client.BaseAddress = new Uri("https://localhost:44324/api/StudentAPI");
            var response = client.GetAsync("StudentAPI");
            response.Wait();

            var test = response.Result;
            if(test.IsSuccessStatusCode)
            {
                var display = test.Content.ReadAsAsync<List<Student_Db>>();
                display.Wait();
                students = display.Result;
            }
            return View(students);
        }
    }
}