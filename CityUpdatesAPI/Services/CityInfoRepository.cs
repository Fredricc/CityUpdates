using CityUpdatesAPI.Entities;

namespace CityUpdatesAPI.Services
{
    public class CityInfoRepository : ICityInfoRepository
    {
        public Task<IEnumerable<City>> GetCitiesAsync()
        {
            throw new NotImplementedException();
        }

        public Task<City?> GetCityAsync(int cityId)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<PointOfInterest>> GetPointOfInterestForCityAsync(
            int cityId)
        {
            throw new NotImplementedException();
        }

        public Task<PointOfInterest?> GetPointOfInterestForCityAsync(
            int cityId, int pointOfInterestId)
        {
            throw new NotImplementedException();
        }
    }
}
