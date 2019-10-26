using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpFun
{
    class Car : Vehicle
    {
        //Compile Time Polymorphism (Early Binding or Overloading or Static Binding)
        public void basic(int GasPerMile1, int GasPerMile2)
        {
            Console.WriteLine("Car Gas Per Mile1 is: " + GasPerMile1);
            Console.WriteLine("Car Gas Per Mile2 is: " + GasPerMile2);
            Console.WriteLine("Car average Gas Per Mile is: " +(GasPerMile1+ GasPerMile2)/2);
        }

        public void basic(int GasPerMile1, int GasPerMile2, int GasPerMile3)
        {
            Console.WriteLine("Car Gas Per Mile1 is: " + GasPerMile1);
            Console.WriteLine("Car Gas Per Mile2 is: " + GasPerMile2);
            Console.WriteLine("Car Gas Per Mile3 is: " + GasPerMile3);
            Console.WriteLine("Car average Gas Per Mile is: " +(GasPerMile1 + GasPerMile2 + GasPerMile3)/3);
        }

        public override void Luxary()
        {
            Console.WriteLine("Car must be Luxary");
        }

    }
    
}
