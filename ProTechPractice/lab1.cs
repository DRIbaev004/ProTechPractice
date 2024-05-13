using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ProTechPractice
{
    internal class lab1
    {
        static void Main(string[] args)
        {
            while (true)
            {
                string line = Console.ReadLine();
                char[] words = line.ToCharArray();
                bool even = (line.Count() % 2) == 0;
                if (even)
                {
                    for (int i = (words.Length / 2) - 1; i >= 0; i--)
                    {
                        Console.Write(words[i]);
                    }
                    for (int i = words.Length - 1; i >= words.Length / 2; i--)
                    {
                        Console.Write(words[i]);
                    }
                    Console.WriteLine();
                }
                else
                {
                    for (int i = words.Length - 1; i >= 0; i--)
                    {
                        Console.Write(words[i]);
                    }
                    for (int i = 0; i < words.Length; i++)
                    {
                        Console.Write(words[i]);
                    }
                    Console.WriteLine();
                }
            } 
        }
    }
}
