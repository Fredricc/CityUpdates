using CityUpdatesAPI.Models;

namespace CityUpdatesAPI
{
    public class CitiesDataStore
    {
        public List<CityDto> Cities { get; set; }

        //public static CitiesDataStore Current { get; } = new CitiesDataStore();

        public CitiesDataStore() 
        {
            //init dummy data
            Cities = new List<CityDto>()
            {
                new CityDto()
                {
                    Id = 1,
                    Name = "New York City",
                    Description = "The one with that big park.",
                    PointsOfInterest = new List<PointOfInterestDto>()
                    {
                        new PointOfInterestDto()
                        {
                            Id = 1,
                            Name = "Central Park",
                            Description = "The most visited urban park in the United States."
                        },
                        new PointOfInterestDto()
                        {
                            Id = 2,
                            Name = "Empire State Building",
                            Description = "A 102-story skyscraper located in Midtown Manhattan."
                        }
                    }
    },
                new CityDto()
                {
                    Id = 2,
                    Name = "Nairobi",
                    Description = "The city at the green park.",
                    PointsOfInterest = new List<PointOfInterestDto>()
                    {
                        new PointOfInterestDto()
                        {
                            Id = 3,
                            Name = "Two Rivers Mall",
                            Description = "The biggest Mall in East and central Africa."
                        },
                        new PointOfInterestDto()
                        {
                            Id = 4,
                            Name = "Nairobi National Park",
                            Description = "The biggest wildlife National Park within a city."
                        }
                    }
                },
                new CityDto()
                {
                    Id = 3,
                    Name = "Anwerp",
                    Description = "The one with the cathedral that was never really finished.",
                    PointsOfInterest = new List<PointOfInterestDto>()
                    {
                        new PointOfInterestDto()
                        {
                            Id = 5,
                            Name = "EiFFel Tower",
                            Description = "A wronght irom lattice tower on the Champ de mars, named"
                        },
                        new PointOfInterestDto()
                        {
                            Id = 6,
                            Name = "The Louvre",
                            Description = "The world's largest museum."
                        }
                    }
                }
            };
        }
    }
}
