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
using System.Text;

namespace lab6_task2
{

    public partial class Product : System.Web.UI.Page
    {


        protected void Page_Load(object sender, EventArgs e)
        {
            if(Session["userid"]==null)
            {
                Response.Redirect("Login.aspx");
            }
            SqlConnection con = new SqlConnection();
            con.ConnectionString = WebConfigurationManager.ConnectionStrings["Database"].ConnectionString;
            try
            {
                con.Open();
                SqlDataAdapter sqlda = new SqlDataAdapter("SELECT * FROM Product", con);
                DataTable tb = new DataTable();
                sqlda.Fill(tb);
                GridView1.DataSource = tb;
                GridView1.DataBind();
                con.Close();
            }
            catch(Exception ex)
            {
                Label2.Text = ex.Message;
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = WebConfigurationManager.ConnectionStrings["Database"].ConnectionString;
            int session_oid = 0;
            try
            {
                using (con)
                {
                    string command = "select (oid) from [Order]";
                    SqlCommand cmd1 = new SqlCommand(command, con);
                    con.Open();
                    SqlDataReader dtr = cmd1.ExecuteReader();
                    while (dtr.Read())
                    {
                        session_oid = Convert.ToInt32(dtr["oid"]);
                    }
                    session_oid++;
                    con.Close();
                }
            }
            catch (Exception ex)
            {
                Label2.Text += ex.Message;
            }

            Session["oid"] = session_oid;
            foreach (ListItem item in ListBox1.Items)
            {
                if (item.Selected)
                {
                    SqlConnection con2 = new SqlConnection();
                    con2.ConnectionString = WebConfigurationManager.ConnectionStrings["Database"].ConnectionString;
                    try
                    {
                        using (con2)
                        {
                            con2.Open();
                            string q1 = "select (pid) FROM [Product] where pname='" + item.Text + "'";
                            SqlCommand cmd2 = new SqlCommand(q1, con2);
                            SqlDataReader dtr2 = cmd2.ExecuteReader();
                            dtr2.Read();
                            int pid = Convert.ToInt32(dtr2["pid"].ToString());
                            con2.Close();

                            con2.Open();
                            string q2 = "insert into [Order] (oid ,pid ,userid) values(@oid ,@pid ,@userid )";
                            SqlCommand cmd3 = new SqlCommand(q2, con2);
                            cmd3.Parameters.AddWithValue("@oid", session_oid);
                            cmd3.Parameters.AddWithValue("@pid", pid);
                            cmd3.Parameters.AddWithValue("@userid", Convert.ToInt32(Session["userid"]));
                            cmd3.ExecuteNonQuery();
                        }
                    }
                    catch (Exception ex)
                    {
                        Label2.Text += ex.Message;
                    }
                }
            }
            Response.Redirect("Order.aspx");
        }
    }
}
