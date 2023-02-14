using CityUpdatesAPI.Entities;
using Microsoft.EntityFrameworkCore;

namespace CityUpdatesAPI.DbContexts
{
    public class CityInfoContext : DbContext
    {
        public DbSet<City> Cities { get; set; } = null!;
        public DbSet<PointsOfInterest> PointsOfInterest { get; set; } = null!;
    }
}
