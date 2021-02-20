using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Linq.Expressions;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfRentalDal : EfEntityRepositoryBase<Rental, RentACarContext>, IRentalDal
    {
        public List<RentalDetailDto> GetRentalDetails(Expression<Func<Rental, bool>> filter = null)
        {
            using (RentACarContext context = new RentACarContext())
            {
                var result = from r in context.Rentals
                             join c in context.Cars
                             on r.CarId equals c.CarId
                             join u in context.Users
                             on r.Id equals u.Id
                             join co in context.Customers
                             on r.CustomerId equals co.UserId
                             select new RentalDetailDto
                             {
                                 RentId = r.Id,
                                 CarId = c.CarId,
                                 UserId = u.Id,
                                 CarName = c.CarName,

                                 UserName = u.FirstName + " " + u.LastName,

                                 RentDate = r.RentDate,
                                 ReturnDate = (DateTime)r.ReturnDate
                             };
                return result.ToList();


            }
        }
    }
}
