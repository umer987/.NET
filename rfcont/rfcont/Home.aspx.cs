using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace rfcont
{
    public partial class Home : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void Add_Butt(object sender, EventArgs e)
        {
            contact  db = new contact();
            db.fname = TextBox1.Text;
            db.lname = TextBox2.Text;
            db.number = TextBox3.Text;
            contactsEntities ent = new contactsEntities();
            ent.contacts.Add(db);
            ent.SaveChanges();
            Label4.Text = "ADD DATA SUCCESFULLY!";
        }

      
    }
}