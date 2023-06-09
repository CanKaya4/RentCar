using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ICarService
    {
        IDataResult<List<Car>> GetAll();
        IDataResult<List<CarDetailDto>> GetCarDetails();
        IDataResult<List<Car>> GetAllByColor(int colorId);
        IDataResult<List<Car>> GetAllByBrand(int brandId);
        IDataResult<List<Car>> GetByUnitPrice(decimal min, decimal max);
        IDataResult<Car> GetById(int carId);
        IResult Add(Car car);
    }
}
