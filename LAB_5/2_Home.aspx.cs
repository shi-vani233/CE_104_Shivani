using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace lab5_task2
{
    public partial class _2_Home : System.Web.UI.Page
    {
        List<product> first;
        List<product> second;
    protected override void OnInit(EventArgs e)
        {
            first = new List<product>();
            second = new List<product>();
            product p1 = new product("TV", "Electronics", 30000);
            product p2 = new product("smartphone", "Electronics", 20000);
            product p3 = new product("headphone", "Electronics", 2000);
            product p4 = new product("The Guide", "Books", 500);
            product p5 = new product("Shantaram", "Books", 400);
            product p6 = new product("Wings of Fire", "Books", 300);
            product p7 = new product("Cherry Tree", "Books", 150);
            product p8 = new product("pendrive", "Electronics", 200);

            first.Add(p1);
            first.Add(p2);
            first.Add(p3);
            first.Add(p4);
            first.Add(p5);
            first.Add(p6);
            first.Add(p7);
            first.Add(p8);
            base.OnInit(e);
        }

        protected void Page_Load(object sender, EventArgs e)
        {
          
            if (Session["name"]==null)
            {
                Response.Redirect("2_Login.aspx");
            }
            else
            {
                Label1.Text = "Welcome  " + Session["name"] + "!";
            }
         
        }

        protected void RadioButtonList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            ListBox1.Items.Clear();
            if (RadioButtonList1.SelectedValue== "Electronics")
            {
                foreach(product i in first)
                {
                    if (i.category.ToString() == "Electronics")
                    {
                        ListBox1.Items.Add(new ListItem(i.name, i.price.ToString()));
                    }
                }
            }
            else if(RadioButtonList1.SelectedValue == "Books")
            {
                foreach (product i in first)
                {
                    if (i.category.ToString() == "Books") 
                    {
                        ListBox1.Items.Add(new ListItem(i.name, i.price.ToString()));
                    }
                }
            }
        }

        protected void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (product i in first)
            {
                if(i.name==ListBox1.SelectedItem.Text)
                {
                    ListBox2.Items.Add(new ListItem(i.name, i.price.ToString()));
                }
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            foreach(ListItem i in ListBox2.Items)
            {
                foreach(product j in first)
                {
                    if(i.Text==j.name)
                    {
                        second.Add(j);
                    }
                }
            }
            Session["order"] = second;
            Response.Redirect("2_Order.aspx");
        }
    }
}