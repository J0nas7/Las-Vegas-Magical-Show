using System;
using System.Collections;
using System.Web;
using System.Web.UI;
namespace MagicalShow_3rd_HandIn
{
    public partial class CreateStaff : System.Web.UI.Page
    {
        ArrayList localStaffList;
        protected void ButtonAdd_Click(object sender, EventArgs e)
        {
            Staff staff = new Staff(Int32.Parse(TextBoxSalary.Text), TextBoxName.Text, TextBoxPassword.Text);
            localStaffList = (ArrayList)Application["StaffCollection"];
            localStaffList.Add(staff);
            Response.Redirect("Default.aspx");
        }
    }
}