using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
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

        public IResult Add(Customer customer)
        {
            if (customer.CompanyName.Length > 5)
            {
                return new ErrorResult(Messages.CompanyNameInValid);
            }
            _customerDal.Add(customer);
            return new SuccessResult(Messages.CustomerAdded);
        }     

        IDataResult<Customer> ICustomerService.Get(int id)
        {
            return new SuccessDataResult<Customer>(_customerDal.Get(c=>c.Id == id),Messages.CustomerIdListed);
        }

        IDataResult<List<Customer>> ICustomerService.GetAll()
        {
            return new SuccessDataResult<List<Customer>>(_customerDal.GetAll(),Messages.CustomerListed);
        }
    }
}
