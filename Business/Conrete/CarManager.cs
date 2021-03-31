using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Conrete
{
    public class CarManager : ICarService
    {
        ICarDal _car;
        public CarManager(ICarDal car)
        {
            _car = car;
        }

        public IResult Add(Car entity)
        {
            _car.Add(entity);
            return new SuccessResult(Messages.CarAddedOrDeletedOrUpdated);
        }

        public IResult Delete(Car entity)
        {
            _car.Delete(entity);
            return new SuccessResult(Messages.CarAddedOrDeletedOrUpdated);
        }

        public IResult DeleteById(int id)
        {
            _car.DeleteById(p => p.CarId == id);
            return new SuccessResult(Messages.CarAddedOrDeletedOrUpdated);
        }

        public IDataResult<List<Car>> GetAll()
        {
            return new SuccessDataResult<List<Car>>(_car.GetAll());
        }

        public IDataResult<List<CarDetailsDto>> GetByCarDetails()
        {
            return new SuccessDataResult<List<CarDetailsDto>>(_car.GetCarDetails());
        }

        public IDataResult<List<Car>> GetById(int id)
        {
            return new SuccessDataResult<List<Car>>(_car.GetAll(p =>p.CarId == id));
        }

        public IResult Update(Car entity)
        {
            _car.Update(entity);
            return new SuccessResult(Messages.CarAddedOrDeletedOrUpdated);
        }
    }
}
