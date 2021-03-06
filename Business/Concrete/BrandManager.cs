﻿using Business.Abstract;
using Business.Constants;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Validation;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class BrandManager : IBrandService
    {
        IBrandDal _brandDal;
        public BrandManager(IBrandDal brandDal)
        {
            _brandDal = brandDal;
        }

        [ValidationAspect(typeof(BrandValidator))]
        public IResult Add(Brand brand)
        {
            if (brand.BrandName.Length>2)
            {
                return new ErrorResult(Messages.CantAdded);                
            }
            _brandDal.Add(brand);
            return new SuccessResult(Messages.Added);
        }
        
        public IResult Delete(Brand brand)
        {
            return new SuccessResult(Messages.Deleted);
        }

        
        public IDataResult<List<Brand>> GetAll()
        {
            return new SuccessDataResult<List<Brand>>(_brandDal.GetAll());
        }

        
        public IDataResult<Brand> GetById(int id)
        {
            return new SuccessDataResult<Brand>(_brandDal.Get(b => b.BrandId == id));
        }

        public IResult Update(Brand brand)
        {
            if (brand.BrandName.Length>=2)
            {
                return new ErrorResult(Messages.UpdatedFailed);
            }
            _brandDal.Update(brand);
            return new SuccessResult(Messages.Updated);
        }
                   

        
    }
}
