using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabTask1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int score;
            Console.Write("Enter a Score: ");
            score = Convert.ToInt32(Console.ReadLine());
            if(score<50)
            {
                Console.WriteLine("Grade is : F");

            }
            else if(score>=50 && score<=59)
            {
                Console.WriteLine("Grade is : D");

            }
            else if (score >= 60 && score<=69)
            {
                Console.WriteLine("Grade is : C");

            }
            else if (score >= 70 && score<=79)
            {
                Console.WriteLine("Grade is : B");

            }
            else if (score >= 80 && score <= 89)
            {
                Console.WriteLine("Grade is : A");

            }
            else if (score >= 90 && score <= 100)
            {
                Console.WriteLine("Grade is : A+");

            }
            else
            {
                Console.WriteLine("Invalid");
            }

            Console.ReadLine();

        }
    }
}
