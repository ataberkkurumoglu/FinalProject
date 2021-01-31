using BusinessReCap.Concrete;
using DataAccessReCap.Concrete.InMemory;
using System;

namespace ConsoleUIReCap
{
    class Program
    {
        static void Main(string[] args)
        {
            ProductManagerReCap productManagerReCap = new ProductManagerReCap(new InMemoryProductDalReCap());
            foreach (var product in productManagerReCap.GetAll())
            {
                Console.WriteLine(product.DailyPrice);
            }
        }
    }
}
