using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LinktoSqlLamda
{
    public partial class delete : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void Dlt_But(object sender, EventArgs e)
        {
            string con = @"Data Source=DESKTOP-GV0G9FL\SQLEXPRESS;Initial Catalog=contactsLTSL;Integrated Security=True;TrustServerCertificate=True";
            DataClasses1DataContext db = new DataClasses1DataContext(con);
            int id = Convert.ToInt32(TextBox1.Text);
            var dlt = db.contacts.SingleOrDefault(x => x.id == id);
            if(dlt != null){
                db.contacts.DeleteOnSubmit(dlt);
                db.SubmitChanges();


            }






        }
    }
}