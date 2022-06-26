using AutomobileLibrary.BussinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomobileLibrary.DataAccess
{
    public class CarDBContext
    {
        //initialize car list
        private static List<Car> CarList = new List<Car>()
        {
            new Car{CarID = 1, CarName = "CRV", Manufacturer = "Honda", Price = 3000, ReleaseYear = 2021 },
            new Car{CarID = 2, CarName = "Ford Focus", Manufacturer = "Ford", Price = 15000, ReleaseYear = 2022 }
        };
        //----------------------
        //using singleton pattern
        private static CarDBContext instance = null;
        private static readonly object instanceLock = new object();
        private CarDBContext() { }
        public static CarDBContext Instance
        {
            get
            {
                lock (instanceLock)
                {
                    if(instance == null)
                    {
                        instance = new CarDBContext();  
                    }
                    return instance;
                }
            }
        }
        //------------------------
        public List<Car> GetCarList => CarList;
        //------------------------
        public Car GetCarByID(int carID)
        {
            //using LINQ to object
            Car car = CarList.SingleOrDefault(pro => pro.CarID == carID);
            return car;

        }
        //------------------------
        // add a new car
        public void AddNew(Car car)
        {
            Car pro = GetCarByID(car.CarID);
            if(pro == null)
            {
                CarList.Add(car);
            }
            else
            {
                throw new Exception("car is already exists");
            }
        }

        // update a car
        public void Update(Car car)
        {
            Car c = GetCarByID(car.CarID);
            if(c != null)
            {
                var index = CarList.IndexOf(c);
                CarList[index] = car;

            }
            else
            {
                throw new Exception("Car does not already exists");

            }
        }


        // remove a car
        public void Remove(int carID)
        {
            Car p = GetCarByID(carID);
            if(p != null)
            {
                CarList.Remove(p);

            }
            else
            {
                throw new Exception("Car does not already exists");
            }
        }
    }
}
