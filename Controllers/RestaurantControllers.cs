using Microsoft.AspNetCore.Mvc;
using RestaurantManegmentSystem.Models;

namespace RestaurantManegmentSystem.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class RestaurantControllers
    {
        private readonly ILogger<RestaurantControllers> _logger;
        public RestaurantControllers(ILogger<RestaurantControllers> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "GetRestaurant")]
        public Restaurant Get()
        {
            var restaurant = new Restaurant();
            restaurant.Name = "program_Caffee_Faridun";
            restaurant.Address = "Khujand_I_Somoni20";

            var branch1 = new Branch();
            branch1.Address = "Station";

            var branch2 = new Branch();
            branch2.Address = "Univermag";

            restaurant.Branchs.Add(branch1);
            restaurant.Branchs.Add(branch2);

            return restaurant;
        }
    }
}
