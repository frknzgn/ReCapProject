using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;
using Entities.Abstract;

namespace DataAccess.Abstract
{
    public interface ICarDal:IEntityRepository<Car>
    {
        

    }
}
