using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication3
{
    public partial class UPDATE : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void update_click (object sender, EventArgs e)
        {
            string con = @"Data Source=DESKTOP-GV0G9FL\SQLEXPRESS;Initial Catalog=abcds1;Integrated Security=True;TrustServerCertificate=True";
            DataClasses1DataContext db = new DataClasses1DataContext(con);
            int id = int.Parse(dltid.Text);
            student obj = db.students.SingleOrDefault(x => x.ID == id);
            if (obj != null) { 
            obj.NAME = name2.Text;
                obj.AGE= age2.Text;
                obj.CITY = city2.Text;
               db.SubmitChanges();


            }
        }


    }
}