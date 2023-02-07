﻿using Microsoft.AspNetCore.Mvc;

namespace CityUpdatesAPI.Controllers
{
    [ApiController]
    [Route("api/cities")]
    public class CitiesControllercs: ControllerBase
    {
        [HttpGet]
        public JsonResult GetCities()
        {
            return new JsonResult(CitiesDataStore.Current.Cities);
        }

        [HttpGet("{id}")]
        public JsonResult GetCity(int id)
        {
            return new JsonResult(
                CitiesDataStore.Current.Cities.FirstOrDefault(c => c.Id == id));
        }
    }
}
