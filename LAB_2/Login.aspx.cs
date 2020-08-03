using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Lab4_task2
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            error.Visible = false;
        }

        protected void btnlogin_Click(object sender, EventArgs e)
        {
            if(textusername.Text=="admin" && textpassword.Text == "admin")
            {
                Response.Redirect("Home.aspx");
            }
            else
            {
                error.Visible = true;
            }
        }
    }
}