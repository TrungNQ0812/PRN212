using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutomobieLibrary.BussinessObject;

namespace AutomobieLibrary.Repository
{
    public class ICarRepository
    {
        IEnumerable<Car> GetCars();
        Car GetCarByID(int ID);
        void InsertCar(int carID);
        void DeleteCar(int carID);
        void UpdateCar(Car car);
    }
}
