using System;
using Business.Concrete;
using DataAccess.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new EfCarDal());
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            ColorManager colorManager = new ColorManager(new EfColorDal());

            carManager.Add(new Car{BrandId = 1,ColorId = 1,Plate = "35aaa35",DailyPrice = 150,Description = "1.6,Manuel-Sedan",Id = 1,ModelYear = 2010});







        }
    }
}
