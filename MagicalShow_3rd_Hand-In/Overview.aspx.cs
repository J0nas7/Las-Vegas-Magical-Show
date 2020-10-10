using System;
using System.Web;
using System.Web.UI;
using System.Collections;
namespace MagicalShow_3rd_HandIn
{
    public partial class Overview : System.Web.UI.Page
    {
        ArrayList staffList;
        ArrayList magicList;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["LoggedIn"] == null)
            {
                Response.Redirect("Default.aspx");
            }
            if (Application["StaffCollection"] == null)
            {
                staffList = new ArrayList();
                Application["StaffCollection"] = staffList;
            }
            if (Application["MagicCollection"] == null)
            {
                magicList = new ArrayList();
                Application["MagicCollection"] = magicList;
            }
            staffList = (ArrayList)Application["StaffCollection"];
            magicList = (ArrayList)Application["MagicCollection"];

            ListBoxOverview.Items.Add("MAGICIANS:");
            if (magicList.Count > 0)
            {
                for (int i = 0; i < magicList.Count; i++)
                {
                    ListBoxOverview.Items.Add(magicList[i].ToString());
                }
            }
            else
            {
                ListBoxOverview.Items.Add("No magicians");
            }
            ListBoxOverview.Items.Add("");

            if (Session["LoggedIn"].GetType().ToString() == "MagicalShow_3rd_HandIn.Staff")
            {
                ListBoxOverview.Items.Add("STAFF:");
                if (staffList.Count > 0)
                {
                    for (int i = 0; i < staffList.Count; i++)
                    {
                        ListBoxOverview.Items.Add(staffList[i].ToString());
                    }
                }
                else
                {
                    ListBoxOverview.Items.Add("No staff");
                }
            }
        }

        public void button1Clicked(object sender, EventArgs args)
        {
            Response.Redirect("Profile.aspx");
        }

        public void logOut(object sender, EventArgs args)
        {
            Session["LoggedIn"] = null;
            Response.Redirect("Default.aspx");
        }
    }
}
