using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int Num ;
            int Sum = 0;
            float Avg;

            Console.WriteLine("Enter the 5 integers Numbers: ");
            for (int i = 0; i < 5; i++)
            {
                Num = Convert.ToInt32(Console.ReadLine());
                Sum += Num;
            }
            Console.WriteLine("Sum of the 5 integers Number is : " + Sum);
            Avg = Sum / 5;
            Console.WriteLine("Average of the 5 integers Number is : " + Avg);

            Console.ReadLine();
        }
    }
}
