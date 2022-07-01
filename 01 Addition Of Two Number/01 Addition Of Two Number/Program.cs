using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _01_Addition_Of_Two_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1,num2,Total;

            Console.WriteLine("Enter First Number:");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Second Number:");
            num2 = Convert.ToInt32(Console.ReadLine());

            Total = num1 + num2;

            Console.WriteLine("Total is : "+ Total);
            Console.ReadKey();

        }
    }
}
