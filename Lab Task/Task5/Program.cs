using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int Num;
            Console.Write(" Enter a number: ");
            Num = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(" Multiplication Table of " + Num + " is : ");
            Console.Write("\n");
            for (int i = 1; i <= 10; i++)
            {
                int Mul = Num * i;

                Console.WriteLine ($" {Num} x {i} = {Mul}  ");
                

            }

            Console.ReadLine();
            
        }
    }
}
