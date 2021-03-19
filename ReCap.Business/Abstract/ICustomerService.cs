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
        IResult DeleteCustomer(int customerId);
        IDataResult<List<Customer>> GetAll();
        IDataResult<Customer> Get(int customerId);
    }
}
