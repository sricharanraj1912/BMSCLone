using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BMS_EF
{
    public class Movie
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int MovieId { get; set; }
        public string? MovieName {  get; set; }
        public DateTime? ReleaseDate { get; set; }
        public string? MovieLang {  get; set; }

        public string? Cinema {  get; set; }
      
    }
    public class RegisterUser
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int UserId { get; set; }
        public string? UserName { get; set; }
        
        public string? PhNumber { get; set; }
    }
    public class BookTicket 
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int BookId { get; set; }
        public int? Users {  get; set; }
        public int? Movies { get; set; }
        public string? Cinema { get; set; }
       
        public int? ShowNo { get; set; }
        public int? Seats { get; set; }
        
        public DateTime? ShowTimings { get; set; }
    }
    public class  Admin
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
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