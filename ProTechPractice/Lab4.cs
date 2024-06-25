using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProTechPractice
{
    internal class Lab4 : Lab3
    {
        // набор гласных
        protected static string vowels = "aeiouy";
        // индекс первой гласной буквы
        protected static int firstLetter = -1;
        // индекс последней гласной буквы
        protected static int lastLetter = -1;
        // поиск наибольшой подстроки
        public static void LargestString()
        {
            correctedLetters = correctedLine.ToCharArray();
            if (flag)
            {
                for (int i = 0; i < correctedLetters.Length; i++)
                {
                    if (vowels.Contains(correctedLetters[i].ToString()))
                    {
                        firstLetter = i;
                        break;
                    }
                }
                for (int i = correctedLetters.Length - 1; i >= 0; i--)
                {
                    if (vowels.Contains(correctedLetters[i].ToString()))
                    {
                        lastLetter = i;
                        break;
                    }
                }
                for (int i = firstLetter; i <= lastLetter; i++)
                {
                    Console.Write(correctedLetters[i]);
                }
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("Введены неверные символы:");
            }
        }
    }
}
