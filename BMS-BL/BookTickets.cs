using BMS_EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMS_BL
{
    public class BookTickets
    {
        int TicketsAvailable {  get; set; }
         int MovieId {  get; set; }
       DateTime ShowTimimgs {  get; set; }

        public  bool SeatAvailabale(string mid)
        {
            if (TicketsAvailable>=1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


    }
}
