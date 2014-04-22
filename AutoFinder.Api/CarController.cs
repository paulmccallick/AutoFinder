using System.Collections.Generic;
using System.Web.Http;

namespace AutoFinder.Api
{
    public interface ICarController
    {
    }
    [RoutePrefix("api/car")]
    public class CarController : ApiController, ICarController
    {
        private readonly CarRepository _carRepository;
        
        public CarController(CarRepository carRepository)
        {
            _carRepository = carRepository;
        }

        [Route("")]
        public IEnumerable<Car> Get()
        {
            return new Car[] { new Car { Color = "red", Id = 1 }, new Car { Color = "blue", Id = 2 } };
        }

        [Route("{id:int}")]
        public Car Get(int id)
        {
            return new Car{Color="red",Id = id};
        }

        [Route("")]
        public void Post([FromBody]string value)
        {
        }


    }
}