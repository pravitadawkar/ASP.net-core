using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CRUDOprationRepo.DataBase;

namespace CRUDOprationRepo.Firstmodels
{
    public class CarRepo:ICar
    {
        Databasecontext _context;
        public CarRepo(Databasecontext context)
        {
            _context = context;
        }
        public List<Car> GetCars() {
           return _context.Cars.ToList();

        }
        public Car GetCar(int no) {
            return _context.Cars.FirstOrDefault(e => e.CarNo ==no);

        }
        public void AddCar(Car car) {
            _context.Add(car);
            _context.SaveChanges();
        }
        public void UpdateCar(Car car) {
            _context.Update(car);
            _context.SaveChanges();

        }
        public void DeleteCar(Car car)
        {
            _context.Remove(car);
            _context.SaveChanges();

        }
        public List<Car> Getcarbyname()
        {
            return _context.Cars.ToList();
        }
        public List<Car> GetGroupby()
        {
            return _context.Cars.ToList();
        }


    }
}
