using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LinktoSqlLamda
{
    public partial class update : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void Upsdate_butt(object sender, EventArgs e)
        {
            string con = @"Data Source=DESKTOP-GV0G9FL\SQLEXPRESS;Initial Catalog=contactsLTSL;Integrated Security=True;TrustServerCertificate=True";
            DataClasses1DataContext db = new DataClasses1DataContext(con);
            int id = Convert.ToInt32(TextBox4.Text);
            var res = db.contacts.SingleOrDefault(X => X.id == id);
            if(res != null){
                res.first_name= TextBox1.Text;
                res.last_name = TextBox2.Text;
                res.phone_number = TextBox3.Text;
                db.SubmitChanges();


            }
        }












    }
}