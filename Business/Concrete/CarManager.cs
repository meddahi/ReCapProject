using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        ICarDal _carDal;        
        public CarManager(ICarDal carDal)
        {
            _carDal = carDal;
        }

        public IResult Add(Car car)
        {
            if (car.CarName.Length<2 && car.DailyPrice >=0)
            {
                return new ErrorResult(Messages.CantAdded);
            }

            _carDal.Add(car);
            
            return new SuccessResult(Messages.Added);
        }

        public IResult Delete(Car car)
        {
            return new SuccessResult(Messages.Deleted);
        }

        public IDataResult<List<Car>> GetAll()
        {
            //if (DateTime.Now.Hour == 21)
            //{
            //    return new ErrorDataResult<List<Car>>(Messages.MaintenanceTime);
            //}

            return new SuccessDataResult<List<Car>>(_carDal.GetAll(),Messages.CarsListed);
            
        }                

        
        public IResult Update(Car car)
        {
            if (car.DailyPrice>0)
            {
                return new ErrorResult(Messages.UpdatedFailed);
            }

            _carDal.Add(car);
            return new SuccessResult(Messages.Updated);
            
        }
                
        public IDataResult<List<CarDetailDto>> GetCarDetailDtos()
        {
            return new SuccessDataResult<List<CarDetailDto>>(_carDal.GetCarDetailDtos());
        }

        public IDataResult<Car> GetById(int id)
        {
            return new SuccessDataResult<Car>(_carDal.Get(c => c.CarId == id));
        }
    }
}
