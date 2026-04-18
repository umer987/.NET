using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace agpracef
{
    public partial class home : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void add(object sender, EventArgs e)
        {
            students_records obj = new students_records();
            obj.student_name = TextBox1.Text;
            obj.father_name= TextBox2.Text;
            obj.department= TextBox3.Text;
            studentsEntities db = new studentsEntities();
            db.students_records.Add(obj);
            db.SaveChanges();

        }
    }
}