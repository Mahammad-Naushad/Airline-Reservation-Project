using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace Service
{
    /// <summary>
    /// Summary description for Payment
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class Payment : System.Web.Services.WebService
    {

        SOADBEntities soa = new SOADBEntities();
        public string HelloWorld()
        {
            return "Hello World";
        }
        [WebMethod]
        public bool InsertCard(string bank, long number, int cvv, DateTime expiry)
        {
            bool flag = false;
            try
            {
                var res = soa.CardInfoes.Where(x => x.BankName == bank && x.CardNumber == number && x.CVV == cvv && x.Expiry == expiry).SingleOrDefault();
                if (res != null)
                    flag = true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return flag;
        }
    }
}
