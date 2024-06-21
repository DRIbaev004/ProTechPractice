using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.IO.IsolatedStorage;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ProTechPractice
{
    internal class Lab1
    {
        //полученная строка
        protected static string line;
        // массив char для полученной строки
        protected static char[] letters;
        // массив char для исправленной строки
        protected static char[] correctedLetters;
        // исправленная строка
        protected static string correctedLine = "";
        
        // чтение строки и перевод в массив символов
        public static void ReadOfLine()
        {
            line = Console.ReadLine();
            letters = line.ToCharArray();
        }
        // проверка четности строки и соответсвующий вывод
        public static void WriteOfElements()
        {
            RemoveCorretedLine();
            if ((line.Count() % 2) == 0)// проверка четности
            {
                for (int i = (letters.Length / 2) - 1; i >= 0; i--)
                {
                    Console.Write(letters[i]);
                    correctedLine = correctedLine + letters[i];
                }
                for (int i = letters.Length - 1; i >= letters.Length / 2; i--)
                {
                    Console.Write(letters[i]);
                    correctedLine = correctedLine + letters[i];
                }
                Console.WriteLine();
            }
            else
            {
                for (int i = letters.Length - 1; i >= 0; i--)
                {
                    Console.Write(letters[i]);
                    correctedLine = correctedLine + letters[i];
                }
                for (int i = 0; i < letters.Length; i++)
                {
                    Console.Write(letters[i]);
                    correctedLine = correctedLine + letters[i];
                }
                Console.WriteLine();
            }
        }
        // удаление исправленной строки
        public static void RemoveCorretedLine()
        {
            for(int i = 0;i < correctedLine.Length;i++)
            {
                correctedLine =correctedLine.Remove(i);
            }
        }
    }
}
