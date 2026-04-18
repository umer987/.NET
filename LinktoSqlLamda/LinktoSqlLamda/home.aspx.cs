using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LinktoSqlLamda
{
    public partial class home : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string con = @"Data Source=DESKTOP-GV0G9FL\SQLEXPRESS;Initial Catalog=contactsLTSL;Integrated Security=True;TrustServerCertificate=True";
            DataClasses1DataContext db = new DataClasses1DataContext(con);
            GridView1.DataSource = from c in db.contacts select c;
            GridView1.DataBind();
        }
    }
}