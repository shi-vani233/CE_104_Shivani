using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace lab5_task1
{
    public partial class _1_Cookie : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Label4.Text = "";
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            HttpCookie Cookie = new HttpCookie("myCookie");
            Cookie["name"] = txtname.Text;
            Cookie["email"] = txtemail.Text;
            Cookie["city"] = txtcity.Text;
            Response.Cookies.Add(Cookie);
            Label4.Text = "Your cookie is created";
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            HttpCookie Cookie = Request.Cookies["myCookie"];
            if(Cookie==null)
            {
                Label4.Text = "cookie not found";
            }
            else
            {
                Label4.Text = "name:    " + Cookie["name"].ToString() + "<br/>";
                Label4.Text += "email:    " + Cookie["email"].ToString() + "<br/>";
                Label4.Text += "city:    " + Cookie["city"].ToString() + "<br/>";
            }
               
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            Response.Cookies["myCookie"].Expires = DateTime.Now.AddYears(-1);
            Label4.Text = "cookie is deleted";
        }
    }
}