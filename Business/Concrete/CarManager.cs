﻿using System;
using System.Collections.Generic;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        ICarDal _carDal;

        public CarManager(ICarDal carDal)
        { 
            _carDal= carDal;
        }

        public void Add(Car car)
        {
            if (car.Plate.Length>=5 && car.DailyPrice>=0 )
            {
                _carDal.Add(car);
            }
            else
            {
                throw new Exception("Araç plakası 2 karakterden büyük olmalı ve günlük ücreti 0'dan büyük olmalı.");
            }
        }

        public void Delete(Car car)
        {
           _carDal.Delete(car);
        }

        public List<Car> GetAll()
        {
            return _carDal.GetAll();
        }

        public List<CarDetailDto> GetCarDetailByBrandId(int id)
        {
            return _carDal.GetCarDetails(c => c.BrandId == id);
        }

        public List<CarDetailDto> GetCarDetailByColorId(int id)
        {
            return _carDal.GetCarDetails(c => c.ColorId == id);
        }

        public List<CarDetailDto> GetCarDetailDto()
        {
            return _carDal.GetCarDetails();
        }

        public List<Car> GetCarsByBrandId(int id)
        {
            return _carDal.GetAll(c => c.BrandId == id);
        }

        public List<Car> GetCarsByColorId(int id)
        {
            return _carDal.GetAll(c => c.ColorId == id);
        }

        public List<Car> GetCarsByDailyPrice(decimal minPrice, decimal maxPrice)
        {
            return _carDal.GetAll(c => c.DailyPrice <= maxPrice && c.DailyPrice >= minPrice);
        }

        public void Update(Car car)
        {
            _carDal.Update(car);
        }
    }
}
