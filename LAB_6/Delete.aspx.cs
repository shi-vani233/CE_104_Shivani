using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Web.Configuration;

namespace lab6_task1
{
    public partial class Delete : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection();
        protected void Page_Load(object sender, EventArgs e)
        {
            con.ConnectionString = WebConfigurationManager.ConnectionStrings["database"].ConnectionString;
            con.Open();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (id.Text!="")
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("Delete From student where ID='" + id.Text + "'", con);
                    cmd.ExecuteNonQuery();
                    cmd.Dispose();
                    con.Close();
                    Label2.Text = "Data is Deleted!!";
                    id.Text = "";
                }
                catch (Exception ex)
                {
                    Label2.Text = ex.Message;
                }
            }
            else
            {
                Label2.Text = "enter ID first!";
            }
        }
    }
}