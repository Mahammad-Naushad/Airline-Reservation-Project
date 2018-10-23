using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BAL;
using Entity;

namespace UI_Design
{

    public partial class LogInPage : System.Web.UI.Page
    {
        bal b = new bal();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSignIn_Click(object sender, EventArgs e)
        {
        
        }

        protected void btnSignIn_Click1(object sender, EventArgs e)
        {

        }

        protected void btnSignIn_Click2(object sender, EventArgs e)
        {
            //Using a Session to determine whether User has LoggedIn or Not
            Session["Status"] = 0;
            int username = Convert.ToInt32(txtUserName.Text);
            string password = txtPassword.Text;

            var res=b.Authenticate(username, password);
            if (res == false)
            {
                Response.Write("Invalid Credentials");
            }
            else
            {
                Session["Status"] = 1;
                Response.Redirect("AvailaibleFlights.aspx");
            }
        }
    }
}