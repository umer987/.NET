using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace agprac
{
    public partial class add : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void Add_butt(object sender, EventArgs e)
        {
            string con = @"Data Source=DESKTOP-GV0G9FL\SQLEXPRESS;Initial Catalog=contacts;Integrated Security=True;TrustServerCertificate=True";
            DataClasses1DataContext db = new DataClasses1DataContext(con);
            contact obj = new contact();
            obj.fname = TextBox1.Text;
            obj.lname= TextBox2.Text;
            obj.number= TextBox3.Text;
            db.contacts.InsertOnSubmit(obj);
            db.SubmitChanges();
        }
    }
}