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
    public partial class Insert : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection();
        
        protected void Page_Load(object sender, EventArgs e)
        {
            con.ConnectionString = WebConfigurationManager.ConnectionStrings["database"].ConnectionString;
            con.Open();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("insert into student(ID,Name,Sem,Mob_No,email_id) values('"+ id.Text + "','" + name.Text + "','" + sem.Text + "','" + mob.Text + "','" + email.Text + "')", con);
                cmd.ExecuteNonQuery();
                con.Close();
                Label5.Text = "your data is stored";
                id.Text = "";
                name.Text = "";
                sem.Text = "";
                mob.Text = "";
                email.Text = "";

            }
            catch(Exception ex)
                {
                Label5.Text = ex.Message;
            }
        }
    }
}