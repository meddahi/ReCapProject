using Business.Concrete;
using DataAccess.Concrete.InMyMemory;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new InMemoryCarDal());
            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine(car.ModelYear +"  " +car.Description+"  "+car.DailyPrice );
            }
        
        }
    }
}
