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
    public class ColorManager : IColorService
    {
        IColorDal _color;
        public ColorManager(IColorDal color)
        {
            _color = color;
        }
        public IResult Add(Color entity)
        {
            _color.Add(entity);
            return new SuccessResult(Messages.CarAddedOrDeletedOrUpdated);
        }

        public IResult Delete(Color entity)
        {
            _color.Delete(entity);
            return new SuccessResult(Messages.CarAddedOrDeletedOrUpdated);
        }
    }
}
