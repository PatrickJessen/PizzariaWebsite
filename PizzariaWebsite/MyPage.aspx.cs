using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PizzariaWebsite
{
    public partial class MyPage : System.Web.UI.Page
    {
        UserManager um = new UserManager();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["Username"] != null)
            {
                for (int i = 0; i < um.GetUserInfo(Session["Username"].ToString()).Count; i++)
                {
                    MypageFirstName.Text = um.GetUserInfo(Session["Username"].ToString())[i].FirstName;
                    MyPageLastName.Text = um.GetUserInfo(Session["Username"].ToString())[i].LastName;
                    MyPageNumber.Text = um.GetUserInfo(Session["Username"].ToString())[i].PhoneNumber.ToString();
                    MyPageAdresse.Text = um.GetUserInfo(Session["Username"].ToString())[i].Adress;
                }
                LoginPage.InnerText = "Logout";
                MypageFirstName.Visible = true;
                MyPageLastName.Visible = true;
                MyPageNumber.Visible = true;
                MyPageAdresse.Visible = true;
                avatarLoginImg.Visible = true;
            }
        }
    }
}