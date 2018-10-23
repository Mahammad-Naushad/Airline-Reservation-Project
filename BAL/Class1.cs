using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Entity;

namespace BAL
{
    public class bal
    {
        dal d = new dal();

        public bool Authenticate(int username, string password)
        {
            return d.Authenticate(username, password);
        }

        public bool InsertToUser(UserEntity ue)
        {
            return d.InsertToUser(ue);
        }

        public List<JourneyEntity> CheckFlights(string source, string dest, DateTime date)
        {
            return d.CheckFlights(source, dest, date);
        }

        public bool CheckId(int id)
        {
           return  d.CheckId(id);
        }

        public List<TicketEntity> generateTicket(TicketEntity te, float Factor,int price)
        {
            return d.generateTicket(te,Factor,price);
        }

        public bool CheckTicketID(int id)
        {
            return d.CheckTicketID(id);
        }

        public List<JourneyEntity> Update(JourneyEntity te,int id)
        {
            return d.Update(te,id);
        }

        public bool CancelPayUpdate(int id,long number)
        {
            return d.CancelPayUpdate(id,number);
        }

        public bool getTicketID(int id)
        {
            return getTicketID(id);
        }

        public bool DeleteTicket(int id) {
            return d.DeleteTicket(id);
        }

        public List<JourneyEntity> UpdateSchedule(string source, string dest, DateTime date)
        {
            return d.UpdateSchedule(source, dest, date);
        }
    }
}
