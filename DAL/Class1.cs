using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;

namespace DAL
{
    public class dal
    {
        SOADBEntities soa = new SOADBEntities();
        public bool Authenticate(int username, string password)
        {
            bool flag = false;
            try
            {
                var res = soa.Users.Where(u => u.UserId == username && u.Pswd == password).SingleOrDefault();
                if (res != null)
                    flag = true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return flag; 
        }

        public bool InsertToUser(UserEntity ue)
        {

            bool flag = false;
            try
            {
                User Dtable = new User();
                Dtable.Name = ue.Name;
                Dtable.Adress = ue.Adress;
                Dtable.Contact = ue.Contact;
                Dtable.Gender = ue.Gender;
                Dtable.Email = ue.Email;
                Dtable.Age = ue.Age;
                Dtable.UserId = ue.UserId;
                Dtable.Pswd = ue.Pswd;

                soa.Users.Add(Dtable);
                var res = soa.SaveChanges();

                if (res > 0)
                    flag = true;
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return flag;
        }

        public List<JourneyEntity> CheckFlights(string source, string dest, DateTime date)
        {
            List<JourneyEntity> lst = new List<JourneyEntity>();

            var res = soa.Journeys.Where(x => x.Source == source && x.Destination == dest && x.dDate == date);

            try
            {
                foreach (var r in res)
                {
                    JourneyEntity jn = new JourneyEntity();
                    jn.JourneyId = r.JourneyId;
                    jn.Source = r.Source;
                    jn.Destination = r.Destination;
                    jn.dDate = r.dDate;
                    jn.Cost = r.Cost;
                    jn.DeptTime = r.DeptTime;
                    jn.ArrTime = r.ArrTime;
                    lst.Add(jn);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return lst;
        }

        public bool CheckId(int id)
        {
            bool flag = false;

            try
            {
                var res = soa.Journeys.Where(x => x.JourneyId == id).SingleOrDefault();
                if (res != null)
                    flag = true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return flag;
        }

        public List<TicketEntity> generateTicket(TicketEntity te,float Factor,int p)
        { 
            
            List<TicketEntity> lst = new List<TicketEntity>();
            
            try
            {
                Ticket t = new Ticket();
                t.JourneyId = te.JourneyId;
               t.Seats = te.Seats;
                var price = soa.Journeys.Where(x => x.JourneyId == te.JourneyId).Select(x => x.Cost).SingleOrDefault();
                var total = (Convert.ToDecimal(Factor)* price)+p;
                t.Price = Convert.ToDecimal(total);
                t.Class = te.Class;
                t.Status = te.Status;
                t.SeatsDetails = te.SeatsDetails;

                var tm = soa.Tickets.Add(t);
                var res = soa.SaveChanges();
                if (res > 0)
                {
                    var r = soa.Tickets.Where(x => x.TicketId == tm.TicketId).SingleOrDefault();
                        TicketEntity tt = new TicketEntity();
                        tt.TicketId = r.TicketId;
                        tt.JourneyId = r.JourneyId;
                        tt.Seats = r.Seats;
                        tt.Price = r.Price;
                        tt.Class = r.Class;
                        tt.Status = r.Status;
                    tt.SeatsDetails = r.SeatsDetails;
                        lst.Add(tt);
                    
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return lst;
        }

        public bool CheckTicketID(int id)
        {
            bool flag = false;

            try
            {
                var res = soa.Tickets.Where(x => x.TicketId == id).SingleOrDefault();
                if (res != null)
                    flag = true;                
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return flag;
        }

        public List<JourneyEntity> Update(JourneyEntity je,int id)
        {
            List<JourneyEntity> lst = new List<JourneyEntity>();

            try
            {
                var res = (from j in soa.Journeys
                          join t in soa.Tickets
                          on j.JourneyId equals t.JourneyId
                          where t.TicketId == id
                          select new { JourneyID = j.JourneyId, Source = j.Source, Destination = j.Destination, Departure = j.DeptTime, Arrival = j.ArrTime, Cost= j.Cost }).SingleOrDefault();
                

                if (res!=null)
                {
                    je.JourneyId = res.JourneyID;
                    je.Source = res.Source;
                    je.Destination = res.Destination;
                    je.Cost = res.Cost;
                    je.DeptTime = res.Departure;
                    je.ArrTime = res.Arrival;
                    lst.Add(je);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return lst;
        }

        public bool CancelPayUpdate(int id,long number)
        {
            bool flag = false;
            
            try
            {
                var res = soa.Tickets.Where(x => x.TicketId == id).SingleOrDefault();
                if (res != null)
                {
                    var res1 = soa.CardInfoes.Where(x => x.CardNumber == number).SingleOrDefault();
                    res1.Balance = 0.5M * res1.Balance;
                    if (res1 != null)
                    {
                        CardEntity ce = new CardEntity();
                        ce.Balance = res1.Balance;
                        ce.BankName = res1.BankName;
                        ce.CardNumber = res1.CardNumber;
                        ce.CVV = res1.CVV;
                        ce.Expiry = res1.Expiry;
                        flag = true;
                    }
                }
            }
            catch (Exception ex) {
                throw ex;
            }

            return flag;
        }

        public bool getTicketID(int id)
        {
            bool flag = true;

            try
            {
                var res = soa.Tickets.Where(x => x.TicketId == id).SingleOrDefault();
                if (res != null)
                    flag = true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return flag;
        }

        public bool DeleteTicket(int id)
        {
            List<TicketEntity> lst = new List<TicketEntity>();
            bool flag = false;

            try
            {
                var res = soa.Tickets.Where(x => x.TicketId == id).SingleOrDefault();
                if (res != null)
                {
                    TicketEntity te = new TicketEntity();
                    te.TicketId = id;
                    te.JourneyId = res.JourneyId;
                    te.Price = res.Price;
                    te.Class = res.Class;
                    te.Status = res.Status;
                    te.Seats = res.Seats;
                    te.SeatsDetails = res.SeatsDetails;

                    lst.Remove(te);
                    var res1 = soa.SaveChanges();
                        if (res1 > 0) flag = true;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return flag;
        }

        public List<JourneyEntity> UpdateSchedule(string source, string dest, DateTime date)
        {
            List<JourneyEntity> lst = new List<JourneyEntity>();

            try
            {
                var res = soa.Journeys.Where(x => x.Source == source && x.Destination == dest && x.dDate == date);
                if (res != null)
                {
                    foreach (var r in res)
                    {
                        JourneyEntity je = new JourneyEntity();
                        je.JourneyId = r.JourneyId;
                        je.Source = r.Source;
                        je.Destination = r.Destination;
                        je.Cost = r.Cost;
                        je.DeptTime = r.DeptTime;
                        je.ArrTime = r.ArrTime;
                        lst.Add(je);
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return lst;
        }
    }
}
