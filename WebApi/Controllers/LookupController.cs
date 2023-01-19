using Microsoft.AspNetCore.Mvc;
using System.Diagnostics.Metrics;
using WebApi.Models;

namespace WebApi.Controllers
{
    public class LookupController : ControllerBase
    {

        [HttpGet("GetAllCities")]
        [ProducesResponseType(StatusCodes.Status200OK)]

        public IEnumerable<City> GetAllCities()
        {
            return new List<City>
            {
                new City { Id = 1, Label = "Boston", Description = "Beautiful" },
                new City { Id = 2, Label = "Baltimore", Description = "Beautiful" }
            };
        }
        [HttpGet("GetAllCountries")]
        [ProducesResponseType(StatusCodes.Status200OK)]

        public IEnumerable<Country> GetAllCountries()
        {
            return new List<Country>
            {
                    new Country { Id = 1, Label = "Canada", Description = "Beautiful" },
                    new Country { Id = 2, Label = "Colombia", Description = "Beautiful" }
            };
        }
        [HttpGet("GetAllStates")]
        [ProducesResponseType(StatusCodes.Status200OK)]

        public IEnumerable<State> GetAllStates()
        {
            return new List<State>
            {
                new State { Id = 1, Label = "Alabama", Description = "Beautiful" },
                new State { Id = 2, Label = "Colorado", Description = "Beautiful" }
            };

        }
    }
}
