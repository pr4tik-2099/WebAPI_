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
        public IHttpActionResult get()
        {
            List<Student_Db> students = new List<Student_Db>();
            DBContext db = new DBContext();
            students = db.get();
            return Ok(students);
        }
    }
}
