using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calc
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your first number:");
            int num_1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter operation:");
            string oper = Console.ReadLine();

            Console.WriteLine("Enter your second number:");
            int num_2 = Convert.ToInt32(Console.ReadLine());
        }
    }
}
