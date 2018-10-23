using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class UserEntity
    {
        public string Name { get; set; }
        public string Adress { get; set; }
        public long Contact { get; set; }
        public string  Gender { get; set; }
        public string  Email { get; set; }
        public int Age { get; set; }
        public int  UserId { get; set; }
        public string Pswd { get; set; }
    }

    public class JourneyEntity {
        public int JourneyId { get; set; }
        public string Source { get; set; }
        public string Destination { get; set; }
        public DateTime dDate { get; set; }
        public  decimal? Cost { get; set; }
        public string DeptTime { get; set; }
        public string ArrTime { get; set; }
    }

    public class TicketEntity
    {
        public int TicketId { get; set; }
        public int JourneyId { get; set; }
        
        public decimal? Price { get; set; }
        public string Class { get; set; }
        public string Status { get; set; }

       public decimal? Seats { get; set; }
        public string SeatsDetails { get; set; }
    }

    public class CardEntity {
        public string BankName { get; set; }
        public long  CardNumber { get; set; }
        public int CVV { get; set; }
        public DateTime Expiry { get; set; }
        public decimal Balance { get; set; }
    }
}
