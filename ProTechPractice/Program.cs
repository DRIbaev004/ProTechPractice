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
            }
        }
    }
}
