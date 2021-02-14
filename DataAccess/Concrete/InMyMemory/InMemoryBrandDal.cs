using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.InMyMemory
{
    public class InMemoryBrandDal : IBrandDal
    {
        List<Brand> _brands;
        public InMemoryBrandDal()
        {
            _brands = new List<Brand>
            {
                new Brand(){BrandId = 10, BrandName = "Renault"},
                new Brand(){BrandId = 10, BrandName = "Audi"},
                new Brand(){BrandId = 10, BrandName = "Bmw"},
                new Brand(){BrandId = 10, BrandName = "Mercedes"},

            };

        }
        public void Add(Brand entity)
        {
            _brands.Add(entity);
        }

        public void Delete(int id)
        {
            var brandToDelete = _brands.SingleOrDefault(b => b.BrandId == id);
            _brands.Remove(brandToDelete);

        }

        public void Delete(Brand entity)
        {
            throw new NotImplementedException();
        }

        public Brand Get(Expression<Func<Brand, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Brand> GetAll(Expression<Func<Brand, bool>> filter = null)
        {
            return _brands;
        }

        public List<Brand> GetById(int Id)
        {
            throw new NotImplementedException();
        }

        public void Update(Brand entity)
        {
            var brandToUpdate = _brands.SingleOrDefault(b => b.BrandId == entity.BrandId);
            brandToUpdate.BrandName = entity.BrandName;
        }
    }
}
