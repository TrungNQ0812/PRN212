using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutomobieLibrary.BussinessObject;

namespace AutomobieLibrary.Repository
{
    public interface ICarRepository
    {
        IEnumerable<Car> GetCars();
        Car GetCarByID(int carID);
        void InsertCar(Car car);
        void DeleteCar(int carID);
        void UpdateCar(Car car);
    }
}
