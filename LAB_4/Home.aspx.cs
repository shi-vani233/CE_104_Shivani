using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Lab4_task2
{
    public partial class Home : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ValidationSettings.UnobtrusiveValidationMode = UnobtrusiveValidationMode.None;
        }

        protected void btnsubmit_Click(object sender, EventArgs e)
        {
            Label11.Text ="Name = " + textname.Text;
            Label12.Text = "Age = " + textage.Text;
            Label13.Text = "Password = " + textpassword.Text;
            Label14.Text = "Confirm Password = " + textconfirm.Text;
            if (RadioButtonList1.SelectedValue != null)
            {
                Label15.Text="Gender = " + RadioButtonList1.SelectedItem.Value;
            }

            Label16.Text = "Mobile No. = " + mob.Text;
            Label17.Text = "Hobbies = ";
            for (int i = 0; i < CheckBoxList1.Items.Count; i++)
            {
                if (CheckBoxList1.Items[i].Selected)
                {
                    Label17.Text += " " + CheckBoxList1.Items[i].Value;
                }
            }
         if(DropDownList1.SelectedValue == "-1")
            {
                Label18.Text = "please select state !!!! ";
            }
         else
            {
                Label18.Text = "State = " + DropDownList1.SelectedItem.Value;
            }

            if (DropDownList2.SelectedValue == "-1")
            {
                Label19.Text = "please select city !!!! ";
            }
            else
            {
                Label19.Text = "city = " + DropDownList2.SelectedItem.Value;
            }
            Label20.Text = "PAN No = " + pan.Text;
        }

        protected void CustomValidator1_ServerValidate(object source, ServerValidateEventArgs args)
        {
            String pan = args.Value.ToString();
            if(pan.Length==10 && (pan.StartsWith("B") || pan.StartsWith("A")))
            {
                args.IsValid = true;
            }
            else
            {
                args.IsValid = false;
            }

        }
    }
}