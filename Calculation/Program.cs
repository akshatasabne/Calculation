using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Airthmatical a1=new Airthmatical();
            int res1 = a1.Addition(2, 3);
            int res2 = a1.Addition(3, 4,5);
            double res3 = a1.Addition(4.5, 3.5);
            Console.WriteLine(res1);
            Console.WriteLine(res2);
            Console.WriteLine(res3);
            int res4 = a1.Subtraction(2, 3);
            int res5 = a1.Subtraction(3, 4, 5);
            double res6 = a1.Subtraction(4.5, 6.5);
            Console.WriteLine(res4);
            Console.WriteLine(res5);
            Console.WriteLine(res6);
            int res7 = a1.Multiplication(4, 5);
            int res8 = a1.Multiplication(3, 4, 5);
            double res9 = a1.Multiplication(4.5, 6.5);
            Console.WriteLine(res7);
            Console.WriteLine(res8);
            Console.WriteLine(res9);
        }
    }
}
