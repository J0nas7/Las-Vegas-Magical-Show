using System;
using System.Web;
using System.Web.UI;
namespace MagicalShow_3rd_HandIn
{
    public partial class Profile : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["LoggedIn"] == null)
            {
                Session["LoggedIn"] = new Magician("Eye wiggle,Hand snap", "Bo", "hehe");
                //Response.Redirect("Default.aspx");
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
    }
}
