using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace llllssssllll
{
    public partial class create : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void add(object sender, EventArgs e)
        {
            string con = @"Data Source=DESKTOP-GV0G9FL\SQLEXPRESS;Initial Catalog=students;Integrated Security=True;TrustServerCertificate=True";
            DataClasses1DataContext db = new DataClasses1DataContext(con);  
            students_record obj = new students_record();
            obj.student_name = TextBox1.Text;
            obj.father_name= TextBox2.Text; 
            obj.department= TextBox3.Text;
            db.students_records.InsertOnSubmit(obj);
            db.SubmitChanges();









        }

        
    }
}