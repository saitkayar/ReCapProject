using Core.Utilities;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
  public  interface ICarService
    {
       

        IDataResult<List<Car>> GetAll();
        IDataResult<Car> GetById(int carId);
        IDataResult<List<Car>> GetAllByModelYear(int min, int max);
        IDataResult<List<Car>> GetByDailyPrice(decimal min, decimal max);
        IDataResult<List<Car>> GetCarsByBrandId(int brandId);
        IDataResult<List<Car>> GetCarsByColorId(int colorId);
        IDataResult<List<CarDto>> GetAllCarsDetails();
        IDataResult<List<CarDto>> GetCarDetailDtos(Expression<Func<Car, bool>> filter = null);
        IResult Add(Car car);
        IResult Delete(Car car);
        IResult Update(Car car);
    }
}
