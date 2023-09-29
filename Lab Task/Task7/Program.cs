using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int Number1, Number2;
            String Operator;
            float Answer;

            Console.Write("Enter a Number: ");
            Number1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter a Operator: ");
            Operator = Console.ReadLine();

            Console.Write("Enter another Number: ");
            Number2 = Convert.ToInt32(Console.ReadLine());

            switch(Operator)
            {

                case "+":

                      Answer = Number1 + Number2;
                      break;
                case "-":

                    Answer = Number1 - Number2;
                    break;
                case "*":

                    Answer = Number1 * Number2;
                    break;
                case "/":

                    Answer = Number1 / Number2;
                    break;
                default:
                    Answer = 0;
                    break;



            }
            Console.Write("\n");

            Console.WriteLine("The Answer is: " + Answer);

            Console.ReadLine();




        }
    }
}
