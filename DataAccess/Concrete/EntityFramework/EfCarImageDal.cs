using Core.DataAccess;
using Core.DataAccess.EntityFramework;
using DataAccess.Absract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
   public class EfCarImageDal:EfEntityRepositoryBase<CarImage,RentContext>, IEntityRepository<CarImage>,ICarImageDal
    {
    }
}
