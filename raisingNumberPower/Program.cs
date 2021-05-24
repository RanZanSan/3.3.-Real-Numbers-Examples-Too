using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace raisingNumberPowerExamples
{
    class Program
    {
        static void Main(string[] args)
        {
            double b = 9;
            double a = Math.Pow(b, 2); // возводим переменную b в степень 2
            Console.WriteLine(a); // выводит на экран число 81
        }
    }
}