using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Configuration;


namespace WebAPI_.Models
{
    public class DBContext
    {
        public string ConnectionString
        {
            get
            {
                return ConfigurationManager.ConnectionStrings["sqlconn"].ConnectionString;
            }
        }

        public List<Student_Db> get()
        {
            List<Student_Db> students = new List<Student_Db>();
            SqlConnection con = new SqlConnection(ConnectionString);
            con.Open();
            string query = "SELECT * FROM marks";
            SqlCommand cmd = new SqlCommand(query, con);
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Student_Db st = new Student_Db();
                st.Name = dr["Name"].ToString();
                st.RollNo = Convert.ToInt32(dr["Roll_no"]);
                st.Marks = Convert.ToInt32(dr["Marks"]);
                students.Add(st);
            }
            return students;
        }
    }
}