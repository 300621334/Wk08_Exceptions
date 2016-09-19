using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wk08_Exceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Divide 10 by");
                int num = int.Parse(Console.ReadLine());
                Console.WriteLine("10/{0} = {1}", num, (10/num));
            }
            catch(DivideByZeroException ex) //or "finally"
            {
                Console.WriteLine("Can't divide by zero");
                Console.WriteLine(ex.GetType().Name);
                Console.WriteLine(ex.Message);

                //throw new InvalidOperationException("Operation Failed", ex);
                // http://stackoverflow.com/questions/881473/why-catch-and-rethrow-an-exception-in-c
            }
        }
    }
}
