using Core.Utilities;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
  public  interface ICarService
    {

      IDataResult< List<Car>> GetAll();
        IDataResult<List<CarDto>> GetCarDetails();
       IDataResult< Car> GetById(int Id);

        IResult Add(Car car);
        IResult Delete(Car car);
        IResult Update(Car car);
        IDataResult<List<Car>> GetCarByBrand(int brandId);
        IDataResult<List<Car>> GetCarByColor(int colorId);
    }
}
