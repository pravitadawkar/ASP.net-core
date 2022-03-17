using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CRUDOprationRepo.Firstmodels
{
    public interface ICar
    {
        public List<Car> GetCars();
        public Car GetCar( int no);
        public void AddCar(Car car);
        public void UpdateCar(Car car);
        public void DeleteCar(Car car);
        public List<Car> Getcarbyname();
        public List<Car> GetGroupby();


    }
}
