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
    public partial class Show : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection();
        protected void Page_Load(object sender, EventArgs e)
        {
            con.ConnectionString = WebConfigurationManager.ConnectionStrings["database"].ConnectionString;
            con.Open();
            SqlDataAdapter sqlda = new SqlDataAdapter("SELECT * FROM student", con);
            DataTable tb = new DataTable();
            sqlda.Fill(tb);
            GridView1.DataSource = tb;
            GridView1.DataBind();
        }
    }
}