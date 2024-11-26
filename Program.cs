using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp13._2
{
    /// <summary>
    /// Задача 2. Найти минимальную величину их трех целых переменных a, b, c
    /// с использованием вспомогательных методов 
    /// (ввода аргументов, нахождения минимальной величины, вывода результата).
    /// </summary>
    class Program
    {
        static int Min(int a,int b)
        {
            return a < b ? a : b;
        }
        static int Input(string messanger)
        {
            Console.Write(messanger);
            return int.Parse(Console.ReadLine());
        }
        static void Output(int min)
        {
            Console.WriteLine($"min={min}");
        }
        static void Main(string[] args)
        {
            int a = Input("a=");
            int b = Input("b=");
            int c = Input("c=");
            int min = Min(Min(a, b), c);
            Output(min);
            Console.Read();
        }
    }
}
