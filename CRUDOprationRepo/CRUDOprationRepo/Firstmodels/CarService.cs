using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CRUDOprationRepo.Firstmodels
{
    public class CarService
    {
        ICar _service;
        public CarService(ICar service)
        {
            _service = service;
        }
        public List<Car> GetCars()
        {
            return _service.GetCars();
            //var filteredResult = from s in Car
            //                     where s.Age > 12 && s.Age < 20
            //                     select s.StudentName;

        }
        public Car GetCar(int no)
        {
            return _service.GetCar(no);

        }
        public void AddCar(Car car)
        {
            _service.AddCar(car);
        }
        public void UpdateCar(Car car)
        {
            _service.UpdateCar(car);
        }
        public void DeleteCar(Car car)
        {
            _service.DeleteCar(car);
        }
        public List<Car> Getcarbyname()
        {
            List<Car> cars = _service.GetCars();
          return  cars.OrderBy(c => c.CarName).ToList();
            //return _service.GetCars().OrderBy(c => c.CarName).ToList();
        }
        public List<Car> GetGroupby()
        {
            List<Car> result = (List<Car>)(from p in _service.GetCars() group p.CarName by p.CarModel into g select (carName: g.ToList(), CarModel: g.ToList()));
            return  result;
        }
        



    }
}
