using BMS_EF;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMS_BL
{
    public class Booktickets
    {
        static BMSDbcontext dbContext = new BMSDbcontext();
        public static void bookticket(BMS_EF.BookTicket b)
        {
            dbContext.BookTickets.Add(new BMS_EF.BookTicket()
            {
                Movies = b.Movies,
                Cinema= b.Cinema,
                ShowNo= b.ShowNo,
                Seats= b.Seats,
                ShowTimings=b.ShowTimings
               
            });
            dbContext.SaveChanges();
        }

    }
}
