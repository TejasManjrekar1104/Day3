using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3
{
    class Function2
    {
        public static void add(int num1, int num2)
        {
            int result = num1 + num2;
            Console.WriteLine(result);
        }
        public static void Main6(string [] args)
        {
            Console.WriteLine("Enter the value of a and b:- ");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());

            Function2.add(a, b);

        }
    }
}
