using System;
using System.Web;
using System.Web.UI;
using System.Collections;
namespace MagicalShow_3rd_HandIn
{
    public partial class CreateMagician : System.Web.UI.Page
    {
        ArrayList localMagicList;
        protected void ButtonAdd_Click(object sender, EventArgs e)
        {
            Magician magic = new Magician(TextBoxMagic.Text, TextBoxName.Text, TextBoxPassword.Text);
            localMagicList = (ArrayList)Application["MagicCollection"];
            localMagicList.Add(magic);
            Response.Redirect("Default.aspx");
        }
    }
}
