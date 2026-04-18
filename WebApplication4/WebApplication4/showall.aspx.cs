using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication4
{
    public partial class showall : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string con = @"Data Source=DESKTOP-GV0G9FL\SQLEXPRESS;Initial Catalog=tests;Integrated Security=True;TrustServerCertificate=True";
            DataClasses1DataContext db = new DataClasses1DataContext(con);
            var res = from temp in db.emplysses
                      select new
                      {
                          temp.id,
                          temp.name,
                          temp.age,
                          temp.department,

                      };
                          GridView1.DataSource = res;
                            GridView1.DataBind();

      
        }
    }
}