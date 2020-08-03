using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
namespace Lab4_task2
{
    public partial class Image : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            image1.Visible = false;
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if(Button1.Text=="hide")
            {
                Button1.Text = "show";

                image1.Visible = false;
            }
            else
            {
                Button1.Text = "hide";

                image1.Visible = true;
            }
        }
    }
}