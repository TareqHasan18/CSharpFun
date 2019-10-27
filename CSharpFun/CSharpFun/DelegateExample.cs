using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpFun
{
    class DelegateExample
    {
        //A delegate is type safe function pointer. A delegate points to a function
        //Signature of the delegate should match the signature of the function, that is why
        // delegate is called type safe function pointer.
        public static void Hello(string strMessage)
        {
            Console.WriteLine(strMessage);
        }
    }

    public delegate void HelloFunctinDelegate(string Message);
}
