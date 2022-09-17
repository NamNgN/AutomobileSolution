using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutomobileLibary.DataAccess;
using AutomobileLibary.Repository;

namespace AutomobileLibary.Repository
{
    public class CarRepository : ICarRepository
    {
        public Car GetCarByID(int carID) => CarManagement.Instance.GetCarByID(carID);
        public IEnumerable<Car> GetCars() => CarManagement.Instance.getCarList();
        public void InsertCar(Car car) => CarManagement.Instance.addNew(car);
        public void DeleteCar(Car car) => CarManagement.Instance.Remove(car);
        public void UpdateCar(Car car) => CarManagement.Instance.Update(car);


    }
}
