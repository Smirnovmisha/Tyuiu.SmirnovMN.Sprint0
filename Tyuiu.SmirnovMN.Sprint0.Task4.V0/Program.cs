using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.SmirnovMN.Sprint0.Task4.V0.Lib;
namespace Tyuiu.SmirnovMN.Sprint0.Task4.V0
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(DataService.Addition(1, 99));
            Console.WriteLine(DataService.Subtraction(40, 5));
            Console.WriteLine(DataService.Addition(10, 10));
            Console.WriteLine(DataService.Addition(5, 5));

            Console.ReadKey();
        }
    }
}
