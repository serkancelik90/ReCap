﻿using Core.Entities.Concrete;
using Core.Utilities.Results;
using System;
using System.Collections.Generic;
using System.Text;

namespace ReCap.Business.Abstract
{
    public interface IUserService
    {
        List<OperationClaim> GetClaims(User user);
       IResult Add(User user);
      IDataResult <User> GetByMail(string email);
    }
}
