using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int milesDriven, gallonsOfGas, mpg;
                Console.WriteLine("Enter miles driven");
                milesDriven = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter gallons");
                gallonsOfGas = Convert.ToInt32(Console.ReadLine());
                mpg = milesDriven / gallonsOfGas;
                Console.WriteLine("You got {0} mpg", mpg);
            }
            catch(DivideByZeroException excep)
            {
                Console.WriteLine("Cannot div by 0");
                Console.WriteLine(excep.GetType().Name);
                Console.WriteLine(excep.Message);
            }

            
        }
    }
}
