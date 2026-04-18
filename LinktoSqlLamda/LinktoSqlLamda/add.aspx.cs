using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LinktoSqlLamda
{
    public partial class add : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void Add_Button(object sender, EventArgs e)
        {
            string con = @"Data Source=DESKTOP-GV0G9FL\SQLEXPRESS;Initial Catalog=contactsLTSL;Integrated Security=True;TrustServerCertificate=True";
            DataClasses1DataContext db = new DataClasses1DataContext(con);
            contact newcont = new contact();
            newcont.first_name = TextBox1.Text;
            newcont.last_name = TextBox2.Text;
            newcont.phone_number = TextBox3.Text;
            db.contacts.InsertOnSubmit(newcont);
            db.SubmitChanges();




        }
    }
}