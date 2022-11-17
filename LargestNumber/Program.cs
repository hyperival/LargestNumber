using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LargestNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;

            Console.WriteLine("Enter Three Number");
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            c = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(" ");

            if (a > b && b < c) {
                Console.WriteLine("a is greater");
            }
            else if(b > c && b < a) {
                Console.WriteLine("b is greater");

            }
            else
            {
                Console.WriteLine("c is greater");
                    }
        }
    }
}
