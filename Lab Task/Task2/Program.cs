using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double price, weight, price_Without_Tax, total_price, tax;
            
            Console.Write(" Enter The 1 kilo Potatoe price without Tax: ");
            price = Convert.ToDouble(Console.ReadLine());

            Console.Write(" Enter The  kilo you need : ");
            weight = Convert.ToDouble(Console.ReadLine());

            price_Without_Tax = price * weight;
            Console.WriteLine(" Price Without Tax: " + price_Without_Tax);

            Console.Write(" Enter The  Tax in Percent : ");
            tax = Convert.ToDouble(Console.ReadLine());

            total_price = (((price_Without_Tax / 100)*tax) + price_Without_Tax);
            Console.Write(" The total price with tax is : " + total_price);

            Console.ReadLine();


        }
    }
}
