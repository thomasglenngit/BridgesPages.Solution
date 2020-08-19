using Microsoft.EntityFrameworkCore;
using System;


namespace Architecture.Models
{
    public class ArchitectureContext : DbContext
    {
        public ArchitectureContext(DbContextOptions<ArchitectureContext> options)
            : base(options)
        {
        }

        public DbSet<Bridge> Bridges { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Bridge>()
                .HasData(
                    new Bridge { BridgeId = 1, Name = "Golden Gate", Country = "USA", City = "San Francisco", StartDate = new DateTime(1933, 1, 5), EndDate = new DateTime(1937, 4, 19), Architect = "Joseph Strauss", Span = 1280 },
                    new Bridge { BridgeId = 2, Name = "Sydney Harbour", Country = "AUS", City = "Sydney", StartDate = new DateTime(1928, 7, 28), EndDate = new DateTime(1932, 1, 18), Architect = "John Bradfield", Span = 1149 },
                    new Bridge { BridgeId = 3, Name = "Akashi Kaikyo", Country = "JPN", City = "Kobe, Iwaya", StartDate = new DateTime(1988, 1, 1), EndDate = new DateTime(1998, 1, 1), Architect = "Satoshi Kashima", Span = 3911 },
                    new Bridge { BridgeId = 4, Name = "Millau Viaduct", Country = "FRA", City = "Millau", StartDate = new DateTime(2001, 10, 16), EndDate = new DateTime(2004, 12, 16), Architect = "Dr Michel Virlogeux", Span = 2460 },
                    new Bridge { BridgeId = 5, Name = "Brooklyn", Country = "USA", City = "Brooklyn, Manhattan", StartDate = new DateTime(1869, 1, 1), EndDate = new DateTime(1883, 1, 1), Architect = "John Augustus Roebling", Span = 18334 }
                );
        }
    }
}

// DateTime dateOnly = date1.Date;
//new DateTime(2015, 12, 31);

//  [HttpPost]
//     public ActionResult CheckOutBook(Patron patron, int[] BookId)
//     {
//       if(BookId.Length !=0)
//       {
//         foreach(int id in BookId)
//         {
//           DateTime today = DateTime.Now;
//           DateTime due = today.Add(new TimeSpan(30, 0, 0, 0));
//           _db.Checkouts.Add(new Checkout() { PatronId = patron.PatronId, BookId = id, DueDate = due});
//         }
//       }
//       _db.SaveChanges();
//       return RedirectToAction("Index");
//     }