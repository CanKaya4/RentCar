using Business.Abstract;
using Business.BusinessAspect.Autofac;
using Business.Constants;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac;
using Core.CrossCuttingConcerns;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class CustomerManager : ICustomerService
    {
        ICustomerDal _customerDal;

        public CustomerManager(ICustomerDal customerDal)
        {
            _customerDal = customerDal;
        }
        [ValidationAspect(typeof(CustomerValidator))]
        public IResult Add(Customer customer)
        {
           
            _customerDal.Add(customer);
            return new SuccessResult(Messages.CustomerAdded);
        }     

        IDataResult<Customer> ICustomerService.Get(int id)
        {
            return new SuccessDataResult<Customer>(_customerDal.Get(c=>c.Id == id),Messages.CustomerIdListed);
        }
        [SecuredOperation("admin.add,admin")]
        [ValidationAspect(typeof(CustomerValidator))]
        IDataResult<List<Customer>> ICustomerService.GetAll()
        {
            return new SuccessDataResult<List<Customer>>(_customerDal.GetAll(),Messages.CustomerListed);
        }
    }
}
