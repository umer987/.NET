using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace llllssssllll
{
    public partial class update : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void upt(object sender, EventArgs e)
        {
            string con = @"Data Source=DESKTOP-GV0G9FL\SQLEXPRESS;Initial Catalog=students;Integrated Security=True;TrustServerCertificate=True";
            DataClasses1DataContext db = new DataClasses1DataContext(con);
            int id = Convert.ToInt32(TextBox4.Text);
            var res = db.students_records.SingleOrDefault(x => x.student_id == id);
            res.student_name = TextBox1.Text;
            res.father_name = TextBox2.Text;
            res.department = TextBox3.Text;
            db.SubmitChanges();


        }
    }
}