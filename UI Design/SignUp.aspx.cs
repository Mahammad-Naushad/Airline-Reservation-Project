using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Entity;
using BAL;

namespace UI_Design
{
    public partial class SignUp : System.Web.UI.Page
    {
        bal b = new bal();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void TextBox5_TextChanged(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            UserEntity ue = new UserEntity();
            ue.Name = txtName.Text;
            ue.Adress = txtAddress.Text;
            ue.Contact = long.Parse(txtContact.Text);
            if (ddlGender.SelectedIndex == 1)
                ue.Gender = "Male";
            else if (ddlGender.SelectedIndex == 2)
                ue.Gender = "Female";
            ue.Email = txtEmail.Text;
            ue.Age = int.Parse(txtAge.Text);
            ue.UserId = int.Parse(txtUserName.Text);
            ue.Pswd = txtPassword.Text;
            try
            {
                var res = b.InsertToUser(ue);
                if (res == false)
                {
                    Response.Write("Sorry!! Unable to Register at the moment");
                }
                else
                {
                    Response.Redirect("LogInPage.aspx");
                }

                
            }
            catch (Exception ex)
            {
                throw ex;
            }
            
        }
    }
}