using System;
using System.Web;
using System.Web.UI;
using System.Collections;

namespace MagicalShow_3rd_HandIn
{

    public partial class Default : System.Web.UI.Page
    {
        ArrayList staffList;
        ArrayList magicList;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["LoggedIn"] != null)
            {
                Response.Redirect("Overview.aspx");
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
        }

        public void button1Clicked(object sender, EventArgs args)
        {
            Response.Redirect("CreateStaff.aspx");
        }

        public void buttonNewMagician(object sender, EventArgs args)
        {
            Response.Redirect("CreateMagician.aspx");
        }

        public void buttonLoginClicked(object sender, EventArgs args)
        {
            Boolean loggedIn = false;
            string NameInput = TextBoxName.Text;
            string PasswordInput = TextBoxPassword.Text;
            LoginMsg.Text = "";

            for (int i = 0; i < staffList.Count; i++)
            {
                Staff s = (Staff)staffList[i];
                if (s.TryLogin(NameInput, PasswordInput))
                {
                    loggedIn = true;
                    Session["LoggedIn"] = s;
                }
            }
            if (!loggedIn)
            {
                for (int i = 0; i < magicList.Count; i++)
                {
                    Magician m = (Magician)magicList[i];
                    if (m.TryLogin(NameInput, PasswordInput))
                    {
                        loggedIn = true;
                        Session["LoggedIn"] = m;
                    }
                }
            }

            if (loggedIn)
            {
                Response.Redirect("Overview.aspx");
            }
            else
            {
                LoginMsg.Text = "Login failed wrong credentials!";
            }
        }
    }
}
