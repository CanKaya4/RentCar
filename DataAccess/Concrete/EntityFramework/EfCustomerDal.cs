using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCustomerDal : EfEntityRepositoryBase<Customer, CarWindContext>, ICustomerDal
    {
        //public List<CustomerDetailDto> GetCustomerDetail()
        //{
        //    using (CarWindContext context = new CarWindContext())
        //    {
        //        var result = from c in context.Customers
        //                     join u in context.Users
        //                     on c.Id equals u.Id
        //                     select new CustomerDetailDto { CompanyName = c.CompanyName, CustomerId = c.Id, UserName = u.Id };
        //        return result.ToList(); 
        //    }
        //}
    }
}
