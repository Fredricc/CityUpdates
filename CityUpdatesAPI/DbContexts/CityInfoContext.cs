using CityUpdatesAPI.Entities;
using Microsoft.EntityFrameworkCore;

namespace CityUpdatesAPI.DbContexts
{
    public class CityInfoContext : DbContext
    {
        public DbSet<City> Cities { get; set; } = null!;
        public DbSet<PointOfInterest> PointsOfInterest { get; set; } = null!;

        public CityInfoContext(DbContextOptions<CityInfoContext> options) 
            : base(options) 
        { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<City>().HasData(
                new City("New York City")
                {
                    Id = 1,
                    Description = "The one with that big park."
                },
                new City("Antwerp")
                {
                    Id = 2,
                    Description = "The one with the cathedral that was never real finished.."
                },
                new City("Paris")
                {
                    Id = 3,
                    Description = "The one with that big tower."
                },
                new City("Nairobi")
                {
                    Id = 4,
                    Description = "The green city in the sun."
                }

                );
            modelBuilder.Entity<PointOfInterest>()
                .HasData(
                new PointOfInterest ("Central Park")
                {
                    Id = 1,
                    CityId = 1,
                    Description = "The most visited urban park in the united states"
                },
                new PointOfInterest("Empire State Building")
                {
                    Id = 2,
                    CityId = 1,
                    Description = "A 102-story skyscraper located in Midtown Manhatten."
                },
                new PointOfInterest("Cathedral")
                {
                    Id = 3,
                    CityId = 2,
                    Description = "A Gothic style cathedral, conceived by architects Jan"
                },
                new PointOfInterest("Times Towers")
                {
                    Id = 4,
                    CityId = 2,
                    Description = "The most visited urban park in the united states"
                },
                new PointOfInterest("Eiffel Tower")
                {
                    Id = 5,
                    CityId = 3,
                    Description = "A wrought iron lattice tower on the Champ de Mars, Named"
                },
                new PointOfInterest("The Louvre")
                {
                    Id = 6,
                    CityId = 3,
                    Description = "The world's largest museum."
                },
                new PointOfInterest("Two Rivers Mall")
                {
                    Id = 7,
                    CityId = 4,
                    Description = "East and Central Africa's largest mall"
                },
                new PointOfInterest("Nairobi National Park")
                {
                    Id = 8,
                    CityId = 4,
                    Description = "The biggest wildlife National park in the world located next to a city"
                }

                );
                base.OnModelCreating(modelBuilder);
        }

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseSqlite("connectionstring")
        //    base.OnConfiguring(optionsBuilder);
        //}
    }
}
