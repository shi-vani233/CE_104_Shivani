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

namespace lab6_task2
{
    public partial class Login : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection();
        protected void Page_Load(object sender, EventArgs e)
        {
            con.ConnectionString = WebConfigurationManager.ConnectionStrings["Database"].ConnectionString;
            con.Open();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("select * from [User] where userid = @userid and password = @password", con);
                cmd.Parameters.AddWithValue("@userid", userid.Text);
                cmd.Parameters.AddWithValue("@password", pass.Text);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    Session["userid"] = userid.Text;
                    Response.Redirect("Product.aspx");
                }
                else
                {
                    Label3.Text = "Incorrect Userid or password!!";
                }
                con.Close();
            }
            catch(Exception ex)
            {
                Label3.Text = ex.Message;
            }
        }
    }
}