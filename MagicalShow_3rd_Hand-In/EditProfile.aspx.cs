using System;
using System.Web;
using System.Web.UI;
using System.Collections;
namespace MagicalShow_3rd_HandIn
{
    public partial class EditProfile : System.Web.UI.Page
    {
        Person p;
        Staff s;
        Magician m;
        ArrayList localList;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                if (Session["LoggedIn"] == null)
                {
                    Response.Redirect("Default.aspx");
                }

                p = (Person)Session["LoggedIn"];
                TextBoxName.Text = p.Name;

                if (Session["LoggedIn"].GetType().ToString() == "MagicalShow_3rd_HandIn.Staff")
                {
                    s = (Staff)Session["LoggedIn"];
                    LabelSpecific.Text = "Monthly salary:";
                    TextBoxSpecific.Text = s.Salary.ToString();
                }
                else if (Session["LoggedIn"].GetType().ToString() == "MagicalShow_3rd_HandIn.Magician")
                {
                    m = (Magician)Session["LoggedIn"];
                    LabelSpecific.Text = "Favorite Tricks:";
                    string tricks = "";
                    for (int i = 0; i < m.FavoriteTricks.Count; i++)
                    {
                        tricks += m.FavoriteTricks[i] + ",";
                    }
                    TextBoxSpecific.Text = tricks;
                }
            }
        }

        public void backButton(object sender, EventArgs args)
        {
            Response.Redirect("Profile.aspx");
        }

        public void editProfile(object sender, EventArgs args)
        {
            p = (Person)Session["LoggedIn"];
            if (TextBoxName.Text != "")
            {
                p.Name = TextBoxName.Text;
            }
            if (TextBoxPassword.Text != "")
            {
                p.Password = TextBoxPassword.Text;
            }

            if (Session["LoggedIn"].GetType().ToString() == "MagicalShow_3rd_HandIn.Staff")
            {
                s = (Staff)p;
                if (TextBoxSpecific.Text != "")
                {
                    s.Salary = Int32.Parse(TextBoxSpecific.Text);
                }

                localList = (ArrayList)Application["StaffCollection"];
                p = s;
            }
            else if (Session["LoggedIn"].GetType().ToString() == "MagicalShow_3rd_HandIn.Magician")
            {
                m = (Magician)p;
                if (TextBoxSpecific.Text != "")
                {
                    m.SetFavoriteTricks(TextBoxSpecific.Text);
                }

                localList = (ArrayList)Application["MagicCollection"];
                p = m;
            }

            int localListIndex = (int)Session["LoggedIndex"];
            localList[localListIndex] = p;
            Session["LoggedIn"] = p;
            Response.Redirect("Profile.aspx");
        }
    }
}
