using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutomobieLibrary.BussinessObject;
namespace AutomobieLibrary.DataAccess
{
    public class CarDBContext
    {
        //Initialize car list
        private static List<Car> CarList = new List<Car>()
        {
            new Car{
                CarID = 1, CarName="CRV", Manufacturer ="Honda",
                Price = 30000, ReleaseYear = 2021 },
            new Car{
                CarID = 2, CarName = "Ford Focus", Manufacturer = "Ford",
                Price = 15000, ReleaseYear = 2020}
        };

        //Using Singleton Pattern
        private static CarDBContext instance = null;
        private static readonly object instanceLock = new object();
        private CarDBContext() { }
        public static CarDBContext Instance
        {
            get
            {
                lock (instanceLock) {
                    if (instance == null)
                    {
                        instance = new CarDBContext();
                    }
                    return instance;
                }
            }
        }
        //--------------------------
        public List<Car> GetCarList => CarList;
        //--------------------------
        public Car GetCarByID(int carID)
        {
            //Using LINQ to Object
            Car car = CarList.SingleOrDefault(pro => pro.CarID == carID);
            return car;
        }

        //----------------------------------------
        //add new a car
        public void addNew(Car car)
        {
            Car pro = GetCarByID(car.CarID);
            if (pro == null)
            {
                CarList.Add(car);
            }
            else
            {
                throw new Exception("Car is already exists.");
            }
        }

        public void Update(Car car)
        {
            Car c = GetCarByID(car.CarID);
            if (c!=null)
            {
               var index = CarList.IndexOf(c);
                CarList[index] = car;
            }
            else
            {
                throw new Exception("Car does not already exists.");
            }
        }

        public void Remove(int carID)
        {
            Car p = GetCarByID(carID);
        }
    }
}   
