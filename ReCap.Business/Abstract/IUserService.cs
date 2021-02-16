using Core.Utilities.Results;
using ReCap.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace ReCap.Business.Abstract
{
    public interface IUserService
    {
        IDataResult<List<User>> GetAll();
        IResult AddUser(User user);
        IResult DeleteUser(User user);
    }
}
