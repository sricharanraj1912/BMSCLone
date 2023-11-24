using BMS_EF;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace BMS_BL
{
    public class User
    {
        public int Userid { get; set; }
        public string UserName { get; set; }
        public int Password { get; set; }

       static BMSDbcontext dbContext = new BMSDbcontext();
        public static BMS_EF.Movie Search (string mname)
        {
            var tobeupdated = dbContext.Movies
                   .ToList()
                   .Where((p) => p.MovieName == mname)
                   .FirstOrDefault();

           // Movie.Add(new BMS_EF.Movie { MovieName = "ISSEb", MovieLang = "kan", ReleaseDate = new DateTime(2014, 7, 16) });

            return tobeupdated;
        }

        public static void AddUser(BMS_EF.RegisterUser ru)
        {
            dbContext.RegisterUsers.Add(new BMS_EF.RegisterUser()
            {
                UserId = ru.UserId,
                UserName = ru.UserName, 
                PhNumber=ru.PhNumber

            });
            dbContext.SaveChanges();
        }

        // return type- BMS_EF.BookTicket         
        public static void bookicket(BMS_EF.BookTicket b)
            {
            
                dbContext.BookTickets.Add(new BMS_EF.BookTicket()
                {
                    Users = b.Users,
                    Movies = b.Movies,
                    Cinema = b.Cinema,
                    ShowNo = b.ShowNo,
                    Seats = b.Seats,
                    ShowTimings = b.ShowTimings
                    

                });
                dbContext.SaveChanges();
            //var tobeupdated = dbContext.BookTickets
            //.ToList()
            //       .Where((p) => p.Users ==b.Users)
            //       .FirstOrDefault();


            //return tobeupdated;
            }


        


    }
}
