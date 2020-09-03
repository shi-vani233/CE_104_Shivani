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
    public partial class Order : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["userid"] == null)
            {
                Response.Redirect("Login.aspx");
            }
            SqlConnection con = new SqlConnection();
            con.ConnectionString = WebConfigurationManager.ConnectionStrings["Database"].ConnectionString;
            con.Open();
            int total = 0;
            int oid = Convert.ToInt32(Session["oid"]);
            try
            {
                SqlCommand cmd = new SqlCommand("select * from [Product] where pid in (select (pid) from [Order] WHERE oid='" + oid + "')", con);
                SqlDataReader dr = cmd.ExecuteReader();
                while(dr.Read())
                {
                    Label1.Text += "PRODUCT:   " + dr["pname"].ToString()  + "<br>" + "DESCRIPTION:   " + dr["description"].ToString() + "<br>" +"COST:   " + dr["cost"].ToString() + "<br><br><br>";
                    total += Convert.ToInt32(dr["cost"]);
                }
                con.Close();

            }
            catch(Exception ex)
            {
                Label2.Text = ex.Message;
            }

            Label2.Text = "Total amount: " + total;
        }



    }
}