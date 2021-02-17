using System;
using System.Collections.Generic;
using System.Text;
using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete
{
    public class BrandManager : IBrandService
    {
        IBrandDal _brandDal;

        public BrandManager(IBrandDal brandDal)
        {
            _brandDal = brandDal;
        }

        public IResult Add(Brand brand)
        {
           _brandDal.Add(brand);
           return new SuccessResult(Messages.AddSuccess);
        }

        public IResult Delete(Brand brand)
        {
           _brandDal.Delete(brand);
           return new SuccessResult(Messages.DeleteSuccess);
        }

        public IDataResult<List<Brand>> GetAll()
        {
            _brandDal.GetAll();
            return new SuccessDataResult<List<Brand>>(Messages.ListSuccess);
        }

        public IResult Update(Brand brand)
        {
            _brandDal.Update(brand);
           return new SuccessResult(Messages.UpdateSuccess);
        }
    }
}
