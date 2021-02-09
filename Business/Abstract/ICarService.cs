using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;
using Entities.DTOs;

namespace Business.Abstract
{
    public interface ICarService
    {
        List<Car> GetAll();
        List<Car> GetCarsByBrandId(int id);
        List<Car> GetCarsByDailyPrice(decimal minPrice, decimal maxPrice);
        List<Car> GetCarsByColorId(int id);
        List<CarDetailDto> GetCarDetailDto();
        List<CarDetailDto> GetCarDetailByBrandId(int id);
        List<CarDetailDto> GetCarDetailByColorId(int id);
        void Add(Car car);
        void Delete(Car car);
        void Update(Car car);
    }

}
