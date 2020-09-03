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
    public partial class Edit : System.Web.UI.Page
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
                    SqlCommand cmd = new SqlCommand("SELECT Name,Sem,Mob_No,email_id FROM student WHERE ID='" + id.Text + "'", con);
                    SqlDataReader sdr = cmd.ExecuteReader();
                    sdr.Read();
                    name.Text = sdr["Name"].ToString();
                    sem.Text = sdr["Sem"].ToString();
                    mob.Text = sdr["Mob_No"].ToString();
                    email.Text = sdr["email_id"].ToString();
                    Label6.Text = "";
                    con.Close();
                }
                catch (Exception ex)
                {
                    Label6.Text = ex.Message;
                }
            

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            if (id.Text != "")
            {
                try
                {
                    SqlCommand cmd2 = new SqlCommand("UPDATE student SET Name='" + name.Text + "',Sem='" + sem.Text + "',Mob_No='" + mob.Text + "',email_id='" + email.Text + "' where ID='" + id.Text + "'  ", con);
                    cmd2.ExecuteNonQuery();
                    cmd2.Dispose();
                    con.Close();
                    Label6.Text = "data is updated!";
                    id.Text = "";
                    name.Text = "";
                    sem.Text = "";
                    mob.Text = "";
                    email.Text = "";
                    
                }
                catch (Exception ex)
                {
                    Label6.Text = ex.Message;
                }
            }
            else
            {
                Label6.Text = "enter ID first!";
            }

        }
    }
}