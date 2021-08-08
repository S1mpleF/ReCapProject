using Core.Entities.Concrete;
using Core.Utilities.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IUserService
    {

        IDataResult<List<User>> GetAll();
        IResult Add(User user);
        IResult Update(User user);
        IResult Delete(User user);
        IDataResult<User> GetById(int Id);
        IDataResult<List<OperationClaim>> GetClaims(User user);
        IDataResult<User> GetUserByEmail(string email);
        User GetByMail(string mail);
    }
}
