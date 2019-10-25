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
        }
    }
}
