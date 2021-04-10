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
        IDataResult<List<Car>> GetByBrandId(int id);
        IDataResult<List<Car>> GetByColordId(int id);
        IResult Add(Car car);
        IResult Update(Car car);
        IResult Delete(Car car);
        IDataResult<List<Car>> GetAll();
        IDataResult<Car> GetById(int id);            
        IDataResult<List<CarDetailDto>> GetCarDetailDtos();
        IResult AddTransactionalTest(Car car);

    }
}
