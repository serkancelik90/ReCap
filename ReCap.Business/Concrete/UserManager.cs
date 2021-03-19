using Core.Entities.Concrete;
using Core.Utilities.Results;
using ReCap.Business.Abstract;
using ReCap.Business.Constants;
using ReCap.DataAccess.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace ReCap.Business.Concrete
{
    public class UserManager : IUserService
    {
        IUserDal _userDal;

        public UserManager(IUserDal userDal)
        {
            _userDal = userDal;
        }

        public  List<OperationClaim> GetClaims(User user)
        {
            _userDal.GetClaims(user);
            return _userDal.GetClaims(user);
        }

        public IResult Add(User user)
        {
            _userDal.Add(user);
            return new SuccessResult(Messages.UserAdded);
          
        }

        public IDataResult <User> GetByMail(string email)
        {
          return new SuccessDataResult<User> (_userDal.Get(u => u.Email == email));
           
        }
    }
}
