using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeApplic
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Employee c1 = new Employee("Rico", 1324573587, 4500);
            c1.DisplayStats();
            Console.WriteLine("==============");

            Employee c2 = new Employee("Rider", 154665, 4100);
            c2.DisplayStats();
            c2.Name = "River";
            Console.WriteLine();
            c2.GiveBonus(150);
            c2.DisplayStats();
            Console.WriteLine("=======================");

            Employee c3 = new Employee("Mike", 33, 124785787, 25478.34F, "");
            c3.DisplayStats();
            Console.WriteLine("--------------------");
            Employee c4 = new Employee("", 0, 0)
            {
                Name = "Fedor",
                ID = 475787888,
                Pay = 4787,
                Age = 45

            };
            
            c4.DisplayStats();
            Console.WriteLine("--------------------");

            Employee c5 = new Employee("Borut", 47, 745472456, 4757.45F, "4784576544");
            c5.DisplayStats();

            Console.ReadKey();
        }
    }
}
