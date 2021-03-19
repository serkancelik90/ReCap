using Core.Aspects.Autofac.Caching;
using Core.Aspects.Autofac.Validation;
using Core.Utilities.Results;
using ReCap.Business.Abstract;
using ReCap.Business.Constants;
using ReCap.Business.ValidationRules.FluentValidation;
using ReCap.DataAccess.Abstract;
using ReCap.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace ReCap.Business.Concrete
{
    public class CustomerManager : ICustomerService
    {
        ICustomerDal _customerDal;
        public CustomerManager(ICustomerDal customerDal)
        {
            _customerDal = customerDal;
        }
        [CacheAspect]
        [ValidationAspect(typeof(CustomerValidator))]
        public IResult AddCustomer(Customer customer)
        {
            _customerDal.Add(customer);
            return new SuccessResult(Messages.CustomerAdded);
        }

        public IResult DeleteCustomer(int customerId)
        {
            var deletedCustomer = _customerDal.Get(x => x.CustomerId == customerId);
            if (deletedCustomer != null)
            {
                 _customerDal.Delete(deletedCustomer);
                return new SuccessResult();
            }
            return new ErrorResult();
            
        }

        public IDataResult<Customer> Get(int customerId)
        {
           return  new SuccessDataResult<Customer> (_customerDal.Get(x => x.CustomerId == customerId));
        }

        public IDataResult<List<Customer>> GetAll()
        {
            return new SuccessDataResult<List<Customer>>(_customerDal.GetAll());
        }
    }
}
