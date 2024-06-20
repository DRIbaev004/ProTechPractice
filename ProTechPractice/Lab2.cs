using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProTechPractice
{
    internal class Lab2 : Lab1
    {
        // Флаг для проверки правильности строки
        protected static bool flag = true;
        // Проверка правильности строки
        public static void IsTrue()
        {
            // проверка символов
            foreach(char letter in letters)
            {
                if (!(letter >= 'a' && letter <= 'z'))
                {
                    flag = false;
                }
            }// флаг определяет метод вывода строки
            if (flag)
            {
                WriteOfElements();
            }
            else
            {
                Console.WriteLine("Введены неверные символы:");
                WriteBadLetter();
                Console.WriteLine();
            }
        }
        // Вывод неверно введенных символов
        public static void WriteBadLetter() 
        {
            foreach (char letter in letters)
            {
                if (!(letter >= 'a' && letter <= 'z'))
                {
                    Console.Write(letter + " ");
                }
            }
        }
    }
}