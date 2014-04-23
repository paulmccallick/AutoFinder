using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AutoFinder.Api
{
    public interface ICarRepository
    {
        IEnumerable<Car> GetAllCars();


        Car GetCar(int id);
    }
    public class CarRepository:ICarRepository
    {
        public IEnumerable<Car> GetAllCars()
        {
            return new Car[] { new Car { Color = "red", Id = 1 }, new Car { Color = "blue", Id = 2 } };
        }

        public Car GetCar(int id)
        {
            return new Car { Color = "red", Id = id };
        }
    }


}
