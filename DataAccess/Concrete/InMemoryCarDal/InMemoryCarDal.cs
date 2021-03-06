﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;

namespace DataAccess.Concrete
{
    public class InMemoryCarDal : ICarDal
    {
        private List<Car> _cars;

        public InMemoryCarDal()
        {
            _cars = new List<Car>
            {
                new Car {Id = 1 , BrandId = 1 , ColorId = 1 , DailyPrice = 150  , ModelYear = 2017 , Plate = "35 af 12" , Description = "falanfilan"},
                new Car {Id = 2 , BrandId = 2 , ColorId = 1 , DailyPrice = 100  , ModelYear = 2015 , Plate = "35 af 11" , Description = "falanfilan"},
                new Car {Id = 3 , BrandId = 3 , ColorId = 2 , DailyPrice = 300  , ModelYear = 1997 , Plate = "35 af 10" , Description = "falanfilan"},
                new Car {Id = 4 , BrandId = 5 , ColorId = 2 , DailyPrice = 500  , ModelYear = 1997 , Plate = "35 af 09" , Description = "falanfilan"},
                new Car {Id = 5 , BrandId = 4 , ColorId = 3 , DailyPrice = 1000 , ModelYear = 1997 , Plate = "35 af 08" , Description = "falanfilan"}
            };
        }
        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(c => c.Id == car.Id);
            _cars.Remove(carToDelete);
        }

        public List<CarDetailDto> GetCarDetails(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetById(int carId)
        {
            return _cars.Where(c => c.Id == carId).ToList();
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(c => c.Id == car.Id);

            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;
            carToUpdate.ModelYear = car.ModelYear;
            carToUpdate.Plate = car.Plate;
            
        }
    }
}
