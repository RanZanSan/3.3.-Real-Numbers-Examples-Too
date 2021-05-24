using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace findingModulusNumberExample
{
    class Program
    {
        static void Main(string[] args)
        {
            //Для нахождения модуля числа, используется функция Abs([число]);
            int b = -9;
            double a = Math.Abs(b); // берем модуль числа
            Console.WriteLine(a); // выводит на экран число 9
        }
    }
}