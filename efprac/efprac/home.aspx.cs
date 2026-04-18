using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace efprac
{
    public partial class home : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void Add_butt(object sender, EventArgs e)
        {
            house_records db = new house_records();
            db.owner_name = TextBox2.Text;
            db.house_address=TextBox3.Text;
            house_efEntities1 ef =  new house_efEntities1();
            ef.house_records.Add(db);
            ef.SaveChanges();






        }
    }
}