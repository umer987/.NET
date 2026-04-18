using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication3
{
    public partial class DELETE : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void btnDelete_Click(object sender, EventArgs e)
        {
            string con = @"Data Source=DESKTOP-GV0G9FL\SQLEXPRESS;Initial Catalog=abcds1;Integrated Security=True;TrustServerCertificate=True";
            DataClasses1DataContext db = new DataClasses1DataContext(con);
            int id = int.Parse(txtDelID.Text);
                 student obj = db.students.SingleOrDefault(s => s.ID == id);
            if (obj != null) {
                db.students.DeleteOnSubmit(obj);
                db.SubmitChanges();
            }
        }
    }
}