using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace lab5_task2
{
    public partial class _2_Order : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["name"] == null)
            {
                Response.Redirect("2_Login.aspx");

            }
            else
            {
                Label2.Text = "Welcome  " + Session["name"] + "!";
                double total = 0;
                List<product> order = (List<product>)Session["order"];
                if(order==null)
                {
                    Label1.Text = "you have  not ordered anything";
                }
                else
                {
                    foreach(product i in order)
                    {
                        ListBox1.Items.Add(new ListItem(i.name + "     of price     " + i.price.ToString()));
                        total += i.price;
                    }
                }
                Label1.Text = "Total ammount is    " + total.ToString();
            }
        }
    }
}