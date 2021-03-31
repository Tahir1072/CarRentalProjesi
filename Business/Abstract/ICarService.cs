using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ICarService
    {
        IDataResult<List<Car>> GetAll();
        IDataResult<List<Car>> GetById(int id);
        IDataResult<List<CarDetailsDto>> GetByCarDetails(); 
        IResult Add(Car entity);
        IResult Delete(Car entity);
        IResult Update(Car entity);
        IResult DeleteById(int id);


    }
}
