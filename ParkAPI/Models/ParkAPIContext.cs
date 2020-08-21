using Microsoft.EntityFrameworkCore;

namespace ParkApi.Models
{
    public class ParkApiContext : DbContext
    {
        public ParkApiContext(DbContextOptions<ParkApiContext> options)
            : base(options)
        {

        }
        public DbSet<Park> Parks { get; set; }
        protected override void OnModelCreating(ModelBuilder builder)
  {
    builder.Entity<Park>()
        .HasData(
            new Park { ParkId = 1, ParkName = "Crater Lake National Park", State = "Oregon", Rating = 5, Type = "National", Description = "Crater Lake inspires awe."},
            new Park { ParkId = 2, ParkName = "Tillamook State Forest", State = "Oregon", Rating = 5, Type = "State", Description = "There are seven developed fee-site campgrounds"},
            new Park { ParkId = 3, ParkName = "Grand Teton National Park", State = "Wyoming", Rating = 5, Type = "National", Description = "The stunning beauty and abundant wildlife."},
            new Park { ParkId = 4, ParkName = "Tallman Mountain State Park", State = "New York", Rating = 4, Type = "State", Description = "The park comprises wooded country overlooking the Hudson and Piermont Marsh."},
            new Park { ParkId = 5, ParkName = "Glacier National Park", State = "Montana", Rating = 5, Type = "National", Description = "Come and experience Glacier's pristine forests, alpine meadows, rugged mountains, and spectacular lakes."},
            new Park { ParkId = 6, ParkName = "Crater Lake National Park", State = "Oregon", Rating = 5, Type = "National", Description = "Crater Lake inspires awe."},
            new Park { ParkId = 7, ParkName = "Tillamook State Forest", State = "Oregon", Rating = 5, Type = "State", Description = "There are seven developed fee-site campgrounds, managed on a first-come, first-served basis"},
            new Park { ParkId = 8, ParkName = "Grand Teton National Park", State = "Wyoming", Rating = 5, Type = "National", Description = "The stunning beauty and abundant wildlife and plants found here have drawn humans to this place for more than 11,000 years"},
            new Park { ParkId = 9, ParkName = "Tallman Mountain State Park", State = "New York", Rating = 4, Type = "State", Description = "The park comprises wooded country overlooking the Hudson and Piermont Marsh."},
            new Park { ParkId = 10, ParkName = "Glacier National Park", State = "Montana", Rating = 5, Type = "National", Description = "Come and experience Glacier's pristine forests, alpine meadows, rugged mountains, and spectacular lakes."},
            new Park { ParkId = 11, ParkName = "Crater Lake National Park", State = "Oregon", Rating = 5, Type = "National", Description = "Crater Lake inspires awe."},
            new Park { ParkId = 12, ParkName = "Tillamook State Forest", State = "Oregon", Rating = 5, Type = "State", Description = "There are seven developed fee-site campgrounds, managed on a first-come, first-served basis"},
            new Park { ParkId = 13, ParkName = "Grand Teton National Park", State = "Wyoming", Rating = 5, Type = "National", Description = "The stunning beauty and abundant wildlife and plants found here have drawn humans to this place for more than 11,000 years"},
            new Park { ParkId = 14, ParkName = "Tallman Mountain State Park", State = "New York", Rating = 4, Type = "State", Description = "The park comprises wooded country overlooking the Hudson and Piermont Marsh."},
            new Park { ParkId = 15, ParkName = "Glacier National Park", State = "Montana", Rating = 5, Type = "National", Description = "Come and experience Glacier's pristine forests, alpine meadows, rugged mountains, and spectacular lakes."},
            new Park { ParkId = 16, ParkName = "Crater Lake National Park", State = "Oregon", Rating = 5, Type = "National", Description = "Crater Lake inspires awe."},
            new Park { ParkId = 17, ParkName = "Tillamook State Forest", State = "Oregon", Rating = 5, Type = "State", Description = "There are seven developed fee-site campgrounds, managed on a first-come, first-served basis"},
            new Park { ParkId = 18, ParkName = "Grand Teton National Park", State = "Wyoming", Rating = 5, Type = "National", Description = "The stunning beauty and abundant wildlife and plants found here have drawn humans to this place for more than 11,000 years"},
            new Park { ParkId = 19, ParkName = "Tallman Mountain State Park", State = "New York", Rating = 4, Type = "State", Description = "The park comprises wooded country overlooking the Hudson and Piermont Marsh."},
            new Park { ParkId = 20, ParkName = "Glacier National Park", State = "Montana", Rating = 5, Type = "National", Description = "Come and experience Glacier's pristine forests, alpine meadows, rugged mountains, and spectacular lakes."},
            new Park { ParkId = 21, ParkName = "Crater Lake National Park", State = "Oregon", Rating = 5, Type = "National", Description = "Crater Lake inspires awe."},
            new Park { ParkId = 22, ParkName = "Tillamook State Forest", State = "Oregon", Rating = 5, Type = "State", Description = "There are seven developed fee-site campgrounds, managed on a first-come, first-served basis"},
            new Park { ParkId = 23, ParkName = "Grand Teton National Park", State = "Wyoming", Rating = 5, Type = "National", Description = "The stunning beauty and abundant wildlife and plants found here have drawn humans to this place for more than 11,000 years"},
            new Park { ParkId = 24, ParkName = "Tallman Mountain State Park", State = "New York", Rating = 4, Type = "State", Description = "The park comprises wooded country overlooking the Hudson and Piermont Marsh."},
            new Park { ParkId = 25, ParkName = "Glacier National Park", State = "Montana", Rating = 5, Type = "National", Description = "Come and experience Glacier's pristine forests, alpine meadows, rugged mountains, and spectacular lakes."},
            new Park { ParkId = 26, ParkName = "Crater Lake National Park", State = "Oregon", Rating = 5, Type = "National", Description = "Crater Lake inspires awe."},
            new Park { ParkId = 27, ParkName = "Tillamook State Forest", State = "Oregon", Rating = 5, Type = "State", Description = "There are seven developed fee-site campgrounds, managed on a first-come, first-served basis"},
            new Park { ParkId = 28, ParkName = "Grand Teton National Park", State = "Wyoming", Rating = 5, Type = "National", Description = "The stunning beauty and abundant wildlife and plants found here have drawn humans to this place for more than 11,000 years"},
            new Park { ParkId = 29, ParkName = "Tallman Mountain State Park", State = "New York", Rating = 4, Type = "State", Description = "The park comprises wooded country overlooking the Hudson and Piermont Marsh."},
            new Park { ParkId = 30, ParkName = "Glacier National Park", State = "Montana", Rating = 5, Type = "National", Description = "Come and experience Glacier's pristine forests, alpine meadows, rugged mountains, and spectacular lakes."}
            
        );
      }
  }
}
