using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProTechPractice
{
    internal class Lab3 : Lab2
    {
        // коллекция ключ-значение
        protected static Dictionary<Char, int> dictionary = new Dictionary<Char, int>();
        // добавление в коллекцию символов и их количество 
        public static void ToDictionary()
        {
            if (flag)
            {
                foreach (char letter in letters)
                {
                    if (dictionary.ContainsKey(letter))
                    {
                        dictionary[letter]++;
                    }
                    else
                    {
                        dictionary.Add(letter, 1);
                    }
                }
                foreach (var c in dictionary)
                {
                    Console.WriteLine(c);
                }
            }
            else 
            { 
                Console.WriteLine("Введены неверные символы:"); 
            }
            dictionary.Clear();
        }
    }
}
