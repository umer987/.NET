using Microsoft.Ajax.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication4
{
    public partial class update : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void updtbutt(object sender, EventArgs e)
        {
            string con = @"Data Source=DESKTOP-GV0G9FL\SQLEXPRESS;Initial Catalog=tests;Integrated Security=True;TrustServerCertificate=True";
            DataClasses1DataContext db = new DataClasses1DataContext(con);
            var ID = Convert.ToInt32(IDTOUPDATE.Text);
            emplyss obj = db.emplysses.SingleOrDefault(x => x.id == ID);

            if (obj != null) { 
                obj.name = TXTNAME.Text;
                obj.age = Convert.ToInt32(TXTAGE.Text);
                obj.department = TXTDPT.Text;   
    
                db.SubmitChanges();
            }
            









        }
    }
}