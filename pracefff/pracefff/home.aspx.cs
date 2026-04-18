using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace pracefff
{
    public partial class home : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void add_butt(object sender, EventArgs e)
        {
           contact obj = new contact();
            obj.fname = TextBox1.Text;
            obj.lname= TextBox2.Text;
            obj.number= TextBox3.Text;
            contactsEntities1 db = new contactsEntities1();
            db.contacts.Add(obj);
            db.SaveChanges();
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}