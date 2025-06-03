using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebAPI_.Models;

namespace WebAPI_.Controllers
{
    public class StudentAPIController : ApiController
    {
        [HttpGet]
        public IHttpActionResult get()
        {
            List<Student_Db> students;
            DBContext db = new DBContext();
            students = db.get().ToList();
            return Ok(students);
        }

        [HttpGet]
        public IHttpActionResult get(int id) 
        {
            DBContext db = new DBContext();
            var students = db.get().Where(model => model.RollNo == id).FirstOrDefault();
            return Ok(students);
        }

        [HttpPost]
        public IHttpActionResult Add_Students(Student_Db stu)
        {
            DBContext db = new DBContext();
            return Ok();
        }
    }
}
