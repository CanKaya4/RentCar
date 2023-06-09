using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;

//CarDtoTest();

//ColorTest();

//BrandTest();

//CarTest();

//CustomerListedTest();

//CustomerTest();

RentalTest();

RentalManager rentalManager = new RentalManager(new EfRentalDal());
var result1 = rentalManager.Add(new Rental
{
    CarId = 8,
    CustomerId = 1,
    RentDate = DateTime.Now,
    ReturnDate = DateTime.Now,
});
Console.WriteLine(result1.Message);
static void ColorTest()
{
    ColorManager colorManager = new ColorManager(new EfColorDal());
    foreach (var item in colorManager.GetAll())
    {
        Console.WriteLine("Renk İsmi \n" + item.ColorName);
    }
}

static void BrandTest()
{
    BrandManager brandManager = new BrandManager(new EfBrandDal());
    foreach (var item in brandManager.GetAll())
    {
        Console.WriteLine("Marka İsmi \n" + item.BrandName);
    }
}

static void CarTest()
{
    CarManager carManager = new CarManager(new EfCarDal());
    var result = carManager.GetAll();
    if (result.Success == true)
    {
        foreach (var item in carManager.GetAll().Data)
        {
            Console.WriteLine("Araba Açıklaması \n" + item.Description);
        }
    }
    else
    {
        Console.WriteLine(result.Message);
    }

}

static void CarDtoTest()
{
    CarManager carManager = new CarManager(new EfCarDal());
    foreach (var item in carManager.GetCarDetails().Data)
    {
        Console.WriteLine(item.CarId + "||" + item.ColorName);
    }
}

static void CustomerListedTest()
{
    CustomerManager customerManager = new CustomerManager(new EfCustomerDal());
    foreach (var item in customerManager.GetAll().Data)
    {
        Console.WriteLine(item.CompanyName);
    }
}

static void CustomerTest()
{
    CustomerManager customerManager = new CustomerManager(new EfCustomerDal());
    foreach (var item in customerManager.GetAll().Data)
    {
        Console.WriteLine(item.CompanyName);
    }
}

static void RentalTest()
{
    RentalManager rentalManager = new RentalManager(new EfRentalDal());
    foreach (var item in rentalManager.GetAll().Data)
    {
        Console.WriteLine(item.RentDate);
    }
}