using Business.Conrete;
using DataAccess.Concrete;
using Entities.Concrete;
using System;

namespace ConsolUI
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car1 = new Car();
            Brand brand1 = new Brand();
            Color color1 = new Color();

            //car1.CarId = 1;
            car1.BrandId = 1;
            car1.ColorId = 1;
            car1.DailyPrice = 90;
            car1.ModelYear = 2011;
            car1.Description = "Güzel Araba";

            brand1.BrandId = 1;
            brand1.BrandName = "Opel";

            color1.ColorId = 1;
            color1.ColorName = "Siyah";

            CarManager carManager = new CarManager(new EfCarDal());
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            ColorManager colorManager = new ColorManager(new EfColorDal());
            //Console.WriteLine(carManager.Add(car1).Message);
            //brandManager.Add(brand1);
            //colorManager.Add(color1);
            //carManager.Delete(car1);
            //brandManager.Delete(brand1);
            //colorManager.Delete(color1);
            //carManager.DeleteById(1);
            var result = carManager.GetByCarDetails();
            Console.WriteLine(result.Message);
            foreach (var item in result.Data)
            {
                Console.WriteLine(item.CarId + " " + item.BrandName + " " + item.ColorName + " " + item.DailyPrice + " " + item.ModelYear);
            }
            //foreach (var carr in carManager.GetAll())
            //{
            //    Console.WriteLine(carr.Description);
            //}


        }
    }
}
