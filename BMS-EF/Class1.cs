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
        public int ShowNo { get; set; }
        public int? TicketsAvailable { get; set; }
        public Movie? Movies { get; set; }
        public DateTime? ShowTimings { get; set; }
    }
    public class  Admin
    {
        [Key]
        public int AdminId { get; set; }
        public string? AdminName { get; set; }
        public string? AdminPwd { set; get; }

    }
    
    public class MakePayment
    {
        [Key]
        public int PaymentId { get; set; }
        public int Amount { get; set; }
        public RegisterUser users { get; set; }
    }

    public class BMSDbcontext : DbContext
    {
        public DbSet<Movie> Movies { get; set; }
        public DbSet<RegisterUser> RegisterUsers { get; set; }
        public DbSet<BookTicket> BookTickets { get; set; }
        public DbSet<Admin> Admins { get; set; }
        
        public DbSet<MakePayment> makePayments { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"server=(localdb)\MSSQLLocalDB;database=BmsDb;trusted_connection=true");
        }

    }
}