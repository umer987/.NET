using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml.Linq;

namespace WebApplication3
{
    public partial class ADD : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           
        }
        protected void add_click(object sender, EventArgs e)
        {
            string con = @"Data Source=DESKTOP-GV0G9FL\SQLEXPRESS;Initial Catalog=abcds1;Integrated Security=True;TrustServerCertificate=True";
            DataClasses1DataContext db = new DataClasses1DataContext(con); 
            student obj = new student();
            obj.NAME = name1.Text;
            obj.AGE = age1.Text;
            obj.CITY = city1.Text;
            db.students.InsertOnSubmit(obj);
            db.SubmitChanges();
        }







    }
}