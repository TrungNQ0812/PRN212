using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutomobieLibrary.BussinessObject;
using AutomobieLibrary.DataAccess;
namespace AutomobieLibrary.Repository
{
    public class CarRepository
    {
        public Car GetCarByID(int carID) => CarDBContext.Instance.GetCarByID(carID);
        public IEnumerable<Car> GetCarṣ̣() => CarDBContext.Instance.GetCarList;
        public void InsertCar(Car car) => CarDBContext.Instance.addNew(car);
        public void DeleteCar(int carID) => CarDBContext.Instance.Remove(carId);
        public void UpdateCar(Car car) => CarDBContext.Instance.Update(car);
    }
}
