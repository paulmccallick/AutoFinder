using System.Collections.Generic;
using System.Web.Http;

namespace AutoFinder.Api
{
    public interface ICarController
    {
    }

    public class CarController : ApiController, ICarController
    {
        private readonly CarRepository _carRepository;
        
        public CarController(CarRepository carRepository)
        {
            _carRepository = carRepository;
        }

        // GET api/<controller>
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<controller>/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<controller>
        public void Post([FromBody]string value)
        {
        }

        // PUT api/<controller>/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/<controller>/5
        public void Delete(int id)
        {
        }
    }
}