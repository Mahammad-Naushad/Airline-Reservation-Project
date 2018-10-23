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

    public partial class AvailaibleFlights : System.Web.UI.Page
    {
        bal b = new bal();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnCheckAvalaiblity_Click(object sender, EventArgs e)
        {
            string source = (txtSource.Text).ToUpper();
            string dest = txtDest.Text.ToUpper();
            DateTime date = DateTime.Parse(txtDate.Text);

            var res = b.CheckFlights(source, dest, date);
            if (res == null)
            {
                string myStringVariable = "Sorry!! There's no Available Flights";
                ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('" + myStringVariable + "');", true);
            }
            else
            {
                GridView1.DataSource = res;
                GridView1.DataBind();
            }
        }

        protected void btnBook_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(Session["Status"]) == 0)
            {
                Response.Redirect("SignUp.aspx");
            }
            else
            {
                int id = Convert.ToInt32(txtbook.Text);
                Session["JourneyID"]= Convert.ToInt32(txtbook.Text);
                var res = b.CheckId(id);
                if (res == false)
                    Response.Write("Invalid Journey ID");
                else
                {
                    //Response.Write("hello");
                    Response.Redirect("Ticket.aspx");
                }
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtReschedule.Text);
            try {
                var res = b.CheckTicketID(id);

                if (res == false)
                {
                    Response.Write("Invalid Ticket ID");
                    txtReschedule.Text = "";
                }
                else {
                    Session["TicketID"] = Convert.ToInt32(id);
                    Response.Redirect("UpdateTicket.aspx");
                }
                    
            } catch (Exception ex)
            {
                throw ex;
            }    
        }

        protected void Button2_Click(object sender, EventArgs e)
        {

        }

        protected void btnCancel_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtReschedule.Text);
            long number = Convert.ToInt64(Session["CardNumber"]);
            try
            {

                var res = b.CheckTicketID(id);
                if (res == false)
                {
                    Response.Write("Invalid Ticket ID");
                    txtReschedule.Text = "";
                }
                else
                {
                    var cancelUpdate = b.CancelPayUpdate(id,number);
                    if (cancelUpdate==false)
                    {
                        Response.Write("Could not Cancel Ticket!!");
                        txtReschedule.Text = "";
                    }
                    else {
                        Response.Write("50% Refunded!!");
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        protected void btnHome_Click(object sender, EventArgs e)
        {
            Response.Redirect("LogInPage.aspx");
        }
    }
}