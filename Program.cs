using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp13._6
{
    /// <summary>
    /// Задача 6. Определить статический метод void Numbers (int n),
    /// который выводит на экран четные числа от 2 до числа n.
    /// Используя этот метод, вывести на экран четные числа: а) от 2 до 20; б) от 2 до 50; в) от 2 до m(m вводится с клавиатуры).
    /// </summary>
    class Program
    {
        public static void Numbers(int n)
        {
            for(int i=2;i<=n;i+=2)
            {
                Console.Write(i + "");
                Console.WriteLine();
            }
        }
        static void Main(string[] args)
        {
            Console.Write("a)");
            Numbers(20);
            Console.Write("б)");
            Numbers(50);
            Console.Write("в)Введите значение m:");
            int m = int.Parse(Console.ReadLine());
            Numbers(m);
            Console.Read();
        }
    }
}
