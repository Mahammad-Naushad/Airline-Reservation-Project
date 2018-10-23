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
    public partial class Payment : System.Web.UI.Page
    {
        bal b = new bal();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        string bank;
        protected void btnPayment_Click(object sender, EventArgs e)
        { 
            if (ddlBank.SelectedIndex == 1)
                bank = "HDFC";
            else if (ddlBank.SelectedIndex == 2)
                bank = "Canara";
            
           long number = long.Parse(txtCardNumber.Text);
            Session["CardNumber"] = Convert.ToInt64(number);
           int  cvv = int.Parse(txtCvv.Text);
            
            //Validation for Expiry Date 
            DateTime exipry = DateTime.Parse(txtExpiry.Text);
            {
                if (exipry < DateTime.Now)
                {
                    Response.Write("Card has been Expired");
                    ddlBank.SelectedIndex =0;
                    txtCardNumber.Text = "";
                    txtCvv.Text = "";
                }
             }

            try
            {
                localhost.Payment p = new localhost.Payment();
                localhost1.UpdateBalance update = new localhost1.UpdateBalance();
                var res = p.InsertCard(bank, number,cvv, exipry);
                if (res != true)
                {
                    Response.Write("Invalid Card Details");
                }
                else
                {
                    int id = Convert.ToInt32(Session["Ticket"]);

                    var res1 = update.UpdateBalance1(id);
                    if (res1==false)
                    {
                        Response.Write("Insufficient Balance");
                    }
                    else
                    {
                        Response.Redirect("AvailaibleFlights.aspx");
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        protected void txtCardNumber_TextChanged(object sender, EventArgs e)
        {

        }

        protected void txtConfirmTicket_Click(object sender, EventArgs e)
        {
            
        }

        protected void Unnamed1_Click(object sender, EventArgs e)
        {
            
        }
    }
}