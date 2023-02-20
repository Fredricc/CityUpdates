﻿using AutoMapper;
using CityUpdatesAPI.Models;
using CityUpdatesAPI.Services;
using Microsoft.AspNetCore.Mvc;

namespace CityUpdatesAPI.Controllers
{
    [ApiController]
    [Route("api/cities")]
    public class CitiesController : ControllerBase
    {
        private readonly ICityInfoRepository _cityInfoRepository;
        private readonly IMapper _mapper;

        public CitiesController(ICityInfoRepository cityInfoRepository,
            IMapper mapper)
        {
            _cityInfoRepository = cityInfoRepository ?? 
                throw new ArgumentNullException(nameof(cityInfoRepository));
            _mapper = mapper ?? 
                throw new ArgumentNullException(nameof(mapper));
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<CityWithoutPointsOfInterestDto>>> GetCities(
            string? name)
        {
            var cityEntities = await _cityInfoRepository.GetCitiesAsync(name);
            return Ok(_mapper.Map<IEnumerable<CityWithoutPointsOfInterestDto>>(cityEntities));
        }

        [HttpGet("{id}")]
        public async  Task<IActionResult> GetCity(
            int id, bool includePointOfInterest = false)
        {
            var city = await _cityInfoRepository.GetCityAsync(id, includePointOfInterest);
            if (city== null) 
            {
                return NotFound();
            }

            if (includePointOfInterest) 
            {
                return Ok(_mapper.Map<CityDto>(city));
            }

            return Ok(_mapper.Map < CityWithoutPointsOfInterestDto>(city));
        }
    }
}
