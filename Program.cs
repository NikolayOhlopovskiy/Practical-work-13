using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp13._1
{
    /// <summary>
    /// //Задача 1.Найти минимальную величину из двух целых переменных a, b,
    //используя вспомогательные методы
    //(ввода аргументов, нахождения минимальной величины, вывода результата).
    /// </summary>
    class Program
    {
        static int min(int a,int b)
        {
            return a < b ? a : b;
        }
        static void Main(string[] args)
        {
            Console.Write("a=");
            int a = int.Parse(Console.ReadLine());
            Console.Write("b=");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine($"{min(a, b)}");
            Console.Read();
        }
    }
}
