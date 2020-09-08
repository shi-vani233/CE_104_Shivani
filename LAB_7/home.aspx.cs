using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace lab7_task3
{
    public partial class home : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string URL = "product.aspx?";
            URL += "pid=" + Server.UrlEncode(TextBox1.Text);
            Response.Redirect(URL);
        }
    }
}