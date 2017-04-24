using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HalloGitHub2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hallo GitHub2");
            Console.WriteLine("enter a");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("enter b");
            double b = double.Parse(Console.ReadLine());
            double erg = Add(a, b);
            Console.WriteLine("{0}+{1}={2}",a,b,erg);
            Console.ReadLine();
        }

        static double Add(double a, double b)
        {
            return a+b;
        }
    }
}
