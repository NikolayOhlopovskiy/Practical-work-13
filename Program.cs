using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp13._3
{
    /// <summary>
    /// Задача 3. Найти s=min(a, b) + min(c, d), 
    /// используя вспомогательные функции 
    /// (ввода аргументов, нахождения минимальной величины, вывода результата).
    /// </summary>
    class Program
    {
        static int Min(int a, int b)
        {
            return a < b ? a : b;
        }
        static int Input(string messanger)
        {
            Console.Write(messanger);
            return int.Parse(Console.ReadLine());
        }
        static void Main(string[] args)
        {

            int a = Input("a=");
            int b = Input("b=");
            int c = Input("c=");
            int d = Input("d=");
            int f = Min(a, b) + Min(c, d);
            Console.WriteLine($"min={f}");
            Console.Read();
        }
    }
}
