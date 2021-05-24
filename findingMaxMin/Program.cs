using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace findingMaxMinExamples
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = 3;
            double b = 9;
            double c = Math.Max(a, b);
            Console.WriteLine(c); // выводит на экран число 9
            double d = Math.Min(a, b);
            Console.WriteLine(d); // выводит на экран число 3
        }
    }
}