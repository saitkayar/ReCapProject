using Core.DataAccess;
using Core.DataAccess.EntityFramework;
using DataAccess.Absract;
using Entities.Concrete;
using Entities.DTOs;
using System.Collections.Generic;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfRentalDal : EfEntityRepositoryBase<Rental, RentContext>, IEntityRepository<Rental>, IRentalDal
    {
        //public List<RentalDetailDto> GetRentalsDetails()
        //{
        //    using (RentContext context = new RentContext())
        //    {
        //        var result =
        //            from rental in context.Rentals
        //            join customer in context.Customers on rental.CustomerId equals customer.Id
        //            join user in context.Users on customer.UserId equals user.Id
        //            join car in context.Cars on rental.CarId equals car.Id
        //            join brand in context.Brands on car.BrandId equals brand.Id
        //            select new RentalDetailDto()
        //            {
        //                Id = rental.Id,
        //                CarBrand = brand.BrandName,
        //                CarModel = car.ModelYear,
        //                CustomerFirstName = user.FirstName,
        //                CustomerLastName = user.LastName,
                     
        //                RentDate = rental.RentDate,
        //                ReturnDate = (DateTime)rental.ReturnDate
        //            };
        //        return result.ToList();
        //    }
        //}
    }
}
