using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication2
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string con = @"Data Source=DESKTOP-GV0G9FL\SQLEXPRESS;Initial Catalog=newone;Integrated Security=True;TrustServerCertificate=True;";
            DataClasses1DataContext db = new DataClasses1DataContext(con);
            var obbs = from dumy in db.abcdes
                       select new
                       {
                           dumy.ID,
                           dumy.NAME,
                           dumy.CITY

                       };
            GridView1.DataSource = obbs;
            GridView1.DataBind();




        }
    }
}