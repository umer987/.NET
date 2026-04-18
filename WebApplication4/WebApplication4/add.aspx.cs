using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication4
{
    public partial class add : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
          

        }




        protected void ADDbutt(object sender, EventArgs e)
        {
            string con = @"Data Source=DESKTOP-GV0G9FL\SQLEXPRESS;Initial Catalog=tests;Integrated Security=True;TrustServerCertificate=True";
            DataClasses1DataContext db = new DataClasses1DataContext(con);
            emplyss obj = new emplyss();
            obj.name = TXTNAME.Text;
            obj.department = TXTDPT.Text;
            obj.age = Convert.ToInt32(TXTAGE.Text);
            db.emplysses.InsertOnSubmit(obj);
            db.SubmitChanges();





        }
    }
}