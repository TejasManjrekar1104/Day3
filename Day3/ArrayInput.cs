using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3
{
    class ArrayInput
    {
        public static void Main3(string [] args)
        {
            Console.WriteLine("How many elements u want to add??");
            int element = Convert.ToInt32(Console.ReadLine());

            int[] arr = new int[element];

            for(int i = 0; i<element; i++)
            {
                Console.WriteLine("add element on " + (i + 1));
                int data = Convert.ToInt32(Console.ReadLine());
                arr[i] = data; 
            }

            Console.WriteLine("---------DATA---------");
            foreach(int i in arr)
            {
                Console.Write(i + " ");
            }
        } 
    }
}
