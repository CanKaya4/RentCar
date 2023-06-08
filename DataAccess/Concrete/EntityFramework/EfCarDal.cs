using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCarDal : EfEntityRepositoryBase<Car, CarWindContext>, ICarDal
    {
        public List<CarDetailDto> GetCarDetails()
        {
            using (CarWindContext context = new CarWindContext())
            {
                var result = from c in context.Cars
                             join r in context.Colors
                             on c.CarId equals r.ColorId
                             select new CarDetailDto { CarId = c.CarId, Description = c.Description, ColorId = r.ColorId, ColorName = r.ColorName };
                return result.ToList();
            }
        }
    }
}
