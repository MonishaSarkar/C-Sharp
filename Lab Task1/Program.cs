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
            student s = new student();
            student s1 = new student("Monisha", "22-47063-1", "CSE", 3.25f);

            s.setName("Monisha");
            s.setId("22-47063-1");
            s.setDepartment("CSE");
            s.setCgpa(3.25f);
            s.ShowInfo();
            Console.WriteLine("--------------------------");
            s1.ShowInfo();
            Console.ReadLine();
        }
    }
}
