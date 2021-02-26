﻿using Core.Aspects.Autofac.Validation;
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
        [ValidationAspect(typeof(CustomerValidator))]
        public IResult AddCustomer(Customer customer)
        {
            _customerDal.Add(customer);
            return new SuccessResult(Messages.CustomerAdded);
        }
    }
}
