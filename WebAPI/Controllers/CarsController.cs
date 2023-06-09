using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarsController : ControllerBase
    {
        public List<Car> GetAll()
        {
            return new List<Car>
            {
                new Car { CarId = 10, BrandId = 1, Description = "iyi Araba" },
                new Car { CarId = 11, BrandId = 2, Description = "Kötü Araba" },
            };
        }
    }
}
