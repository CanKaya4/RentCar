using Business.Concrete;
using DataAccess.Concrete.EntityFramework;

//CarDtoTest();

//ColorTest();

//BrandTest();

CarTest();
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