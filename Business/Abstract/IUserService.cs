using Core.Entities.Concrete;
using Core.Utilities;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public  interface IUserService
    {
        List<OperationClaim> GetClaims(User user);
        void Add(User user);
        User GetByMail(string email);

        IDataResult<List<User>> GetAll();
        IDataResult<User> GetById(int userId);
        //IDataResult<List<OperationClaim>> GetClaims(User user);
        //IDataResult<User> GetByMail(string email);
        IDataResult<User> GetLastUser();

        //IResult Add(User user);
        IResult Update(User user);
        IResult Delete(User user);
    }
}
