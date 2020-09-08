using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace lab7_task4
{
    public partial class Update : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            DataClassesDataContext newdata = new DataClassesDataContext();
            Student stu = newdata.Students.SingleOrDefault(x => x.sid == Convert.ToInt32(sidtext.Text));
            if(stu != null)
            {
                stu.name = nametext.Text;
                stu.sem = Convert.ToInt32(semtext.Text);
                stu.cpi = float.Parse(cpitext.Text);
                stu.contactno = decimal.Parse(notext.Text);
                stu.emailid = emailtext.Text;
                newdata.SubmitChanges();
                Label1.Text = "Data Updated for entered SID!";
            }
            else
            {
                Label1.Text = "This SID does not exist!";
            }
        }
    }
}