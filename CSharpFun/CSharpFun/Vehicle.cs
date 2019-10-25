using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpFun
{
    class Vehicle
    {
        public void Start()
        {
            Console.WriteLine("This car has auto Start");
        }

        public void Stop()
        {
            Console.WriteLine("This car has auto Stop");
        }

        public void mileage()
        {
            //int Mile = 0;
            Console.Write("Please enter the mile: ");
            int Mile = int.Parse(Console.ReadLine());

            if (Mile > 40)
            {
                Console.WriteLine("This Car has good mileage");
            }
            else
            {
                Console.WriteLine("This car does not have good mileage");
            }
        }
    }
}
