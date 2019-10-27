using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpFun
{
    class Program : DelegateExample
    {
        static void Main(string[] args)
        {

            /*Console.WriteLine("This is all about C Sharp");

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
            vehicle1.Luxary();*/


            //Delegate Example
            HelloFunctinDelegate del = new HelloFunctinDelegate(Hello);
            del("Hello from Delegate");


            //Delegate with another example
            List<Employee> empList = new List<Employee>();

            empList.Add(new Employee { ID = 101, Name = "Nancy", Salary = 5000, Experience = 5 });
            empList.Add(new Employee { ID = 102, Name = "Mike", Salary = 4000, Experience = 4 });
            empList.Add(new Employee { ID = 103, Name = "Smith", Salary = 6000, Experience = 6 });
            empList.Add(new Employee { ID = 104, Name = "David", Salary = 3000, Experience = 3 });

            //IsPromotable isPromotable = new IsPromotable(Promote);

            Employee.PromoteEmployee(empList, /*isPromotable*/ emp => emp.Experience >= 5);
        }

        //when we use Lamda expression we don't need this function
        /*public static bool Promote(Employee emp)
        {
            if(emp.Experience >= 5)
            {
                return true;
            }
            else
            {
                return false;
            }
        }*/
    }

    delegate bool IsPromotable(Employee empl);


    class Employee
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }
        public int Experience { get; set; }


        public static void PromoteEmployee(List<Employee> employeeList, IsPromotable IsEligibleToPromote)
        {
            foreach (Employee employee in employeeList)
            {
                if(IsEligibleToPromote(employee))
                {
                    Console.WriteLine(employee.Name + " Promoted");
                }
            }
        }
    }
}
