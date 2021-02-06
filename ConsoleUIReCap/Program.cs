using BusinessReCap.Concrete;
using DataAccessReCap.Concrete.EntityFramework;
using DataAccessReCap.Concrete.InMemory;
using EntitiesReCap.Concrete;
using System;

namespace ConsoleUIReCap
{
    class Program
    {
        static void Main(string[] args)
        {
            ProductManagerReCap productManagerReCap = new ProductManagerReCap(new EfCarDal());
            foreach (var product in productManagerReCap.GetAll())
            {
                Console.WriteLine(product.DailyPrice);
                Console.WriteLine(product.Description);
            }
            productManagerReCap.AddCar(new Car { BrandId = 2, ColorId = 21, DailyPrice = 1200, ModelYear = 20, Description = "M" }
            );
        }
    }
}
