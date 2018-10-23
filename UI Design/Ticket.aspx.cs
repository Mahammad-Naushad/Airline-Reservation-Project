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
    public partial class Ticket : System.Web.UI.Page
    {
        bal b = new bal();
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void btnGeneate_Click(object sender, EventArgs e)
        {
                      
        }

        protected void btnGenerate_Click(object sender, EventArgs e)
        {
            TicketEntity te = new TicketEntity();
            te.JourneyId = Convert.ToInt32(Session["JourneyID"]);
            te.Seats = Convert.ToDecimal(txtCount.Text);
            decimal Seats= Convert.ToDecimal(txtCount.Text);
            te.Class = "Economy";
            te.Status = "Success";
            string Info = "";

            //Validation Number of Seats should be equal to Seats Selected
            do {
                if (cbA1.Checked)
                {
                    --Seats;
                    if (Seats < 0)
                    {
                        Response.Write("Seat selection Exceeded");
                        break;
                    }
                    Info += cbA1.Text + " ";
                }
               else txtA1.ReadOnly = true;

                if (cbA2.Checked)
                {
                    --Seats;
                    if (Seats < 0)
                    {
                        Response.Write("Seat selection Exceeded");
                        break;
                    }
                    Info += cbA2.Text + " ";
                }
                else txtA2.ReadOnly = true;

                if (cbA3.Checked)
                {
                    --Seats;
                    if (Seats < 0)
                    {
                        Response.Write("Seat selection Exceeded");
                        break;
                    }
                    Info += cbA3.Text + " ";
                }
                else txtA3.ReadOnly = true;

                if (cbB1.Checked)
                {
                    --Seats;
                    if (Seats < 0)
                    {
                        Response.Write("Seat selection Exceeded");
                        break;
                    }
                    Info += cbB1.Text + " ";
                }
                else txtB1.ReadOnly = true;

                if (cbB2.Checked)
                {
                    --Seats;
                    if (Seats < 0)
                    {
                        Response.Write("Seat selection Exceeded");
                        break;
                    }
                    Info += cbB2.Text + " ";
                }
               else txtB2.ReadOnly = true;

                if (cbB3.Checked)
                {
                    --Seats;
                    if (Seats < 0)
                    {
                        Response.Write("Seat selection Exceeded");
                        break;
                    }
                    Info += cbB3.Text + " ";
                }
                else txtB3.ReadOnly = true;
            } while (Seats>0);
            te.SeatsDetails = Info;
            
            //Factor acts as a multiplier for Calculation of Total fare
            float Factor = 0;
            if (txtA1.ReadOnly == false)
            {
                int age = int.Parse(txtA1.Text);
                if (age >= 12) { Factor += 1; }
                else if (age <= 2) { Factor += 0.5f; }
                else Factor += 0.75f;
            }
            if (txtA2.ReadOnly == false)
            {
                int age = int.Parse(txtA2.Text);
                if (age >= 12) { Factor += 1; }
                else if (age <= 2) { Factor += 0.5f; }
                else Factor += 0.75f;
            }
            if (txtA3.ReadOnly == false)
            {
                int age = int.Parse(txtA3.Text);
                if (age >= 12) { Factor += 1; }
                else if (age <= 2) { Factor += 0.5f; }
                else Factor += 0.75f;
            }
            if (txtB1.ReadOnly == false)
            {
                int age = int.Parse(txtB1.Text);
                if (age >= 12) { Factor += 1; }
                else if (age <= 2) { Factor += 0.5f; }
                else Factor += 0.75f;
            }
            if (txtB2.ReadOnly == false)
            {
                int age = int.Parse(txtB2.Text);
                if (age >= 12) { Factor += 1; }
                else if (age <= 2) { Factor += 0.5f; }
                else Factor += 0.75f;
            }
            if (txtB3.ReadOnly == false)
            {
                int age = int.Parse(txtB3.Text);
                if (age >= 12) { Factor += 1; }
                else if (age <= 2) { Factor += 0.5f; }
                else Factor += 0.75f;
            }

            //200Rs is added if it is between 5:30 to 10:30 and 18:00 to 23:00 
            int WindowSeatprice = 0;
            if (te.JourneyId == 121 || te.JourneyId == 128 || te.JourneyId == 156)
            {
                if(cbA1.Checked)
                WindowSeatprice += 200;
                if (cbA3.Checked)
                WindowSeatprice += 200;
                if (cbB1.Checked)
                 WindowSeatprice += 200;
                if (cbB3.Checked)
                WindowSeatprice += 200;
            } 

            try
            {
                var res = b.generateTicket(te,Factor,WindowSeatprice);
                if (res == null)
                {
                    Response.Write("Error occured!!");
                    Response.Redirect("AvailaibleFlights.aspx");
                }
                else
                {
                    GridView1.DataSource = res;
                    GridView1.DataBind();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {

        }

        protected void btnCancel_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(Session["TicketID"]);
            try
            {
                var res = b.DeleteTicket(id);
                if (res)
                {
                    Response.Redirect("AvailaibleFlights.aspx");
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        protected void btnPay_Click(object sender, EventArgs e)
        {
            Response.Redirect("Payment.aspx");
        }
    }
}