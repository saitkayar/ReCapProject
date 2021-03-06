using Core.DataAccess;
using Core.DataAccess.EntityFramework;
using DataAccess.Absract;
using Entities.Concrete;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCustomerDal : EfEntityRepositoryBase<Customer, RentContext>, IEntityRepository<Customer>, ICustomerDal
    {
    }
}
