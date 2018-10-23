using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace Service
{
    /// <summary>
    /// Summary description for UpdateBalance
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class UpdateBalance : System.Web.Services.WebService
    {
        SOADBEntities soa = new SOADBEntities();

        
        public string HelloWorld()
        {
            return "Hello World";
        }

        [WebMethod]
        public bool UpdateBalance1(int id)
        {
            bool flag = false;

            try
            {
                var res = (from t in soa.Tickets
                           where t.TicketId == id
                           select new { Price = t.Price }).SingleOrDefault();
                var result = (from p in soa.CardInfoes
                              where p.Balance < res.Price
                              select new { BankName = p.BankName, CardNumber = p.CardNumber, CVV = p.CVV, Expiry = p.Expiry, Balance = p.Balance - res.Price }).SingleOrDefault();
                if (result != null)
                {
                    CardInfo ce = new CardInfo();
                    ce.BankName = result.BankName;
                    ce.CardNumber = result.CardNumber;
                    ce.CVV = result.CVV;
                    ce.Expiry = result.Expiry;
                    ce.Balance = result.Balance;

                    soa.CardInfoes.Add(ce);
                    var change = soa.SaveChanges();
                    if (change > 0)
                        flag = true;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return flag;
        }

        [WebMethod]
        public bool CancelPayment(int id,long number)
        {
            bool flag = true;
            try
            {
                var res = soa.Tickets.Where(x => x.TicketId == id).SingleOrDefault();
                if(res!=null)
                {
                    var result = soa.CardInfoes.Where(x => x.CardNumber == number).SingleOrDefault();
                    CardInfo ce = new CardInfo();
                    ce.Balance = 0.5M * result.Balance;
                    ce.BankName = result.BankName;
                    ce.CardNumber = result.CardNumber;
                    ce.CVV = result.CVV;
                    ce.Expiry = result.Expiry;
                    soa.CardInfoes.Add(ce);
                    var change = soa.SaveChanges();
                    if (change > 0)
                        flag = true;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return flag;
        }
    }
}
