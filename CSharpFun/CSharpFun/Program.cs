using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpFun
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("This is all about C Sharp");

            Vehicle vehicle = new Vehicle();
            vehicle.Start();
            vehicle.Stop();
            vehicle.mileage();


            Car car = new Car();
            car.Start();
            car.basic(30, 40);
            car.basic(30, 40, 50);
            car.Luxary();
            //vehicle.Luxary();

            Vehicle vehicle1 = new Car();
            vehicle1.Luxary();
        }
    }
}
