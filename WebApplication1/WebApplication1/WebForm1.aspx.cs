using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string con = @"Data Source=DESKTOP-GV0G9FL\SQLEXPRESS;Initial Catalog=sql1;Integrated Security=True;TrustServerCertificate=True;";
            DataClasses1DataContext db = new DataClasses1DataContext(con);

            var data = from doctors in db.doctors
                       select new
                       {
                           doctors.ID,
                           doctors.NAME,
                           doctors.QUALIFICATION,
                           doctors.CITY

                       };
            GridView1.DataSource = data;    
            GridView1.DataBind();   







        }
    }
}