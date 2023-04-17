//to find absolute difference
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABSOLUTE_DIFFERRNCE
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = 0, result;
            Console.WriteLine("enter the number");
            n = int.Parse(Console.ReadLine()); //user input
            result = Absdiff(n); //function call
            Console.WriteLine("absolute difference is :" + result); //output
        }
        static int Absdiff(int n)
        {
            int result = 0;
            if (n > 51)
            {
                 result =Math.Abs(3*( n - 51));
                
            }
            else
            {
               result = Math.Abs(n - 51);
            }
            return result;
        }
    }
}
