using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace BMS_EF
{
    public class Movie
    {
        [Key]
        public int MovieId { get; set; }
        public string? MovieName {  get; set; }
        public DateTime? ReleaseDate { get; set; }
        public string? MovieLang {  get; set; }
        public string? Cinema { get; set; }

    }
    public class RegisterUser
    {
        [Key]
        public int UserId { get; set; }
        public string? UserName { get; set; }
        public int? PhNumber { get; set; }
    }
    public class BookTicket 
    {
        [Key]
        public int BookId { get; set; }
        public RegisterUser? Users {  get; set; }
        public Movie? Movies { get; set; }
        public string? Cinema { get; set; }

        public int? ShowNo { get; set; }
        public int? Seats { get; set; }
        
        public DateTime? ShowTimings { get; set; }
    }
    public class  Admin
    {
        [Key]
        public int AdminId { get; set; }
        public string? AdminName { get; set; }
        public string? AdminPwd { set; get; }

    }
    
   

    public class BMSDbcontext : DbContext
    {
        public DbSet<Movie> Movies { get; set; }
        public DbSet<RegisterUser> RegisterUsers { get; set; }
        public DbSet<BookTicket> BookTickets { get; set; }
        public DbSet<Admin> Admins { get; set; }
       
        

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"server=(localdb)\MSSQLLocalDB;database=Bookms;trusted_connection=true");
        }

    }
}