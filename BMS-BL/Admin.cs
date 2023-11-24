using BMS_EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMS_BL
{
    public class Admin
    {
        public  int AdminId  { get; set; }
        public string AdminName { get; set;}

        public string AdminPwd { get; set;}

        static BMSDbcontext dbContext = new BMSDbcontext();
        public static void Add(BMS_EF.Movie m)
        {
            dbContext.Movies.Add(new BMS_EF.Movie()
            {
                MovieLang = m.MovieLang,
                ReleaseDate = m.ReleaseDate,
                MovieName = m.MovieName
            });
            dbContext.SaveChanges();

        }

        public static void Update(int mid, BMS_EF.Movie m)
        {
            var tobeupdated = dbContext.Movies
                   .ToList()
                   .Where((p) => p.MovieId == mid)
                   .FirstOrDefault();
            tobeupdated.MovieName = m.MovieName;
            tobeupdated.ReleaseDate = m.ReleaseDate;
            tobeupdated.MovieLang = m.MovieLang;
            dbContext.SaveChanges();
        }

        public static void Delete(int id)
        {
            var tobedeleted = dbContext.Movies.ToList().
                Where((p) => p.MovieId == id).FirstOrDefault();

            dbContext.Movies.Remove(tobedeleted);
            dbContext.SaveChanges();


        }

        

    }
}
