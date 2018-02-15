using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DevOps_Reg117209
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if ((txtUserId.Text == "DEVOPS") && (txtPwd.Text == "Wipro@123"))
            {
                Response.Redirect("MainPage.aspx");
            }
            else
            {
                Response.Write("UserId or Password entered is in correct");
            }
        }
    }
}