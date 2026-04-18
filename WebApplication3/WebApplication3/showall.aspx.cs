using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication3
{
    public partial class showall : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string con = @"Data Source=DESKTOP-GV0G9FL\SQLEXPRESS;Initial Catalog=abcds1;Integrated Security=True;TrustServerCertificate=True";
            DataClasses1DataContext db = new DataClasses1DataContext(con);
            var data = from stdnt in db.students
                       select new
                       {
                           stdnt.ID,
                           stdnt.NAME,
                           stdnt.AGE,
                           stdnt.CITY

                       };

            GridView1.DataSource = data;
            GridView1.DataBind();


        }
    }
}