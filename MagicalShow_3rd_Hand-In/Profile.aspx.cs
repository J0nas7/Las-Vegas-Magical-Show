using System;
using System.Web;
using System.Web.UI;
using System.Collections;
namespace MagicalShow_3rd_HandIn
{
    public partial class Profile : System.Web.UI.Page
    {
        ArrayList localList;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["LoggedIn"] == null)
            {
                Response.Redirect("Default.aspx");
            }

            Person p = (Person)Session["LoggedIn"];
            TheName.Text = p.Name;

            if (Session["LoggedIn"].GetType().ToString() == "MagicalShow_3rd_HandIn.Staff")
            {
                Staff s = (Staff)Session["LoggedIn"];
                LabelSpecific.Text = "Monthly salary:";
                ListBoxSpecific.Items.Add(s.Salary + " DKK/month");
            }
            else if (Session["LoggedIn"].GetType().ToString() == "MagicalShow_3rd_HandIn.Magician")
            {
                Magician m = (Magician)Session["LoggedIn"];
                LabelSpecific.Text = "Favorite Tricks:";
                for (int i = 0; i < m.FavoriteTricks.Count; i++)
                {
                    ListBoxSpecific.Items.Add((string)m.FavoriteTricks[i]);
                }
            }
        }

        public void backButton(object sender, EventArgs args)
        {
            Response.Redirect("Overview.aspx");
        }

        public void editProfile(object sender, EventArgs args)
        {
            Response.Redirect("EditProfile.aspx");
        }

        public void deleteProfile(object sender, EventArgs args)
        {
            if (Session["LoggedIn"].GetType().ToString() == "MagicalShow_3rd_HandIn.Staff")
            {
                localList = (ArrayList)Application["StaffCollection"];
            }
            else if (Session["LoggedIn"].GetType().ToString() == "MagicalShow_3rd_HandIn.Magician")
            {
                localList = (ArrayList)Application["MagicCollection"];
            }

            localList.Remove(Session["LoggedIn"]);
            Session["LoggedIn"] = null;
            Response.Redirect("Default.aspx");
        }
    }
}
