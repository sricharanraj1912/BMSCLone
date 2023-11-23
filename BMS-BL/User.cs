using BMS_EF;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMS_BL
{
    public class User
    {
        public int Userid { get; set; }
        public string UserName { get; set; }
        public int Password { get; set; }

        BMSDbcontext dbContext = new BMSDbcontext();
        public BMS_EF.Movie Search (string mname)
        {
            var tobeupdated = dbContext.Movies
                   .ToList()
                   .Where((p) => p.MovieName == mname)
                   .FirstOrDefault();

            return tobeupdated;
        }
        

    }
}
