using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace againlsls
{
    public partial class delete : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void dlt_butt(object sender, EventArgs e)
        {
            string con = @"Data Source=DESKTOP-GV0G9FL\SQLEXPRESS;Initial Catalog=students;Integrated Security=True;TrustServerCertificate=True";
            DataClasses1DataContext db = new DataClasses1DataContext(con);
            int id = Convert.ToInt32(TextBox1.Text);
            var res = db.students_records.SingleOrDefault(x => x.student_id == id);
            if (res != null) {
                db.students_records.DeleteOnSubmit(res);
                db.SubmitChanges(); 


            }
        }
    }
}