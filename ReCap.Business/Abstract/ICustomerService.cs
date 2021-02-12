using Core.Utilities.Results;
using ReCap.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace ReCap.Business.Abstract
{
   public interface ICustomerService
    {
        IResult AddCustomer(Customer customer);
    }
}
