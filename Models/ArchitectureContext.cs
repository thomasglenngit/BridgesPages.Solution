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
                    new Bridge { BridgeId = 1, Name = "Golden Gate", Country = "USA", City = "San Francisco", DateOfConstruction = new DateTime(1933, 1, 5), Architect = "Joseph Strauss" }

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