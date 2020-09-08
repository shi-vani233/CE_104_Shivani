using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace lab7_task4
{
    public partial class Delete : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if(sidtext.Text=="")
            {
                Label1.Text = "enter id first!";
            }
            DataClassesDataContext newdata = new DataClassesDataContext();
            Student stu = newdata.Students.SingleOrDefault(x => x.sid == Convert.ToInt32(sidtext.Text));
            newdata.Students.DeleteOnSubmit(stu);
            newdata.SubmitChanges();
            Label1.Text = "data related this sid is deleted!";
        }
    }
}