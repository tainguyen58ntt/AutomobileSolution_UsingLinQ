﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using AutomobileLibrary.BussinessObject;

namespace AutomobileLibrary.Repository
{
    public class ICarRepository
    {
        IEnumerable<Car> GetCars();

        Car GetCarByID(int carId);
        void InsertCar(Car car);
        void DeleteCar(int carId);
        void UpdateCar(Car car);



    }
}