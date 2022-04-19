using Core.DataAccess;
using Core.Entities;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Absract
{
   public interface ICarDal:IEntityRepository<Car>
    {
        List<CarDto> GetCarDetails();
    }
}
