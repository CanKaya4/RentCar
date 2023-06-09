using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        ICarDal _carDal;

        public CarManager(ICarDal carDal)
        {
            _carDal = carDal;
        }

        public IResult Add(Car car)
        {
            if (car.Description.Length>10)
            {
                return new ErrorResult(Messages.CarDesciptionInValid);
            }
             _carDal.Add(car);
            return new SuccessResult(Messages.CarAdded);
            
        }

        public IDataResult<List<Car>> GetAll()
        {
            return new DataResult(_carDal.GetAll());
        }

        public IDataResult<List<Car>> GetAllByBrand(int brandId)
        {
            return new DataResult(_carDal.GetAll(c => c.BrandId == brandId));
        }

        public IDataResult<List<Car>> GetAllByColor(int colorId)
        {
            return new DataResult(_carDal.GetAll(c => c.ColorId == colorId));
        }

        public IDataResult<Car> GetById(int carId)
        {
            return new DataResult(_carDal.Get(c => c.CarId == carId));
        }

        public IDataResult<List<Car>> GetByUnitPrice(decimal min, decimal max)
        {
            return new DataResult(_carDal.GetAll(c => c.DailyPrice >= min && c.DailyPrice <= max));
        }

        public IDataResult<List<CarDetailDto>> GetCarDetails()
        {
            return new DataResult(_carDal.GetCarDetails());
        }
    }
}
