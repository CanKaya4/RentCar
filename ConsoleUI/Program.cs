using Business.Concrete;
using DataAccess.Concrete.EntityFramework;

CarDtoTest();

//ColorTest();

//BrandTest();

//CarTest();
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
    foreach (var item in carManager.GetAll())
    {
        Console.WriteLine("Araba Açıklaması \n" + item.Description);
    }
}

static void CarDtoTest()
{
    CarManager carManager = new CarManager(new EfCarDal());
    foreach (var item in carManager.GetCarDetails())
    {
        Console.WriteLine(item.CarId + "||" + item.ColorName);
    }
}