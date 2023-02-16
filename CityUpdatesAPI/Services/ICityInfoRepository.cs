using CityUpdatesAPI.Entities;

namespace CityUpdatesAPI.Services
{
    public interface ICityInfoRepository
    {
        Task<IEnumerable<City>> GetCitiesAsync();
    }
}
