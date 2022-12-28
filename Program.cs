using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace discrete_project_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            Console.WriteLine("enter the first number");
            int first = int.Parse(Console.ReadLine());
            Console.WriteLine("enter the second number ");
            int second = int.Parse(Console.ReadLine());
            Console.WriteLine("----------------------");

            for (int i = first; i < second; i++)
            {
                if (i == 0)
                    continue;
                int s = 0;
                for (int j = 1; j < i; j++)
                {
                    if (i % j == 0)
                        s = s + j;
                     
                }

                if (s == i)
                Console.WriteLine(i);
               
            }
            Console.WriteLine("----------------------\nend");


        }
    }
}
