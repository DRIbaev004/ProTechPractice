using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProTechPractice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                // 1 задание
                Console.WriteLine("Задание 1");
                Lab1.ReadOfLine();
                Lab1.WriteOfElements();
                Console.WriteLine("------------------------");
                // 2 задание
                Console.WriteLine("Задание 2");
                Lab2.IsTrue();
                Console.WriteLine("------------------------");
                // 3 задание
                Console.WriteLine("Задание 3");
                Lab3.ToDictionary();
                Console.WriteLine("------------------------");
                // 4 задание
                Console.WriteLine("Задание 4");
                Lab4.LargestString();
                Console.WriteLine("------------------------");
                // 5 задание
                Console.WriteLine("Задание 5");
                Lab5.Choose();
                Console.WriteLine("------------------------");
            }
        }
    }
}
