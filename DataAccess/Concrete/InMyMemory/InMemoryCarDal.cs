using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.InMyMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;
        public InMemoryCarDal()
        {
            _cars = new List<Car> { 
                new Car{BrandId = 5 , ColorId = 2 , DailyPrice = 1000, CarId = 1 ,ModelYear = "2004" , Description ="Audio"},
                new Car{BrandId = 6 , ColorId = 5 , DailyPrice = 2000, CarId = 2 ,ModelYear = "2008" , Description ="Focus"},
                new Car{BrandId = 7 , ColorId = 3 , DailyPrice = 3000, CarId = 3 ,ModelYear = "2010" , Description ="Kia"},
                new Car{BrandId = 8 , ColorId = 2 , DailyPrice = 4000, CarId = 4 ,ModelYear = "2015" , Description ="BMW"}
            };
        }
        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(c=>c.CarId == car.CarId);
            _cars.Remove(car);
        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetById(int Id)
        {
            return _cars.Where(c => c.CarId == c.CarId).ToList();
        }

        public List<CarDetailDto> GetCarDetailDtos()
        {
            throw new NotImplementedException();
        }

        public List<CarDetailDto> GetCarDetails()
        {
            throw new NotImplementedException();
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(c => c.CarId == car.CarId);
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;
            carToUpdate.CarId = car.CarId;
            carToUpdate.ModelYear = car.ModelYear;
        }
       
    }
}
