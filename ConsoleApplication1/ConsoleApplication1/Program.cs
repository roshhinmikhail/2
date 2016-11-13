using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            long u, u2, u3=1, u4=1, u5=0;
            Console.WriteLine("Введите целое число в десятичной системе");
            u = Convert.ToInt32(Console.ReadLine());
            u2 = u;
            while (u > 1) { u = u / 2; u3++; }
            while (u3 > 0) { u5 = u5 + (u2 % 2 * u4); u2 = u2 / 2; u4 = u4 * 10; u3--; }
            Console.WriteLine(u5);
            Console.ReadLine();
        }
    }
}
