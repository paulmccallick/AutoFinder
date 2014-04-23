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
        private readonly ICarRepository _carRepository;
        
        public CarController(ICarRepository carRepository)
        {
            _carRepository = carRepository;
        }

        [Route("")]
        public IEnumerable<Car> Get()
        {
            return _carRepository.GetAllCars();
            
        }

        [Route("{id:int}")]
        public Car Get(int id)
        {
            return _carRepository.GetCar(id);
            
        }

        [Route("")]
        public void Post([FromBody]string value)
        {
        }


    }
}