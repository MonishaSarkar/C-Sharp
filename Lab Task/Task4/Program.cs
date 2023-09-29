using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int Numbers, Year, Weeks, Days;
            

            Console.Write(" Enter Numbers you need to calculate: ");
            Numbers = Convert.ToInt32(Console.ReadLine());

            Year = Numbers / 365;
            Console.WriteLine(" Convert to years: " + Year + " y");

            Weeks = (Numbers % 365)/7;
            Console.WriteLine(" Convert to Weeks: " + Weeks + " w");

            Days = (Numbers % 365) % 7;
            Console.WriteLine(" Convert to Days: " + Days + " d");


            Console.ReadLine();
        }
    }
}
