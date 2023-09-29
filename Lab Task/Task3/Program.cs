using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int Degree1, Degree2, Degree3, SumDegree;
            

            Console.Write(" Enter a Degree 1 for Triangle: ");
            Degree1 = Convert.ToInt32(Console.ReadLine());

            Console.Write(" Enter a Degree 2 for Triangle: ");
            Degree2 = Convert.ToInt32(Console.ReadLine());

            Console.Write(" Enter a Degree 3 for Triangle: ");
            Degree3 = Convert.ToInt32(Console.ReadLine());


            SumDegree = Degree1 + Degree2 + Degree3;
            if (SumDegree == 180)
            {
                Console.WriteLine(" Result: Triangle is valid");
            }
            else
            {
                Console.WriteLine(" Result: Triangle is unvalid");
            }
            Console.ReadLine();

        }
    }
}
