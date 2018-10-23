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
    public partial class UpdateTicket : System.Web.UI.Page
    {
        bal b = new bal();
        protected void Page_Load(object sender, EventArgs e)
        {
            //Load the Existing Schedule when the Page Loads
            txtTicketID.Text = Session["TicketID"].ToString();
            int id = Convert.ToInt32(txtTicketID.Text);
            JourneyEntity te = new JourneyEntity();
            try
            {
                var res = b.Update(te,id);

                if (res != null)
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

        protected void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string source = txtSource.Text;
            string dest = txtDest.Text;
            DateTime date = Convert.ToDateTime(txtDate.Text);
            try
            {
                var res = b.UpdateSchedule(source, dest, date);
                if (res!=null)
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
    }
}