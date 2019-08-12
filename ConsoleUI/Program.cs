using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person();

            p.FirstName = "Timothy";
            p.LastName = "Corey";

            Console.WriteLine(p.FunkyNameBuilder());

            Console.ReadLine();
        }
    }
}
