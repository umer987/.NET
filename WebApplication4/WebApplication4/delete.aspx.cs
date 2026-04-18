using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication4
{
    public partial class delete : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void dltbutt(object sender, EventArgs e)
        {
            string con = @"Data Source=DESKTOP-GV0G9FL\SQLEXPRESS;Initial Catalog=tests;Integrated Security=True;TrustServerCertificate=True";
            DataClasses1DataContext db = new DataClasses1DataContext(con);
            var ids = Convert.ToInt32(TXTDLT.Text);
            var dltrec = db.emplysses.SingleOrDefault(x => x.id == ids);
            db.emplysses.DeleteOnSubmit(dltrec);
            db.SubmitChanges();







        }
    }
}