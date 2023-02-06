using Microsoft.AspNetCore.Mvc;

namespace CityUpdatesAPI.Controllers
{
    [ApiController]
    public class CitiesControllercs: ControllerBase
    {
        public JsonResult GetCities()
        {
            new JsonResult(
                new List<object>{
                new { id = 1, Name = "New York City"},
                new { id = 2, Name = "Nairobi"}
                });
        }
    }
}
