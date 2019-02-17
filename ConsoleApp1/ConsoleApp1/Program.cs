using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Dzialania p = new Dzialania();
            Console.WriteLine(p.Dodawanie(3,5));
            Console.WriteLine(p.Mnożenie(3, 5));
            Console.ReadKey(); 
        }

    }
}
