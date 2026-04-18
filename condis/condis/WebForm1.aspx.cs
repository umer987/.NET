using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace condis
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        string connStr = @"Data Source=DESKTOP-GV0G9FL\SQLEXPRESS;Initial Catalog=ops;Integrated Security=True;TrustServerCertificate=True";

        protected void btn_connected_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(connStr))
            {
                // Connected Architecture: Direct command execution
                SqlCommand cmd = new SqlCommand("INSERT INTO ops VALUES('" + txtid.Text + "', '" + txtname.Text + "')", con);
                con.Open(); // Must open manually
                cmd.ExecuteNonQuery(); // Fire and forget
                con.Close(); // Must close manually
            }
        }

        protected void btn_disconnected_Click(object sender, EventArgs e)
        {
            // Disconnected Architecture: Using DataAdapter as a bridge
            SqlConnection con = new SqlConnection(connStr);
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM ops", con);
            SqlCommandBuilder builder = new SqlCommandBuilder(da); // Auto-generates Insert/Update
            DataSet ds = new DataSet(); // In-memory database

            da.Fill(ds, "ops"); // Fetches data & closes connection automatically

            DataRow newRow = ds.Tables["ops"].NewRow(); // Create a new row
            newRow["ID"] = txtid.Text;
            newRow["name"] = txtname.Text;
            ds.Tables["ops"].Rows.Add(newRow); // Add to local table

            da.Update(ds, "ops"); // Sync local changes back to DB
        }
    }
}