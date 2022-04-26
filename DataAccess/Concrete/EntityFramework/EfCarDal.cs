
using Core.DataAccess;
using Core.DataAccess.EntityFramework;
using DataAccess.Absract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCarDal : EfEntityRepositoryBase<Car, RentContext>, IEntityRepository<Car>, ICarDal
    {
        public List<CarDto> GetCarDetails()
        {
            using (var context=new RentContext())
            {
                var result = from c in context.Cars
                             join b in context.Brands
                             on c.BrandId equals b.Id
                             join co in context.Colors
                             on c.ColorId equals co.Id
                             select new CarDto
                             {
                                 CarId = c.Id,
                                 CarName = c.Name,
                                 BrandName = b.BrandName,
                                 ColorName = co.ColorName,
                                 ModelYear = c.ModelYear,
                                 DailyPrice = c.DailyPrice,
                                 Description = c.Description,

                             };
                return result.ToList();

            }
        }
        public List<CarDto> GetCarDetailDtos(Expression<Func<Car, bool>> filter = null)
        {
            using (var context = new RentContext())
            {
                var result =
                    from car in filter == null ? context.Cars : context.Cars.Where(filter)
                    join brand in context.Brands on car.BrandId equals brand.Id
                    join color in context.Colors on car.ColorId equals color.Id
                    join image in context.CarImages on car.Id equals image.CarId
                    select new CarDto
                    {
                        CarId = car.Id,
                        BrandName = brand.BrandName,
                        CarName = car.Name,
                        ColorName = color.ColorName,
                        DailyPrice = car.DailyPrice,
                        Description = car.Description,
                        ModelYear = car.ModelYear,
                        ImageId = image.Id,
                        ImagePath = image.ImagePath,
                        Date = image.Date,
                       
                    };
                return result.ToList();
            }
        }
    }
}
