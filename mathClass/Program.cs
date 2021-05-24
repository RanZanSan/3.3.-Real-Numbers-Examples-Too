using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mathClassExamples
{
    class Program
    {
        static void Main(string[] args)
        {
            //Для нахождения модуля числа, используется функция Abs([число]);

            int b = -9;
            double a = Math.Abs(b); // берем модуль числа
            Console.WriteLine(a); // выводит на экран число 9 

            //Для возведения числа в степень, используется функция Pow([число], [степень]);

            b = 9;
            a = Math.Pow(b, 2); // возводим переменную b в степень 2
            Console.WriteLine(a); // выводит на экран число 81

            //Для нахождения квадратного корня служит функция Sqrt([число]); возвращаемый тип данных - double

            b = 9;
            a = Math.Sqrt(b);
            Console.WriteLine(a); // выводит на экран число 3


            //Для нахождения максимума / минимума из двух чисел служит функция Max/ Min([число1, число2]); возвращаемый тип данных совпадает с типом данных передаваемых чисел:

            a = 3;
            b = 9;
            double c = Math.Max(a, b);
            Console.WriteLine(c); // выводит на экран число 9
            double d = Math.Min(a, b);
            Console.WriteLine(d); // выводит на экран число 3
        }
    }
}