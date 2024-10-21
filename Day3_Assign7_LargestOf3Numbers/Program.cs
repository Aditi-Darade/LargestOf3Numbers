using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3_Assign7_LargestOf3Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Enter 3 numbers to find the largest one:");
            System.Console.WriteLine("Number 1: ");
            string stringnNum1 = System.Console.ReadLine();
            int num1 = Convert.ToInt32(stringnNum1);

            System.Console.WriteLine("Number 2: ");
            string stringnNum2 = System.Console.ReadLine();
            int num2 = Convert.ToInt32(stringnNum2);

            System.Console.WriteLine("Number 3: ");
            string stringnNum3 = System.Console.ReadLine();
            int num3 = Convert.ToInt32(stringnNum3);

            bool a = num1 < num2;
            if (a == true)
            {
                bool b = num2 < num3;
                if (b == true)
                {
                    System.Console.WriteLine(num3);
                }
                else
                {
                    System.Console.WriteLine(num2);
                }
            }
            else
            {
                bool c = num1 < num3;
                if (c == true)
                {
                    System.Console.WriteLine(num3);
                }
                else
                {
                    System.Console.WriteLine(num1);
                }
            }
            System.Console.ReadKey();
        }
    }
}
