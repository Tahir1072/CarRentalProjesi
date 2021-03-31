using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Conrete
{
    public class BrandManager : IBrandService
    {
        IBrandDal _brand;
        public BrandManager(IBrandDal brand)
        {
            _brand = brand;
        }
        public IResult Add(Brand entity)
        {
            _brand.Add(entity);
            return new SuccessResult();
        }

        public IResult Delete(Brand entity)
        {
            _brand.Delete(entity);
            return new SuccessResult(Messages.CarAddedOrDeletedOrUpdated);
        }
    }
}
